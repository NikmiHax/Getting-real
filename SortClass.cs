using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class SortClass
    {
        MachineRepository machineRepository = new MachineRepository();

        DataHandler handler = new DataHandler();

        List<Machine> machines = new List<Machine>();

        public SortClass()
        {
            machines = handler.readExcel();
        }

        public List<Machine> SortByCoordinates()
        {
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByCoordinates = machineRepository.SortByCoordinates();
            foreach (var machine in sortedByCoordinates)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByCoordinates.ToList();
        }

        public List<Machine> SortByMonth()
        {
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByMonth = machineRepository.SortByMonth();

            return sortedByMonth.ToList();
        }


        public List<Machine> SortByYear()
        {
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByYear = machineRepository.SortByYear();

            return sortedByYear.ToList();
        }

        public List<Machine> SortByWeek()
        {
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByWeek = machineRepository.SortByWeek();

            return sortedByWeek.ToList();
        }

        public List<Machine> SortByLubricantOils()
        {
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByLubricantOils = machineRepository.SortByLubricantOils();
            foreach (var machine in sortedByLubricantOils)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByLubricantOils.ToList();
        }

        public List<Machine> SortByGreases()
        {
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            List<Machine> sortedByGreases = machineRepository.SortByGreases();
            foreach (var machine in sortedByGreases)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByGreases.ToList();
        }

        public void ShowDataHandlerMenu(List<Machine> machines)
        {
            Console.WriteLine("LIST_MENU: " +
                              "\nGem liste tryk 1: " +
                              "\nTilbage til hovedmenu tryk 2: ");

            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);

            switch (input)
            {
                case 1:
                    handler.SaveList(machines);
                    break;

                case 2:
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Show();
                    break;
            }


        }
    }
}
