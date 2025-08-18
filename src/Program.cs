namespace RPG;

using RPG.Characters; 
using RPG.Characters.Components;
using RPG.Characters.Factories;
using RPG.Systems;

public class Program{
    public static void Main(string[] args){
        DialogueHandler dialogueHandler = new DialogueHandler(); 

        Character player = CharacterFactory.CreatePlayer();; 
        dialogueHandler.Register(player);
        player.Move();
        player.Speak("Hello Brody");

        Character enemy = CharacterFactory.CreateEnemy();
        dialogueHandler.Register(enemy);
        enemy.Speak("Hello too");

        player.Attack(enemy);

        player.Speak("How are you not dead.");
        enemy.Speak("Don't know.");
        player.Speak("Well then take this.");
        player.Attack(enemy);
        player.Attack(enemy);

    }
}
