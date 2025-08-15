namespace RPG;

using RPG.Characters; 
using RPG.Characters.Components;
using RPG.Characters.Factories;

public class Program{
    public static void Main(string[] args){
        Character defaultCharacter = CharacterFactory.CreateDefaultCharacter(); 
        defaultCharacter.PerformSpeak("Hello Brody");
    }
}
