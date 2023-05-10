using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    internal class SortedMachineList

    {      
            DataHandler handler = new DataHandler();

        MachineRepository machineRepository = new MachineRepository();

        List<Machine> machines = new List<Machine>();

        machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

    //List<Machine> weekMachines = machineRepository.SortByWeek();

    //List<Machine> monthMachines = machineRepository.SortByMonth();

    //List<Machine> yearMachines = machineRepository.SortByYear();

    //Console.WriteLine(WeekMachines.Count.ToString());
    //Console.WriteLine(MonthMachines.Count.ToString());
    //Console.WriteLine(YearMachines.Count.ToString());

    List<Machine> sortedMachines = machineRepository.SortByCoordinates();

    sortedMachines = machineRepository.SortByCoordinates();

            foreach (var machine in sortedMachines)
            {
                Console.WriteLine(machine.Coordinates.ToString());
            }



        }
    }
} 
    }
}
