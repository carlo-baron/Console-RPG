namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;

public class Walk : IMover{
    public int Steps { get; set; }

    public Walk(int steps = 1){
        Steps = steps;
    }

    public void Move(){
        Console.WriteLine($"The character walked {Steps} steps");
    }
}
