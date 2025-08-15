namespace RPG;

using RPG.Characters; 
using RPG.Characters.Components;
using RPG.Characters.Factories;

public class Program{
    public static void Main(string[] args){
        //Character character = new Character(speaker: new Talk(), attacker: new BasicAttack(40));
        //character.PerformSpeak("Kamusta Kana Bhai");
        //character.PerformAttack();
        //character.PerformMove();
        Character defaultCharacter = CharacterFactory.CreateDefaultCharacter(); 
        defaultCharacter.PerformSpeak("Hello Brody");
    }
}
