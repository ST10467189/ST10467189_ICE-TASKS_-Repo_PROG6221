namespace ST10467189_ICE_TASK_1_Smart_Home_Hub_Manager;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Smart Home Hub — Device Registration ===\n");

        Console.Write("Enter room name (e.g. Living Room): ");
        var room = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter device name (e.g. Motion Sensor): ");
        var deviceName = Console.ReadLine() ?? string.Empty;

        string networkID =
            room.Trim().Replace(" ", "").ToUpper()
            + "-"
            + deviceName.Trim().Replace(" ", "").ToUpper();

        Console.Write("Enter battery percentage " +
                      "(leave blank if hardwired into the wall): ");
        var batteryInput = Console.ReadLine();

        int? batteryLevel;
        if (string.IsNullOrWhiteSpace(batteryInput))
            batteryLevel = null;
        else
            batteryLevel = int.Parse(batteryInput);

        var sensor = new WirelessSensor
        {
            DeviceName = deviceName,
            Room = room,
            BatteryLevel = batteryLevel
        };

        Console.WriteLine("\n--- Device Status Report ---");
        sensor.GetDeviceStatus();
        Console.WriteLine($"Network ID : {networkID}");
    }
}
