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
                    sortClass.SortByCoordinates();
                    break;

                case 2:
                    sortClass.SortByWeek();
                    break;

                case 3:
                    sortClass.SortByMonth();
                    break;

                case 4:
                    sortClass.SortByYear();
                    break;

                case 5:
                    sortClass.SortByLubricantOils();
                    break;

                case 6:
                    sortClass.SortByGreases();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

}

