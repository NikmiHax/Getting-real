using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class Controller
    {
        public List<Machine> Machines { get; set; }


        public Controller()
        {
            Machines = new List<Machine>();
        }

        //public void AddToList(Machine machine)
        //{
        //    Machines.Add(machine);
        //}

        //public void Remove(int machineId)
        //{
        //    foreach (Machine machine in Machines)
        //    {
        //        if (machine.MachineId == machineId)
        //        {
        //            Machines.Remove(machine);
        //        }
        //    }
        //}

        //public void Sort()
        //{
        //    machines.Sort();
        //}

        //public void Reverse()
        //{
        //    machines.Reverse();
        //}
    }
}
