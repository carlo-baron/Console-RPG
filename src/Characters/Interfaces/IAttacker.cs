namespace RPG.Characters.Interfaces;

using RPG.Events;

public interface IAttacker{
    event EventHandler<AttackEventArgs> OnAttack;
    public void Attack(string name, IDamageable target);
}
