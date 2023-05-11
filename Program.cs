using System.ComponentModel.DataAnnotations.Schema;

namespace Getting_Real
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();



            //List<Machine> sortedMachines = machineRepository.SortByCoordinates();

            //sortedMachines = machineRepository.SortByCoordinates();

            //foreach (var machine in sortedMachines)
            //{
            //    Console.WriteLine(machine.Coordinates.ToString());
            //}


            menu.Show();


        }
    }
}


