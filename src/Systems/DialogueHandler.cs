namespace RPG.Systems;

using RPG.Characters;
using RPG.Events;

public class DialogueHandler{
    public void Register(Character character){
        character.Attacker.OnAttack += (sender, e) => OnAttack(sender, e, character.Name);
        character.Damageable.OnDamage += (sender, e) => OnDamage(sender, e, character.Name);
        character.Speaker.OnSpeak += (sender, e) => OnSpeak(sender, e, character.Name);
        character.Mover.OnMove += (sender, e) => OnMove(sender, e, character.Name);
    }

    private void OnDamage(object? sender, DamageEventArgs e, string name){
        Log(name, $"Damage Received: {e.Damage}, Remaining HP: {e.Health}");
    }

    private void OnSpeak(object? sender, SpeakEventArgs e, string name){
        Log(name, $"{e.Message}");
    }

    private void OnAttack(object? sender, AttackEventArgs e, string name){
        Log(name, $"Attacked {e.Target} with {e.Damage} damage.");
    }

    private void OnMove(object? sender, MoveEventsArgs e, string name){
        Log(name, $"Moved {e.Steps} step(s)");
    }

    private void Log(string name, string message){
        Console.WriteLine($"{name}: {message}");
    }
}
