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

        player.Attack(enemy);

    }
}
