namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;
using RPG.Events;

public class Damage : IDamageable{
    public event EventHandler<DamageEventArgs>? OnDamage;

    public int Health { get; set; }

    public Damage(int health = 50){
        Health = health;
    }

    public void TakeDamage(int damage){
        Health -= damage;
        OnDamage?.Invoke(this, new DamageEventArgs(damage, Health));
    }
}
