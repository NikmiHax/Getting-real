using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class Menu
    {
        int input;
        MachineRepository machineRepository = new MachineRepository();
        SortClass sortClass = new SortClass();

        public void Show()
        {


            Console.WriteLine("MENU: " +
                              "\nSorter efter koordinater tryk 1: " +
                              "\nSorter efter uge tryk 2: " +
                              "\nSorter efter måned tryk 3: " +
                              "\nSorter efter år tryk 4: " +
                              "\nSorter efter olie type tryk 5: " +
                              "\nSorter efter fedt type tryk 6: ");


            string inputStr = Console.ReadLine();
            input = int.Parse(inputStr);

            switch (input)
            {
                case 1:
                    List<Machine> sortedByCoordinates = sortClass.SortByCoordinates();
                    Console.WriteLine(sortedByCoordinates.Count);
                    sortClass.ShowDataHandlerMenu(sortedByCoordinates);
                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("MENU: " +
                                      "\nSorter efter indtastet interval (1, 2, 6, etc.) eller indtast 0 for at vise alle: ");

                    string inputIntervalWeek = Console.ReadLine();
                    List<Machine> sortedByWeek;

                    if (inputIntervalWeek == "0")
                    {
                        sortedByWeek = sortClass.SortByWeek();
                    }
                    else
                    {
                        sortedByWeek = sortClass.SortByWeek().Where(machine => machine.Interval == inputIntervalWeek).ToList();

                    }

                    foreach (var machine in sortedByWeek)
                    {
                        Console.WriteLine(machine.ToString());
                    }

                    Console.WriteLine(sortedByWeek.Count);
                    sortClass.ShowDataHandlerMenu(sortedByWeek);
                    break;

                case 3:
                    Console.Clear();

                    Console.WriteLine("MENU: " +
                                      "\nSorter efter indtastet interval (1, 2, 6, etc.) eller indtast 0 for at vise alle: ");

                    string inputIntervalMonth = Console.ReadLine();
                    List<Machine> sortedByMonth;

                    if (inputIntervalMonth == "0")
                    {
                        sortedByMonth = sortClass.SortByMonth();
                    }
                    else
                    {
                        sortedByMonth = sortClass.SortByMonth().Where(machine => machine.Interval == inputIntervalMonth).ToList();

                    }

                    foreach (var machine in sortedByMonth)
                    {
                        Console.WriteLine(machine.ToString());
                    }

                    Console.WriteLine(sortedByMonth.Count);
                    sortClass.ShowDataHandlerMenu(sortedByMonth);
                    break;

                case 4:
                    Console.Clear();

                    Console.WriteLine("MENU: " +
                                      "\nSorter efter indtastet interval (1, 2, 6, etc.) eller indtast 0 for at vise alle: ");

                    string inputIntervalYear = Console.ReadLine();
                    List<Machine> sortedByYear;

                    if (inputIntervalYear == "0")
                    {
                        sortedByYear = sortClass.SortByYear();
                    }
                    else
                    {
                        sortedByYear = sortClass.SortByYear().Where(machine => machine.Interval == inputIntervalYear).ToList();

                    }

                    foreach (var machine in sortedByYear)
                    {
                        Console.WriteLine(machine.ToString());
                    }

                    Console.WriteLine(sortedByYear.Count);
                    sortClass.ShowDataHandlerMenu(sortedByYear);
                    break;

                case 5:
                    List<Machine> sortedByLubricantOils = sortClass.SortByLubricantOils();
                    Console.WriteLine(sortedByLubricantOils.Count);
                    sortClass.ShowDataHandlerMenu(sortedByLubricantOils);
                    break;

                case 6:
                    List<Machine> sortedByGreases = sortClass.SortByGreases();
                    Console.WriteLine(sortedByGreases.Count);
                    sortClass.ShowDataHandlerMenu(sortedByGreases);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

}

