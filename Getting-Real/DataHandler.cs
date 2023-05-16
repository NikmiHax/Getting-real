using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Getting_Real
{
    public class DataHandler
    {
        //FileStream fileStream = new FileStream("C:\\Users\\45402\\OneDrive - UCL Erhvervsakademi og Professionshøjskole\\Getting Real\\DelAfRAP-000478simplificeretA(134).csv", FileMode.Open);
        //StreamReader streamReader = new StreamReader(fileStream);

        //string line;
        //    while ((line = streamReader.ReadLine()) != null)
        //{
        //    Console.WriteLine(line);
        //}
        //streamReader.Close();
        //fileStream.Close(); 

        /*
        public void LoadList()
        {
            FileStream fileStream = new FileStream("C:\\Users\\45402\\OneDrive - UCL Erhvervsakademi og Professionshøjskole\\Getting Real\\DelAfRAP-000478simplificeretA(134).xlsx", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            streamReader.Close();
            fileStream.Close();
        }

        DataHandler handler = new DataHandler();

        handler.LoadList1();
        */

        /*

        public void LoadList1()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Ervin\Documents\side projects\Getting Real master\Getting-Real-master\DelAfRAP-000478simplificeretA(134).csv"))
            {
                string line;
                string[] columns = null;
                while ((line = sr.ReadLine()) != null)
                {
                    columns = line.Split(';');
                    //now columns array has a ll data of column in a row!
                    //like:
                    string col1 = columns[0]; //and so on..
                    string col2 = columns[1];

                    Console.WriteLine(col1 + ": " + col2);
                }
            }
        
        }
        */

        //public void readExcel()
        //{
        //    string filePath = "C:\\Users\\Ervin\\Documents\\side projects\\Getting Real master\\Getting-Real-master\\DelAfRAP-000478simplificeretA(134).xlsx";
        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //    Workbook wb;
        //    Worksheet ws;

        //    wb = excel.Workbooks.Open(filePath);
        //    ws = wb.Worksheets[1];

        //    Microsoft.Office.Interop.Excel.Range cell = ws.Range["C1:C800"];

        //    foreach (var CellValue in cell.Value)
        //    {
        //        Console.WriteLine(CellValue);
        //    }
        //}

        public void readExcel()

        {   // Angiv stien til Excel-filen, du vil læse
            string filePath =
                "C:\\Users\\45402\\OneDrive - UCL Erhvervsakademi og Professionshøjskole\\Getting Real\\DelAfRAP-000478simplificeretA.xlsx";

            // Opret en ny instans af Excel-applikationen
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Erklær variabler til at holde arbejdsbogen og regnearket
            Workbook wb;
            Worksheet ws;

            // Åbn Excel-filen placeret på den angivne filsti
            wb = excel.Workbooks.Open(filePath);

            // Vælg det første regneark (indeks 1) i arbejdsbogen
            ws = wb.Worksheets[1];

            // Opret et Range-objekt, der repræsenterer celleområdet fra C1 til C800 i det valgte regneark
            Microsoft.Office.Interop.Excel.Range cell = ws.Range["A1:J800"];

            //// Iterer gennem værdierne i celleområdet
            //foreach (var CellValue in cell.Value)

            //{
            //    if (CellValue != null && CellValue.ToString() == "2")
            //        Console.WriteLine(CellValue);
            //}

            foreach (Microsoft.Office.Interop.Excel.Range row in cell.Rows)
            {
                // Get the value of the first cell in the row
                var firstCellValue = row.Cells[1].Value?.ToString() ?? "";

                // Check if the value is 1 and the first cell is not empty
                if (firstCellValue == "55" && !string.IsNullOrEmpty(firstCellValue))
                {
                    // Print the row values to the console
                    for (int i = 1; i <= 10; i++)
                    {
                        var cellValue = row.Cells[i].Value?.ToString() ?? "";
                        cellValue = cellValue.Replace("\n", " ");
                        Console.Write(cellValue + "\t");
                    }
                    Console.WriteLine();
                }
            }


            wb.Close();
            excel.Quit();
        }


    }
}
