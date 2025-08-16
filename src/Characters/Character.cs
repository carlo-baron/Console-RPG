namespace RPG.Characters; 

using RPG.Characters.Components;
using RPG.Characters.Interfaces;

public class Character{
    public IAttacker Attacker { get; set; }
    public IMover Mover { get; set; }
    public ISpeaker Speaker { get; set; } 
    public IDamageable Damageable { get; set; }
    public string Name { get; set; }

    public Character(IAttacker? attacker = null, 
                     IMover? mover = null, 
                     ISpeaker? speaker = null, 
                     IDamageable? damageable = null,
                     string name = "Character"
                     )
    {
        Attacker = attacker ?? new BasicAttack();
        Mover = mover ?? new Walk();
        Speaker = speaker ?? new Talk();
        Damageable = damageable ?? new Damage();
        Name = name;

        Console.WriteLine($"Character \"{Name}\" Loaded!");
    }

    public void Attack(IDamageable victim){
        Console.Write($"{Name}: ");
        Attacker.Attack(victim);
    }

    public void Move(){
        Console.Write($"{Name}: ");
        Mover.Move();
    }
    
    public void Speak(string dialogue){
        Console.Write($"{Name}: ");
        Speaker.Speak(dialogue);
    }

    public void TakeDamage(int damage){
        Console.Write($"{Name}: ");
        Damageable.TakeDamage(damage);
    }
}
