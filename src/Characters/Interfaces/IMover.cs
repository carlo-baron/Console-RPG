namespace RPG.Characters.Interfaces;

using RPG.Events;

public interface IMover{
    event EventHandler<MoveEventsArgs> OnMove;
    public void Move();
}
