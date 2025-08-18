namespace RPG.Characters.Interfaces;

using RPG.Events;

public interface ISpeaker{
    event EventHandler<SpeakEventArgs> OnSpeak;
    public void Speak(string dialogue);
}
