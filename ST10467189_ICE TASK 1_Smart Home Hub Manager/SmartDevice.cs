namespace ST10467189_ICE_TASK_1_Smart_Home_Hub_Manager;

public class SmartDevice
{
    public string DeviceName { get; set; } = string.Empty;
    public string Room { get; set; } = string.Empty;

    public virtual void GetDeviceStatus()
    {
        Console.WriteLine($"Device : {DeviceName}");
        Console.WriteLine($"Room   : {Room}");
    }
}
