using System.ComponentModel.DataAnnotations.Schema;

namespace Getting_Real
{
    public class Program
    {
        static void Main(string[] args)
        {
            MachineRepository machineRepository = new MachineRepository();
            string inputStr
            int input;
            var machines = Show();

            List<Machine> Show()
            {
                Console.WriteLine("MENU:\n Vælg 1: \n Vælg 2:");
                string inputStr = Console.ReadLine();
                input = int.Parse(inputStr);

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

            // Process the list of machines
            foreach (var machine in machines)
            {
                // Display machine information
                Console.WriteLine($"Machine ID: {machine.MachineId}");
                Console.WriteLine($"Coordinates: {machine.Coordinates}");
                Console.WriteLine($"Week/Month/Year: {machine.WeekMonthYear}");
                Console.WriteLine($"Interval: {machine.Interval}");
                Console.WriteLine(); // Empty line for readability
            }

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
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