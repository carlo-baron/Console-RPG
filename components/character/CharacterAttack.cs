public class BasicAttack : IAttacker{
    public void Attack(){
        Console.WriteLine("The character did a basic attack");
    }
}

public class ChargedAttack : IAttacker{
    public void Attack(){
        Console.WriteLine("The character did a charged attack");
    }
}

