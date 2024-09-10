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
    public int ExperiencePoints { get; set; }
    public Weapon? Weapon { get; set; }
    public bool IsAlive => Hitpoints > 0;
    private static readonly Dice Dice = new Dice();
    public Monster(string name, MonsterClassEnum monsterClass, int hitpoints, int experiencePoints)
    {
        Name = name;
        Hitpoints = hitpoints;
        MonsterClass = monsterClass;
        Gold = CalculateGold(monsterClass);
        Weapon = null;
        ExperiencePoints = experiencePoints;
    }

    public Monster Clone()
    {
        return new Monster(Name, MonsterClass, Hitpoints, ExperiencePoints)
        {
            Weapon = this.Weapon,
            Gold = this.Gold
        };
    }

    public int Attack()
    {
        if (Weapon == null) return 1;
        return Dice.Roll(1, Weapon.Damage);
    }

    private int CalculateGold(MonsterClassEnum monsterClass)
    {
        return monsterClass switch
        {
            MonsterClassEnum.Orc => Dice.Roll(1, 50),
            MonsterClassEnum.Ogre => Dice.Roll(1, 100),
            MonsterClassEnum.Goblin => Dice.Roll(1, 20),
            MonsterClassEnum.Troll => Dice.Roll(1, 75),
            _=> Dice.Roll(1, 25)
        };
    }


    public enum MonsterClassEnum { Orc, Ogre, Goblin, Troll };

}
