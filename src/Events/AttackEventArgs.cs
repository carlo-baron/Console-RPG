namespace RPG.Events;

public class AttackEventArgs : EventArgs{
    public string Target { get; }
    public int Damage { get; }

    public AttackEventArgs(string target, int damage){
        Damage = damage;
        Target = target;
    }
}
