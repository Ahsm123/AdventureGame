namespace AdventureGame.ClassLibrary;

public class Character
{
    public string Name { get; set; }
    public int Hitpoints { get; set; }
    public CharacterClassEnum CharacterClass { get; set; }
    public int Level { get; set; }
    public Weapon? Weapon { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }

    public readonly bool IsAlive;

    private static readonly Dice Dice = new Dice();

    public Character(string name, CharacterClassEnum characterClass)
    {
        Name = name;
        Hitpoints = 100;
        CharacterClass = characterClass;
        Level = 0;
        Weapon = null;
        Gold = 0;
        ExperiencePoints = 0;
        IsAlive = GetIsAlive();

    }
    public int Attack()
    {
        if (Weapon == null) return 1;

        return Dice.Roll(1, Weapon.Damage);
    }

    public void LevelUp()
    {
        if (!IsAlive)
        {
            return;
        }
        while(ExperiencePoints >= 999)
        {
            Level++;
            ExperiencePoints -= 999;
        }
    }
    public bool GetIsAlive()
    {
        if (Hitpoints > 0) return true;
        return false;
    }


    public enum CharacterClassEnum { Warrior, Wizard, Thief };

}
