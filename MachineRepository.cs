namespace Getting_Real;

public class MachineRepository
{
    private List<Machine> machines = new List<Machine>();

    public MachineRepository()
    {
        machines = new List<Machine>();
    }

    public void AddMachine(Machine machine) // Denne metode tilføjer en maskine til vores liste i domænelaget
    {
        machines.Add(machine);
    }

    //public Machine GetMachine(int machineId) // Denne metode henter en maskine fra vores maskine liste i domænelaget
    //{
    //    foreach (Machine machine in machines)
    //    {
    //        if (machine.MachineId == machineId)
    //        {
    //            return machine;
    //        }
    //    }
    //    return null;
    //}

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

    public List<Machine> Sort()
    {
        return machines.OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "uge")
            {
                nextLubricationDate = DateTime.Now.AddDays(int.Parse(machine.Interval) * 7);
            }

            else if (machine.WeekMonthYear.ToLower() == "m")
            {
                nextLubricationDate = DateTime.Now.AddMonths(int.Parse(machine.Interval));
            }

            else if (machine.WeekMonthYear.ToLower() == "år")
            {
                nextLubricationDate = DateTime.Now.AddYears(int.Parse(machine.Interval));
            }

            else if (machine.WeekMonthYear.ToLower() == "timer")
            {
                nextLubricationDate = DateTime.Now.AddHours(int.Parse(machine.Interval));
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> SortByWeek()
    {
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "uge").OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "uge")
            {
                nextLubricationDate = DateTime.Now.AddDays(int.Parse(machine.Interval) * 7);
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> SortByMonth()
    {
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "m").OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "m")
            {
                nextLubricationDate = DateTime.Now.AddMonths(int.Parse(machine.Interval));
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> SortByYear()
    {
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "år").OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "år")
            {
                nextLubricationDate = DateTime.Now.AddYears(int.Parse(machine.Interval));
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> GetCoordinates()
    {
        foreach (var machine in machines)
        {
            machine.Coordinates = machine.Coordinates.Substring(0, 4) ;
        }
        return machines;
    }

    public List<Machine> SortByCoordinates()
    {
        return machines.OrderBy(machine => machine.Coordinates).ToList();
    }

    public List<Machine> SortByLubricantOils()
    {
        return machines.OrderBy(machine => machine.LubricationOilType).ToList();
    }

    public List<Machine> SortByGreases()
    {
        return machines.OrderBy(machine => machine.GreaseType).ToList();
    }
}



