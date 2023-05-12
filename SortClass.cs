using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    internal class SortClass
    {
        public void SortByCoordinates()
        {
            MachineRepository machineRepository = new MachineRepository();

            DataHandler handler = new DataHandler();

            List<Machine> machines = new List<Machine>();

            machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByCoordinates = machineRepository.SortByCoordinates();
            foreach (var machine in sortedByCoordinates)
            {
                Console.WriteLine(machine.ToString());
            }
        }

        public List<Machine> SortByMonth()
        {
            MachineRepository machineRepository = new MachineRepository();

            DataHandler handler = new DataHandler();

            List<Machine> machines = new List<Machine>();

            machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByMonth = machineRepository.SortByMonth();

            return sortedByMonth.ToList();
        }


        public List<Machine> SortByYear()
        {
            MachineRepository machineRepository = new MachineRepository();

            DataHandler handler = new DataHandler();

            List<Machine> machines = new List<Machine>();

            machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByYear = machineRepository.SortByYear();
            
            return sortedByYear.ToList();
        }

        public List<Machine> SortByWeek()
        {
            MachineRepository machineRepository = new MachineRepository();

            DataHandler handler = new DataHandler();

            List<Machine> machines = new List<Machine>();

            machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByWeek = machineRepository.SortByWeek();
            
            return sortedByWeek.ToList();
        }

        public void SortByLubricantOils()
        {
            MachineRepository machineRepository = new MachineRepository();

            DataHandler handler = new DataHandler();

            List<Machine> machines = new List<Machine>();

            machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByWeek = machineRepository.SortByLubricantOils();
            foreach (var machine in sortedByWeek)
            {
                Console.WriteLine(machine.ToString());
            }
        }

        public void SortByGreases()
        {
            MachineRepository machineRepository = new MachineRepository();

            DataHandler handler = new DataHandler();

            List<Machine> machines = new List<Machine>();

            machines = handler.readExcel();

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByWeek = machineRepository.SortByGreases();
            foreach (var machine in sortedByWeek)
            {
                Console.WriteLine(machine.ToString());
            }
        }
    }
}
