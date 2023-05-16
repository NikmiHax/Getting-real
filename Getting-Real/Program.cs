
using System.Data;
using OfficeOpenXml;

namespace Getting_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MachineRepository machineRepository = new MachineRepository();

            //List<Machine> Machines = new List<Machine>();

            //Controller controller = new Controller();

            //Machine machine = new Machine(4, 1, "functionLocation1", "machine1", "291K", "LubricationPoint1", "Hard Lubricant", "3g", 1);

            //Machine machine2 = new Machine(4, 2, "functionLocation2", "machine2", "437F", "LubricationPoint2", "Greasy grease", "3l", 2);

            //Machine machine3 = new Machine(5, 2, "functionLocation3", "machine3", "294G", "LubricationPoint3", "Soft Lubricant", "77g", 3);

            //Console.WriteLine(machine.ToString());

            //controller.AddToList(machine);
            //controller.AddToList(machine2);
            //controller.AddToList(machine3);

            //foreach (var m in Machines) 
            //{
            //    Console.WriteLine(m.ToString());
            //}

            DataHandler handler = new DataHandler();

            handler.readExcel();

        }
    }
}