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
        Attacker = attacker ?? new PunchAttack();
        Mover = mover ?? new Walk();
        Speaker = speaker ?? new Talk();
        Damageable = damageable ?? new Damageable();
        Name = name;
    }

    public void Attack(Character target){
        Attacker.Attack(target.Name, target.Damageable);
    }

    public void Move(){
        Mover.Move();
    }
    
    public void Speak(string dialogue){
        Speaker.Speak(dialogue);
    }

    public void TakeDamage(int damage){
        Damageable.TakeDamage(damage);
    }
}
