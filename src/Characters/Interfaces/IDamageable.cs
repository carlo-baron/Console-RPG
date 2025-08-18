namespace RPG.Characters.Interfaces;

using RPG.Events;

public interface IDamageable {
    event EventHandler<DamageEventArgs> OnDamage;
    public void TakeDamage(int damage);
}
