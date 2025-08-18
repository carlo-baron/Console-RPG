namespace RPG.Events;

public class MoveEventsArgs : EventArgs{
    public int Steps { get; }

    public MoveEventsArgs(int steps){
        Steps = steps;
    }
}
