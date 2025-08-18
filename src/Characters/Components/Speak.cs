namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;
using RPG.Events;

public class Talk : ISpeaker{
    public event EventHandler<SpeakEventArgs>? OnSpeak;

    public void Speak(string dialogue){
        OnSpeak?.Invoke(this, new SpeakEventArgs(dialogue));
    }
}
