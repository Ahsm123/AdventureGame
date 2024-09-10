namespace AdventureGame.ClassLibrary;

public class Character
{
    public string Name { get; set; }
    public int MaxHitpoints { get; private set; }
    public int Hitpoints { get; set; }
    public CharacterClassEnum CharacterClass { get; set; }
    public int Level { get; set; }
    public Weapon? Weapon { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }

    public bool IsAlive => Hitpoints > 0;

    private static readonly Dice Dice = new Dice();

    public Character(string name, CharacterClassEnum characterClass)
    {
        Name = name;
        MaxHitpoints = 100;
        Hitpoints = MaxHitpoints;
        CharacterClass = characterClass;
        Level = 0;
        Weapon = null;
        Gold = 0;
        ExperiencePoints = 0;


    }
    public int Attack()
    {
        if (Weapon == null) return Dice.Roll(1, 5);

        return Dice.Roll(1, Weapon.Damage + 1);
    }

    public void GainExperience(int xp)
    {
        ExperiencePoints += xp;


        while (ExperiencePoints >= 999)
        {
            Level++;
            ExperiencePoints -= 999;


            MaxHitpoints += 10;
            Hitpoints = MaxHitpoints;
        }
    }

    public enum CharacterClassEnum { Warrior, Wizard, Thief };

}
