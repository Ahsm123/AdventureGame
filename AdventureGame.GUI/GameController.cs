using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGame.ClassLibrary;

namespace AdventureGame.GUI;

public class GameController
{
    public Character Player { get; set; }
    public Monster CurrentMonster { get; set; }

    public static readonly Dice dice = new Dice();
    public GameController()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        Player = new Character("Anders", Character.CharacterClassEnum.Thief);
        Player.Weapon = new Weapon("Dick of Thomas", 200);
        CurrentMonster = MonsterPrototype.GetGoblin();        
    }

    public int PlayerAttack()
    {
        int playerDamage = Player.Attack();
        CurrentMonster.Hitpoints -= playerDamage;
        return playerDamage;
    }

    public bool IsMonsterDead()
    {
        return !CurrentMonster.IsAlive;
    }

    public void SpawnNewMonster()
    {
        CurrentMonster = GetRandomMonster();
    }

    public Monster GetRandomMonster()
    {
        int monsterIndex = dice.Roll(0, 4);

        return monsterIndex switch
        {
            0 => MonsterPrototype.GetGoblin(),
            1 => MonsterPrototype.GetTroll(),
            2 => MonsterPrototype.GetOrc(),
            3 => MonsterPrototype.GetOgre(),
            _ => MonsterPrototype.GetGoblin(),
        };
    }

    public int MonsterAttack()
    {
        int monsterDamage = CurrentMonster.Attack();
        Player.Hitpoints -= monsterDamage;
        return monsterDamage;
    }

    public void PlayerRest()
    {
        Player.Hitpoints = Player.MaxHitpoints;
    }

    public void UpdateGoldAndExp()
    {
        Player.GainExperience(CurrentMonster.ExperiencePoints);
        Player.Gold += CurrentMonster.Gold;
    }
}
