namespace ST10467189_ICE_TASK_1_Smart_Home_Hub_Manager;

public class WirelessSensor : SmartDevice
{
    public int? BatteryLevel { get; set; }

    public override void GetDeviceStatus()
    {
        base.GetDeviceStatus();

        if (BatteryLevel == null)
            Console.WriteLine("Power Source: Hardwired (No Battery)");
        else
            Console.WriteLine($"Power Source: Battery at {BatteryLevel}%");
    }
}
