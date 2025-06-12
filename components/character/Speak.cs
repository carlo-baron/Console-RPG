public class Talk : ISpeaker{
    public void Speak(){
        Console.WriteLine("The character talked");
    }
}

public class Whisper : ISpeaker{
    public void Speak(){
        Console.WriteLine("The character whispered");
    }
}
