namespace Getting_Real
{
    public class Machine
    {
        public string Interval { get; set; }

        public string WeekMonthYear { get; set; }

        public string FunctionLocation { get; set; }

        public string MachineName { get; set; }

        public string Coordinates { get; set; }

        public string LubricationPoint { get; set; }

        public string LubricationOilType { get; set; }

        public string GreaseOilType { get; set; }

        public string VolumeLiter { get; set; }

        public string VolumeGrams { get; set; }

        public Machine(string interval, string weekMonthYear, string functionLocation, string machineName, string coordinates, string lubricationPoint, string lubricationOilType, string greaseOilType, string volumeLiter, string volumeGrams)
        {
            Interval = interval;
            WeekMonthYear = weekMonthYear;
            FunctionLocation = functionLocation;
            MachineName = machineName;
            Coordinates = coordinates;
            LubricationPoint = lubricationPoint;
            LubricationOilType = lubricationOilType;
            GreaseOilType = greaseOilType;
            VolumeLiter = volumeLiter;
            VolumeGrams = volumeGrams;
        }

        public override string ToString()
        {
            return "Interval: " + Interval + "\nWeekMonthYear: " + WeekMonthYear + "\nFunction Location: " + FunctionLocation + "\nMachine Name: " + MachineName + "\nCoordinates: " + Coordinates
                + "\nLubrication Point: " + LubricationPoint + "\nLubrication Oil Type: " + LubricationOilType + "\nGrease Oil Type: " + GreaseOilType + "\nVolume in Liter: " + VolumeLiter + "\nVolume in Grams: " + VolumeGrams + "\n";
        }
    }

    //        public override string ToString()
    //{
    //    var sb = new StringBuilder();
    //sb.AppendLine($"Interval: {Interval}");
    //    sb.AppendLine($"WeekMonthYear: {WeekMonthYear}");
    //    sb.AppendLine($"Function Location: {FunctionLocation}");
    //    sb.AppendLine($"Machine Name: {MachineName}");
    //    sb.AppendLine($"Coordinates: {Coordinates}");
    //    sb.AppendLine($"Lubrication Point: {LubricationPoint}");
    //    sb.AppendLine($"Lubrication Type: {LubricationType}");
    //    sb.AppendLine($"Volume: {Volume}");
    //    sb.AppendLine($"Machine-Id: {MachineId}");

    //    return sb.ToString();
}
}
