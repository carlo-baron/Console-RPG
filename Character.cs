public class Character{
    private IAttacker attacker;
    private IMover mover;
    private ISpeaker speaker;
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

    public void SetAttackerBehavior(IAttacker attacker){
        this.attacker = attacker;
    }

    public void SetMoverBehavior(IMover mover){
        this.mover = mover; 
    }

    public void SetSpeakerBehavior(ISpeaker speaker){
        this.speaker = speaker;
    }
}
