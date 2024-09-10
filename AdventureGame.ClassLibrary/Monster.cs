using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.ClassLibrary;

public class Monster
{
    public string Name {  get; set; }
    public int Hitpoints { get; set; }
    public MonsterClassEnum MonsterClass { get; set; }
    public int Gold { get; set; }
    public Weapon? Weapon { get; set; }
    public readonly bool IsAlive;
    private static readonly Dice Dice = new Dice();
    public Monster(string name, MonsterClassEnum monsterClass)
    {
        Name = name;
        Hitpoints = 100;
        MonsterClass = monsterClass;
        Gold = Dice.Roll(1, 25);
        Weapon = null;
        IsAlive = GetIsAlive();
    }

    public int Attack(Dice dice)
    {
        if (Weapon == null) return 1;
        return Dice.Roll(1, Weapon.Damage);
    }

    public bool GetIsAlive()
    {
        if (Hitpoints > 0) return true;
        return false;
    }

    public enum MonsterClassEnum { Orc, Ogre, Goblin, Troll };

}
