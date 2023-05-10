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

    public List<Machine> Show()
        {
        

        Console.WriteLine("MENU:\n Vælg 1: \n Vælg 2:");
            string inputStr = Console.ReadLine();
            input = int.Parse(inputStr); // det ser got ud, er næsten tilbage! Hilsen Henrik


            //    string input = Console.ReadLine();
            //    int inputoutput;
            //    var result = int32.TryParse(input, out inputoutput);

            // int input = int.Parse(Console.Readline());

            switch (input)
            {

            case 1:
                    return machineRepository.SortByCoordinates();
            case 2:
                    return machineRepository.SortByWeek();
            case 3:
                    return machineRepository.SortByMonth();
            case 4:
                    return machineRepository.SortByYear();
            default:
                Console.WriteLine("Ugyldigt valg");
                    return new List<Machine>();

            }
        }

    }
}
