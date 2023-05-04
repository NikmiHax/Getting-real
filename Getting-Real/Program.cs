using Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;
using System;
using Getting_Real;

public class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("Velkommen til programmet. Indtast brugernavn:");
            string username = Console.ReadLine();

            Console.Write("Indtast adgangskode: ");
            string password = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                password += key.KeyChar;
                Console.Write("*");
            }


            if (username == "HOFOR" && password == "admin")
            {
                Console.WriteLine(" Login godkendt.");
                // Resten af programmet herunder
            }
            else
            {
                Console.WriteLine("Login fejlet. Programmet afsluttes.");
                Console.ReadKey();
                return;
            }

            string filePath = "C:\\Users\\elvir\\Downloads\\DelAfRAP-000478simplificeretA.xlsx";

            Console.WriteLine("Indtast navnet på den ønskede kolonne at sortere efter:");
            string columnName = Console.ReadLine();

            Console.WriteLine("Skriv 'Kør' for at starte:");
            string run = Console.ReadLine();

            if (run != "Kør")
            {
                Console.WriteLine("Programmet blev afbrudt.");
                Console.ReadKey();
                return;
            }

            // Åbn Excel-filen med Microsoft.Office.Interop.Excel
            var excel = new Application();
            Workbook wb;
            Worksheet ws;
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            // Find den ønskede kolonne ved at finde dens index baseret på navnet
            Range columnRange = ws.UsedRange.Find(columnName);
            if (columnRange == null)
            {
                Console.WriteLine($"Kolonne med navnet '{columnName}' blev ikke fundet.");
                Console.ReadKey();
                return;
            }

            int columnIndex = columnRange.Column;

            // Find interval-kolonnen baseret på den indtastede startværdi
            string intervalColumnName = GetIntervalColumnName(1);
            Range intervalColumnRange = ws.UsedRange.Find(intervalColumnName);
            if (intervalColumnRange == null)
            {
                Console.WriteLine($"Kolonne med navnet '{intervalColumnName}' blev ikke fundet.");
                Console.ReadKey();
                return;
            }

            int intervalColumnIndex = intervalColumnRange.Column;

            // Find navne-kolonnen
            Range nameColumnRange = ws.UsedRange.Find("Navn");
            if (nameColumnRange == null)
            {
                Console.WriteLine($"Kolonne med navnet 'Navn' blev ikke fundet.");
                Console.ReadKey();
                return;
            }

            int nameColumnIndex = nameColumnRange.Column;

            // Lav en liste over de rækker i arket med den ønskede kolonne, navne-kolonnen og interval-kolonnen
            List<string[]> rows = new List<string[]>();
            for (int row = 2; row <= ws.UsedRange.Rows.Count; row++)
            {
                string nameValue = ws.Cells[row, nameColumnIndex].Value.ToString();
                string columnValue = ws.Cells[row, columnIndex].Value.ToString();
                string intervalValue = ws.Cells[row, intervalColumnIndex].Value.ToString();
                string[] rowData = { nameValue, columnValue, intervalValue };
                rows.Add(rowData);
            }

            // Sorter rækkerne efter det ønskede interval og kolonne
            List<string[]> sortedRows = rows.OrderBy(x => x[2]).ThenBy(x => x[1]).ToList();

            // Udskriv de sorterede rækker til konsollen
            foreach (string[] rowData in sortedRows)
            {
                Console.WriteLine($"Navn: {rowData[0]}");
                Console.WriteLine($"Interval: {rowData[1]}");
                Console.WriteLine($"Timer/Uger/M/År: {rowData[2]}");

                // Udregn og udskriv tid indtil næste vedligeholdelse
                string maintenance = CalculateNextMaintenance(rowData[1], rowData[2]);
                Console.WriteLine(maintenance);

                Console.WriteLine();
            }




            // Luk Excel-filen og frigiv ressourcerne
            wb.Close();
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);

            Console.ReadKey();
        }

        static string GetIntervalColumnName(int start)
        {
            switch (start)
            {
                case int n when (n >= 1 && n <= 52):
                    return "UGE";
                case int n when (n >= 101 && n <= 112):
                    return "M";
                case int n when (n >= 2001 && n <= 2100):
                    return "År";
                default:
                    return "";
            }
        }

        static string CalculateNextMaintenance(string interval, string timerUgerMaar)
        {
            DateTime currentDate = DateTime.Now;
            DateTime nextMaintenanceDate;

            // Beregn næste vedligeholdelsestidspunkt afhængigt af interval og timerUgerMaar
            if (timerUgerMaar == "U")
            {
                int weeks = Int32.Parse(interval);
                nextMaintenanceDate = currentDate.AddDays(7 * weeks);
            }
            else if (timerUgerMaar == "M")
            {
                int months = Int32.Parse(interval);
                nextMaintenanceDate = currentDate.AddMonths(months);
            }
            else if (timerUgerMaar == "År")
            {
                int years = Int32.Parse(interval);
                nextMaintenanceDate = currentDate.AddYears(years);
            }
            else
            {
                // Hvis intervallet eller timer/uger/m/år-kolonnen ikke stemmer overens med forventningerne,
                // kan vi ikke beregne den næste vedligeholdelsestidspunkt
                return "Kan ikke beregne næste vedligeholdelsestidspunkt.";
            }


            // Beregn forskellen mellem de to datoer og formater resultatet som "dage:timer:minutter:sekunder"
            TimeSpan timeUntilNextMaintenance = nextMaintenanceDate - currentDate;
            string formattedTime = string.Format("{0} dage, {1} timer, {2} minutter, {3} sekunder",
                timeUntilNextMaintenance.Days,
                timeUntilNextMaintenance.Hours,
                timeUntilNextMaintenance.Minutes,
                timeUntilNextMaintenance.Seconds);

            return $"Næste smøring om: {nextMaintenanceDate.ToString()} ({formattedTime} tilbage)";
        }

    }
}
