namespace ST1067189_ICE_TASK_2_AEGIS_AI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║     AEGIS STARSHIP COMPUTER v4.1     ║");
        Console.WriteLine("╚══════════════════════════════════════╝\n");

        Console.Write("Enter your rank and name (e.g. Captain Miller): ");
        var userName = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter your command (e.g. Initiate Warp Drive): ");
        var commandText = Console.ReadLine() ?? string.Empty;

        string logCode =
            userName.Trim().Replace(" ", "").ToUpper()
            + "-" +
            commandText.Trim().Replace(" ", "").ToUpper();

        Console.Write("Enter Alert Urgency (1 to 10) or leave blank for Standard Mode: ");
        var urgencyInput = Console.ReadLine();

        int? alertPitch;

        if (string.IsNullOrWhiteSpace(urgencyInput))
            alertPitch = null;
        else
            alertPitch = int.Parse(urgencyInput);

        var command = new VocalResponse
        {
            AuthorizedUser = userName,
            InputText = commandText,
            AlertPitch = alertPitch
        };

        Console.WriteLine("\n──────────────────────────────────────");
        Console.WriteLine($"LOG CODE       : {logCode}");
        Console.WriteLine($"AUTHORIZED USER: {command.AuthorizedUser}");
        Console.WriteLine("──────────────────────────────────────");

        command.ExecuteCommand();

        Console.WriteLine("──────────────────────────────────────");
        Console.WriteLine("Command logged to ship database.\n");
    }
}
