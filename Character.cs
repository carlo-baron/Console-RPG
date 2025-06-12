public class Character{
    IAttacker attacker;
    IMover mover;
    ISpeaker speaker;
    public Character(IAttacker attacker, IMover mover, ISpeaker speaker){
        this.attacker = attacker;
        this.mover = mover; 
        this.speaker = speaker;
        Console.WriteLine("Character, Loaded");
    }

    public void PerformAttack(){
        attacker.Attack();
    }

    public void PerformMove(){
        mover.Move();
    }
    
    public void PerformSpeak(){
        speaker.Speak();
    }
}
