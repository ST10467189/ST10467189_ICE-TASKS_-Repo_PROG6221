using System.Speech.Synthesis;

namespace ST1067189_ICE_TASK_2_AEGIS_AI;

public class ShipCommand
{
    public string InputText { get; set; } = string.Empty;
    public string AuthorizedUser { get; set; } = string.Empty;

    protected SpeechSynthesizer synth = new SpeechSynthesizer();

    public virtual void ExecuteCommand()
    {
        Console.WriteLine("Processing command...");
        synth.Speak("Command received.");
    }
}
