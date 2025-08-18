namespace RPG.Characters.Interfaces;

using RPG.Events;

public interface IDamageable {
    event EventHandler<DamageEventArgs> OnDamage;
    event EventHandler OnDeath;
    public void TakeDamage(int damage);
}
