namespace ST1067189_ICE_TASK_2_AEGIS_AI;

public class VocalResponse : ShipCommand
{
    public int? AlertPitch { get; set; }

    public override void ExecuteCommand()
    {
        if (AlertPitch == null)
        {
            synth.Rate = 0;
            Console.WriteLine("Mode: Standard Communication.");
            synth.Speak(InputText);
        }
        else
        {
            synth.Rate = AlertPitch.Value;
            Console.WriteLine($"Mode: Priority Alert (Pitch Level: {AlertPitch})");
            synth.Speak(InputText);
        }
    }
}
