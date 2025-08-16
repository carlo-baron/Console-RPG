namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;

public class Damage : IDamageable{
    public int Health { get; set; }

    public Damage(int health = 50){
        Health = health;
    }

    public void TakeDamage(int damage){
        Health -= damage;
        Console.WriteLine($"Took {damage} damage! Reamaing HP: {Health}");
    }
}
