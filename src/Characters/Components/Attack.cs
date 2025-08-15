namespace RPG.Characters.Components;

using RPG.Characters.Interfaces;

public class BasicAttack : IAttacker{
    public int Damage { get; set; }
    public BasicAttack(int damage = 10){
       Damage = damage; 
    }

    public void Attack(){
        Console.WriteLine($"The character did a basic attack with {Damage} damage");
    }
}

public class ChargedAttack : IAttacker{
    public void Attack(){
        Console.WriteLine("The character did a charged attack");
    }
}

