namespace RPG.Events;

public class DamageEventArgs : EventArgs{
    public int Damage { get; }
    public int Health { get; }

    public DamageEventArgs(int damage, int health){
        Damage = damage;
        Health = health;
    }
}
