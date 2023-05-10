using System.ComponentModel.DataAnnotations.Schema;

namespace Getting_Real
{
    public class Program
    {
        static void Main(string[] args)

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
}

//        {
//            DataHandler handler = new DataHandler();

//            MachineRepository machineRepository = new MachineRepository();

//            List<Machine> machines = new List<Machine>();

//            machines = handler.readExcel();

//            foreach (var machine in machines)
//            {
//                machineRepository.AddMachine(machine);
//            }

//            //List<Machine> weekMachines = machineRepository.SortByWeek();

//            //List<Machine> monthMachines = machineRepository.SortByMonth();

//            //List<Machine> yearMachines = machineRepository.SortByYear();

//            //Console.WriteLine(WeekMachines.Count.ToString());
//            //Console.WriteLine(MonthMachines.Count.ToString());
//            //Console.WriteLine(YearMachines.Count.ToString());

//            List<Machine> sortedMachines = machineRepository.SortByCoordinates();

//            sortedMachines = machineRepository.SortByCoordinates();

//            foreach (var machine in sortedMachines)
//            {
//                Console.WriteLine(machine.Coordinates.ToString());
//            }



//        }
//    }
//} 