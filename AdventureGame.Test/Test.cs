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
}