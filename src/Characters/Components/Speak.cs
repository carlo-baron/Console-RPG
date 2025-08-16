namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;

public class Talk : ISpeaker{
    public void Speak(string dialogue){
        Console.WriteLine($"\"{dialogue}\"");
    }
}

public class Whisper : ISpeaker{
    public void Speak(string dialogue){
        Console.WriteLine($"The character whispered: \"{dialogue}\"");
    }
}
