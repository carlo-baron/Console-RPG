namespace RPG.Characters.Factories;

using RPG.Characters;
using RPG.Characters.Components;

public static class CharacterFactory{
    public static Character CreatePlayer(){
        return new Character(name: "Player");
    }

    public static Character CreateEnemy(){
        return new Character(name: "Enemy", damageable: new Damage(health: 20));
    }
}
