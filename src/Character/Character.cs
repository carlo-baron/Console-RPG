namespace RPG.Characters; 

using RPG.Characters.Components;
using RPG.Characters.Interfaces;

public class Character{
    public IAttacker Attacker { get; set; }
    public IMover Mover { get; set; }
    public ISpeaker Speaker { get; set; } 
    public IDamageable Damageable { get; set; }

    public Character(IAttacker? attacker = null, 
                     IMover? mover = null, 
                     ISpeaker? speaker = null, 
                     IDamageable? damageable = null)
    {
        Console.WriteLine("Character, Loaded");
        Attacker = attacker ?? new BasicAttack();
        Mover = mover ?? new Walk();
        Speaker = speaker ?? new Talk();
        Damageable = damageable ?? new Damage();
    }

    public void PerformAttack(){
        Attacker.Attack();
    }

    public void PerformMove(){
        Mover.Move();
    }
    
    public void PerformSpeak(string dialogue){
        Speaker.Speak(dialogue);
    }

}
