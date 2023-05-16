namespace Getting_Real;

public class MachineRepository
{
    private List<Machine> machines = new List<Machine>();

    //public void AddMachine(Machine machine) // Denne metode tilføjer en maskine til vores liste i domænelaget
    //{
    //    machines.Add(machine);
    //}

    public Machine GetMachine(int machineId) // Denne metode henter en maskine fra vores maskine liste i domænelaget
    {
        foreach (Machine machine in machines)
        {
            if (machine.MachineId == machineId)
            {
                return machine;
            }
        }
        return null;
    }

    //public void DeleteMachine(int machineId) // Denne metode sletter en maskine fra vores liste i domænelaget
    //{
    //    foreach (Machine machine in machines)
    //    {
    //        if (machine.MachineId == machineId)
    //        {
    //            machines.Remove(machine);
    //        }
    //    }
    //}

    
}