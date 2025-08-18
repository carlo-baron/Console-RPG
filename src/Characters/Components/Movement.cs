namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;
using RPG.Events;

public class Walk : IMover{
    public int Steps { get; set; }
    public event EventHandler<MoveEventsArgs>? OnMove;

    public Walk(int steps = 1){
        Steps = steps;
    }

    public void Move(){
        OnMove?.Invoke(this, new MoveEventsArgs(Steps));
    }
}
