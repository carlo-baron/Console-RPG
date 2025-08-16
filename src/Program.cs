namespace RPG;

using RPG.Characters; 
using RPG.Characters.Components;
using RPG.Characters.Factories;

public class Program{
    public static void Main(string[] args){
        Character player = CharacterFactory.CreatePlayer(); 
        player.Speak("Hello Brody");

        Character enemy1 = CharacterFactory.CreateEnemy();
        enemy1.Name = "Johnny";
        enemy1.Speak($"Here's {enemy1.Name}");

        player.Attack(enemy1.Damageable);
    }
}
