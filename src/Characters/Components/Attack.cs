namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;
using RPG.Events;

public class PunchAttack : IAttacker{
    public int Damage { get; set; }
    public event EventHandler<AttackEventArgs>? OnAttack;

    public PunchAttack(int damage = 10){
        Damage = damage; 
    }

    public void Attack(string name, IDamageable target){
        OnAttack?.Invoke(this, new AttackEventArgs(name, Damage));
        target.TakeDamage(Damage);
    }
}
