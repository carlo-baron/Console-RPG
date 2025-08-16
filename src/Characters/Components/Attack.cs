namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;

public class BasicAttack : IAttacker{
    public int Damage { get; set; }
    public BasicAttack(int damage = 10){
        Damage = damage; 
    }

    public void Attack(IDamageable victim){
        Console.WriteLine($"Did a basic attack with {Damage} damage");
        victim.TakeDamage(Damage);
    }
}

public class ChargedAttack : IAttacker{
    public void Attack(IDamageable victim){
        Console.WriteLine("Did a charged attack");
    }
}

