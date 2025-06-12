public class Character{
    public IAttacker Attacker { get; set; }
    public IMover Mover { get; set; }
    public ISpeaker Speaker { get; set; } 
    public IDamageable Damageable { get; set; }

    public Character(){
        Console.WriteLine("Character, Loaded");
    }

    public void PerformAttack(){
        Attacker.Attack();
    }

    public void PerformMove(){
        Mover.Move();
    }
    
    public void PerformSpeak(){
        Speaker.Speak();
    }

}
