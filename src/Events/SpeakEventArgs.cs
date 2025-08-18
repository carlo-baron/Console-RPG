namespace RPG.Events;

public class SpeakEventArgs : EventArgs{
    public string Message { get; }

    public SpeakEventArgs(string message){
        Message = message;
    }
}
