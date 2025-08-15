namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;

public class Damage : IDamageable{
    public void TakeDamage(int damage){
        Console.WriteLine($"The character took {damage} amount of damage");
    }
}
