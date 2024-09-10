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
        string expectedName = "Elrond";
        Character.CharacterClassEnum expectedClass = Character.CharacterClassEnum.Warrior;

        //Act
        Character character = new Character(expectedName, expectedClass);

        //Assert
        Assert.That(character.Name, Is.EqualTo(expectedName), "Burde være det samme..");
    }

    [Test]
    public void MonsterConstructorTest_ValuesAreSavedCorrectly()
    {
        //Arrange
        string expectedName = "Adar";
        Monster.MonsterClassEnum expectedClass = Monster.MonsterClassEnum.Orc;

        //Act
        Monster monster = new Monster(expectedName, expectedClass);

        //Assert
        Assert.That(monster.Name, Is.EqualTo(expectedName), "Burde være det samme..");

    }

    [Test]

    public void CharacterConstructorTest_DefaultValuesAreCorrect()
    {
        //Arrange
        Character character = new Character("Warr1", Character.CharacterClassEnum.Warrior);

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
        Monster monster = new Monster("Warr1", Monster.MonsterClassEnum.Ogre);

        //Assert
        Assert.That(monster.Hitpoints, Is.EqualTo(100), "Hitpoints er ikke ens");
        Assert.That(monster.Gold, Is.InRange(1, 25), "Gold er ikke ¨mellem 1-25");
        Assert.That(monster.IsAlive, Is.True, "Character er ikke i live");

    }

    [Test]

    public void CharacterLevelUpTest()
    {
        //Arrange
        Character character = new Character("Warr2", Character.CharacterClassEnum.Thief);

        //Act
        character.ExperiencePoints = 3000;
        character.LevelUp();

        //Assert
        Assert.That(character.Level, Is.EqualTo(3), "Character ikke er steget i lvl");

    }

    [Test]

    public void CharacterBaseAttackTest()
    {
        //Arrange
        Character character = new Character("Warr2", Character.CharacterClassEnum.Thief);
        Monster monster = new Monster("Warr1", Monster.MonsterClassEnum.Ogre);

        //Act
        monster.Hitpoints -= character.Attack();

        //Assert
        Assert.That(monster.Hitpoints, Is.EqualTo(99), "Attack did not do 1 damage");
    }

    [Test]

    public void CharacterWeaponAttackTest()
    {
        //Arrange
        Character character = new Character("Warr2", Character.CharacterClassEnum.Thief);
        Monster monster = new Monster("Warr1", Monster.MonsterClassEnum.Ogre);

        //Act
        character.Weapon = new Weapon("Axe", 20);
        monster.Hitpoints -= character.Attack();

        //Assert
        Assert.That(monster.Hitpoints, Is.InRange(80, 99), "Attack did not do between 1-20 damage");
    }

    [Test]

    public void MonsterPrototypeCreationTest()
    {
        //Arrange
        ;
    }

}