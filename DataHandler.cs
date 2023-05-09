using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Threading.Tasks.Sources;

namespace Getting_Real
{
    public class DataHandler
    {
        //public void LoadList()
        //{
        //    FileStream fileStream = new FileStream("C:\\Users\\Ervin\\Documents\\side projects\\Getting Real master\\Getting-Real-master\\DelAfRAP-000478simplificeretA(134).csv", FileMode.Open);
        //    StreamReader streamReader = new StreamReader(fileStream);

        //    string line;
        //    while ((line = streamReader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //    streamReader.Close();
        //    fileStream.Close();
        //}

        //public void LoadList1()
        //{
        //    using (StreamReader sr = new StreamReader(@"C:\Users\Ervin\Documents\side projects\Getting Real master\Getting-Real-master\DelAfRAP-000478simplificeretA(134).csv"))
        //    {
        //        string line;
        //        string[] columns = null;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            columns = line.Split(';');
        //            //now columns array has a ll data of column in a row!
        //            //like:
        //            string col1 = columns[0]; //and so on..
        //            string col2 = columns[1];
        //            string col3 = columns[2];
        //            string col4 = columns[3];

        //            Console.WriteLine(col3);

        //        }
        //    }
        //}

        public List<Machine> readExcel()
        {
            string filePath = "C:\\Users\\Ervin\\Documents\\side projects\\Getting Real master\\Getting-Real-master\\DelAfRAP-000478simplificeretA(134)1.xlsx";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range intervalRange = ws.Range["A2:A888"];
            Microsoft.Office.Interop.Excel.Range weekMonthYearRange = ws.Range["B2:B888"];
            Microsoft.Office.Interop.Excel.Range functionLocationRange = ws.Range["C2:C888"];
            Microsoft.Office.Interop.Excel.Range machineNameRange = ws.Range["D2:D888"];
            Microsoft.Office.Interop.Excel.Range coordinatesRange = ws.Range["E2:E888"];
            Microsoft.Office.Interop.Excel.Range lubricationPointRange = ws.Range["F2:F888"];
            Microsoft.Office.Interop.Excel.Range lubricationOilTypeRange = ws.Range["G2:G888"];
            Microsoft.Office.Interop.Excel.Range greaseTypeRange = ws.Range["H2:H888"];
            Microsoft.Office.Interop.Excel.Range volumeLiterRange = ws.Range["I2:I888"];
            Microsoft.Office.Interop.Excel.Range volumeGramsRange = ws.Range["J2:J888"];

            List<Machine> machines = new List<Machine>();

            for (int i = 1; i <= intervalRange.Count; i++)
            {
                string interval = intervalRange.Cells[i, 1].Value.ToString();
                string weekMonthYear = weekMonthYearRange.Cells[i, 1].Value.ToString();
                string functionLocation = functionLocationRange.Cells[i, 1].Value.ToString();
                string machineName = machineNameRange.Cells[i, 1].Value.ToString();
                string coordinates = coordinatesRange.Cells[i, 1].Value.ToString();
                string lubricationPoint = lubricationPointRange.Cells[i, 1].Value.ToString();
                string lubricationOilType = lubricationOilTypeRange.Cells[i, 1].Value.ToString();
                string greaseType = greaseTypeRange.Cells[i, 1].Value.ToString();
                string volumeLiter = volumeLiterRange.Cells[i, 1].Value.ToString();
                string volumeGrams = volumeGramsRange.Cells[i, 1].Value.ToString();

                Machine machine = new Machine(interval, weekMonthYear, functionLocation, machineName, coordinates, lubricationPoint, lubricationOilType, greaseType, volumeLiter, volumeGrams);
                machines.Add(machine);
            }

            wb.Close();
            excel.Quit();

            return machines;
        }

        
    }
}
