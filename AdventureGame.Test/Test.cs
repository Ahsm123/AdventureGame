using AdventureGame.ClassLibrary;

namespace AdventureGame.Test;

public class Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CharacterConstructorTest_ValuesAreSavedCorrectly()
    {
        //Arrange
        string expectedName = "Character";
        Character.CharacterClassEnum expectedClass = Character.CharacterClassEnum.Warrior;

        //Act
        Character character = new Character(expectedName, expectedClass);

        //Assert
        Assert.That(character.Name, Is.EqualTo(expectedName), "Names should be the same");
    }

    [Test]
    public void MonsterConstructorTest_ValuesAreSavedCorrectly()
    {
        //Arrange
        string expectedName = "Monster";
        Monster.MonsterClassEnum expectedClass = Monster.MonsterClassEnum.Orc;

        //Act
        Monster monster = new Monster(expectedName, expectedClass, 100, 100);

        //Assert
        Assert.That(monster.Name, Is.EqualTo(expectedName), "Names should be the same");
    }

    [Test]

    public void CharacterConstructorTest_DefaultValuesAreCorrect()
    {
        //Arrange
        Character character = new Character("Character", Character.CharacterClassEnum.Warrior);

        //Assert
        Assert.That(character.Hitpoints, Is.EqualTo(100), "Hitpoints er ikke ens");
        Assert.That(character.Level, Is.EqualTo(0), "Level er ikke 0");
        Assert.That(character.Gold, Is.EqualTo(0), "Gold er ikke 0");
        Assert.That(character.ExperiencePoints, Is.EqualTo(0), "Exp er ikke 0");
        Assert.That(character.IsAlive, Is.True, "Character er ikke i live");

    }

    [Test]

    public void MonsterConstructorTest_DefaultValuesAreCorrect()
    {
        //Arrange
        Monster monster = new Monster("Ogre", Monster.MonsterClassEnum.Ogre, 100, 125); 

        //Assert
        Assert.That(monster.Hitpoints, Is.EqualTo(100), "Hitpoints are not equal");
        Assert.That(monster.Gold, Is.InRange(1, 100), "Gold is not between 1-100"); //Ogre drops between 1-100 gold.
        Assert.That(monster.IsAlive, Is.True, "Character is not alive");

    }

    [Test]
    public void CharacterGainExperienceTest_AutoLevelsUpCorrectly()
    {
        // Arrange
        Character character = new Character("TestWarrior", Character.CharacterClassEnum.Warrior);
        int initialLevel = character.Level;
        int initialMaxHp = character.MaxHitpoints;
        int xpToLevelUp = 999;

        // Act
        character.GainExperience(xpToLevelUp);

        // Assert
        Assert.That(character.Level, Is.EqualTo(initialLevel + 1), "Character should have leveled up.");
        Assert.That(character.MaxHitpoints, Is.EqualTo(initialMaxHp + 10), "Character's max HP should increase by 10.");
        Assert.That(character.Hitpoints, Is.EqualTo(character.MaxHitpoints), "Character's HP should be fully restored on level up.");
    }


    [Test]
    public void CharacterGainExperienceTest_PartialXpGains()
    {
        // Arrange
        Character character = new Character("TestWarrior", Character.CharacterClassEnum.Warrior);
        int xpBeforeLevelUp = 500;

        // Act
        character.GainExperience(xpBeforeLevelUp);

        // Assert
        Assert.That(character.Level, Is.EqualTo(0), "Character should not level up with less than 999 XP.");
        Assert.That(character.ExperiencePoints, Is.EqualTo(xpBeforeLevelUp), "Experience points should match the amount gained.");
    }

    [Test]

    public void CharacterBaseAttackTest()
    {
        //Arrange
        Character character = new Character("Warr2", Character.CharacterClassEnum.Thief);
        Monster monster = new Monster("Warr1", Monster.MonsterClassEnum.Ogre, 100, 80);

        //Act
        monster.Hitpoints -= character.Attack();

        //Assert
        Assert.That(monster.Hitpoints, Is.InRange(95, 99), "Attack did not do dmg");
    }

    [Test]

    public void CharacterWeaponAttackTest()
    {
        //Arrange
        Character character = new Character("Warr2", Character.CharacterClassEnum.Thief);
        Monster monster = new Monster("Warr1", Monster.MonsterClassEnum.Ogre, 100, 80);

        //Act
        character.Weapon = new Weapon("Axe", 20);
        monster.Hitpoints -= character.Attack();

        //Assert
        Assert.That(monster.Hitpoints, Is.InRange(80, 99), "Attack did not do between 1-20 damage");
    }

    [Test]

    public void MonsterPrototypeCreationTest_ModifyingNewOrcDoesNotChangePrototype()
    {
        //Arrange
        Monster prototypeOrc = MonsterPrototype.GetOrc();

        //Act
        Monster newOrc = MonsterPrototype.GetOrc();
        newOrc.Hitpoints -= 50;

        //Assert
        Assert.That(newOrc.Name, Is.EqualTo(prototypeOrc.Name), "Names should be the same");
        Assert.That(newOrc.MonsterClass, Is.EqualTo(prototypeOrc.MonsterClass), "Classes should be the same");
        Assert.That(newOrc.Hitpoints, Is.EqualTo(70), "Should have taken 50 damage");
        Assert.That(prototypeOrc.Hitpoints, Is.EqualTo(120), "Should not have taking damange");
    }

    [Test]

    public void MonsterPrototypeWeaponTest()
    {
        //Arrange
        Monster prototypeGoblin = MonsterPrototype.GetGoblin();
        prototypeGoblin.Weapon = new Weapon("Axe", 20);

        //Act
        Monster clonedGoblin = prototypeGoblin.Clone();
        clonedGoblin.Weapon = new Weapon("Sword", 10);

        //Assert
        Assert.That(prototypeGoblin.Weapon.Name, Is.EqualTo("Axe"), "Should have an Axe");
        Assert.That(clonedGoblin.Weapon.Name, Is.EqualTo("Sword"), "Should have a Sword");
    }

    [Test]

    public void CharacterLevelUpTest_HpIncreaseOnLevelUp()
    {
        //Arrange
        Character character = new Character("Character", Character.CharacterClassEnum.Warrior);
        int initialMaxHp = character.MaxHitpoints;

        //Act
        character.GainExperience(1000);

        //Assert
        Assert.That(character.Level, Is.EqualTo(1), "Character should be level 1");
        Assert.That(character.MaxHitpoints, Is.EqualTo(initialMaxHp + 10), "Max hitpoints shouldve increased");
        Assert.That(character.Hitpoints, Is.EqualTo(character.MaxHitpoints), "Hitpoints should be restored on level up");
    }

}