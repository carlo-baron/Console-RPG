namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;
using RPG.Events;

public class Damageable : IDamageable{
    public event EventHandler<DamageEventArgs>? OnDamage;
    public event EventHandler? OnDeath;

    public int Health { get; set; }

    public Damageable(int health = 50){
        Health = health;
    }

    public void TakeDamage(int damage){
        Health -= damage;
        OnDamage?.Invoke(this, new DamageEventArgs(damage, Health));
        HealthCheck();
    }
    
    void HealthCheck(){
        if(Health <= 0){
            OnDeath?.Invoke(this, EventArgs.Empty);
        } 
    }
}
