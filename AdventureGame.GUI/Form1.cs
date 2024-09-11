using System.Threading;
using AdventureGame.ClassLibrary;
using AdventureGame.GUI.Properties;

namespace AdventureGame.GUI;


public partial class Form1 : Form
{
    private GameController GameController;
    private CombatLog CombatLog;

    public Form1()
    {
        InitializeComponent();
        CombatLog = new CombatLog(TxtBoxCombatLog);
        GameController = new GameController();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        UpdateUI();
        CombatLog.AppendText("Welcome to the Adventure Game!\n", Color.Black, true);
    }


    public void UpdateUI()
    {
        UpdatePlayerStats();
        UpdateMonsterStats();
        UpdateMonsterImage(GameController.CurrentMonster);
        ShowPlayerImage(GameController.Player);
    }

    private void UpdatePlayerStats()
    {
        LblPlayerStats.Text = $"HP: {GameController.Player.Hitpoints}\nLevel: {GameController.Player.Level}\nGold: {GameController.Player.Gold}" +
                              $"\nExperience: {GameController.Player.ExperiencePoints}\nWeapon: {GameController.Player.Weapon.Name}";

    }
    private void UpdateMonsterStats()
    {
        LblMonsterStats.Text = $"Name: {GameController.CurrentMonster.Name}\nHP: {GameController.CurrentMonster.Hitpoints}";
    }

    private void BtnAttack_Click(object sender, EventArgs e)
    {
        PerformPlayerAttack();

        if (!GameController.CurrentMonster.IsAlive)
        {
            HandleMonsterDefeat();
        }
        else
        {
            PerformMonsterCounterAttack();
        }

        UpdateUI();
    }

    private void BtnRest_Click(object sender, EventArgs e)
    {
        GameController.PlayerRest();
        UpdateUI();
        CombatLog.AppendText("You are fully recovered", Color.Green, true);
    }

    private void BtnQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    public void ShowPlayerImage(Character player)
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string imagePath = Path.Combine(basePath, "Resources", "Characters");

        imagePath = player.CharacterClass switch
        {
            Character.CharacterClassEnum.Warrior => Path.Combine(imagePath, "warrior_1.jpg"),
            Character.CharacterClassEnum.Wizard => Path.Combine(imagePath, "wizard_1.jpg"),
            Character.CharacterClassEnum.Thief => Path.Combine(imagePath, "thief_1.jpg"),
            _ => Path.Combine(imagePath, "warrior_1.jpg")
        };

        if (File.Exists(imagePath))
        {
            pictureBox2.Image = Image.FromFile(imagePath);
        }
        else
        {
            MessageBox.Show("No image found: " + imagePath);
        }
    }
    public void UpdateMonsterImage(Monster monster)
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string imagePath = Path.Combine(basePath, "Resources", "Monsters");

        imagePath = monster.MonsterClass switch
        {
            Monster.MonsterClassEnum.Orc => Path.Combine(imagePath, "orc_1.jpg"),
            Monster.MonsterClassEnum.Ogre => Path.Combine(imagePath, "ogre_1.jpg"),
            Monster.MonsterClassEnum.Goblin => Path.Combine(imagePath, "goblin_1.jpg"),
            Monster.MonsterClassEnum.Troll => Path.Combine(imagePath, "orc_1.jpg"),
            _ => Path.Combine(imagePath, "ogre_1.jpg")
        };

        if (File.Exists(imagePath))
        {
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        else
        {
            MessageBox.Show("No image found: " + imagePath);
        }
    }

    private void PerformPlayerAttack()
    {
        int playerDamage = GameController.PlayerAttack();
        CombatLog.AppendText($"Attacked for {playerDamage} damage!\n", Color.Green);
    }

    private void HandleMonsterDefeat()
    {
        CombatLog.AppendText($"{GameController.CurrentMonster.Name} is defeated!\n", Color.Red, true);

        GameController.UpdateGoldAndExp();

        GameController.CurrentMonster = GameController.GetRandomMonster();
        CombatLog.AppendText("A new monsnter appears!\n", Color.DarkCyan, true);
    }

    private void PerformMonsterCounterAttack()
    {
        int monsterDamage = GameController.MonsterAttack();
        CombatLog.AppendText($"You took {monsterDamage} damage!\n", Color.Red);

        if (!GameController.Player.IsAlive)
        {
            HandlePlayerDefeat();
        }
    }

    private void HandlePlayerDefeat()
    {
        MessageBox.Show("You have been defeated! Game Over.");
        Application.Exit();
    }



}
