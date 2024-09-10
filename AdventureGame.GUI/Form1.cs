using System.Threading;
using AdventureGame.ClassLibrary;
using AdventureGame.GUI.Properties;

namespace AdventureGame.GUI;


public partial class Form1 : Form
{
    private Character player = null!;
    private Monster currentMonster = null!;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        InitializeGame();
    }

    // Method to initialize the player and the first monster
    private void InitializeGame()
    {
        player = new Character("Player1", Character.CharacterClassEnum.Warrior);
        player.Weapon = new Weapon("Gods Hand", 40);

        // Create the first monster using the MonsterPrototype class
        currentMonster = MonsterPrototype.GetOrc(); // Start with an Orc

        // Update the UI with the player's stats and monster's stats
        UpdatePlayerStats();
        UpdateMonsterStats();
        UpdateMonsterImage(currentMonster);

        // Initialize the combat log (optional message at the start of the game)
        TxtBoxCombatLog.AppendText("Welcome to the Adventure Game! A wild Orc appears!\n");
    }

    private void UpdatePlayerStats()
    {
        LblPlayerStats.Text = $"HP: {player.Hitpoints}\nLevel: {player.Level}\nGold: {player.Gold}" +
                              $"\nExperience: {player.ExperiencePoints}\nWeapon: {player.Weapon.Name}";

    }
    private void UpdateMonsterStats()
    {
        LblMonsterStats.Text = $"Name: {currentMonster.Name}\nHP: {currentMonster.Hitpoints}";
    }

    private void BtnAttack_Click(object sender, EventArgs e)
    {
        int playerDamage = player.Attack();
        currentMonster.Hitpoints -= playerDamage;

        AppendTextToCombatLog($"You attack the {currentMonster.Name} for {playerDamage} damage!\n", Color.Green);

        if (!currentMonster.IsAlive)
        {
            AppendTextToCombatLog($"{currentMonster.Name} is defeated!\n", Color.Red, true);

            player.Gold += currentMonster.Gold;
            player.GainExperience(currentMonster.ExperiencePoints);

            UpdatePlayerStats();

            // Spawn a new monster using the cloned prototype
            currentMonster = GetRandomMonster();  // This will create a fresh clone
            UpdateMonsterStats();
            UpdateMonsterImage(currentMonster);

            AppendTextToCombatLog("A new Orc appears!\n", Color.DarkCyan, true);
        }
        else
        {
            int monsterDamage = currentMonster.Attack();
            player.Hitpoints -= monsterDamage;

            AppendTextToCombatLog($"{currentMonster.Name} attacks back for {monsterDamage} damage!\n", Color.Red);

            if (!player.IsAlive)
            {
                MessageBox.Show("You have been defeated! Game Over.");
                Application.Exit();
            }

            UpdatePlayerStats();
            UpdateMonsterStats();


        }
    }

    private void BtnRest_Click(object sender, EventArgs e)
    {
        player.Hitpoints = player.MaxHitpoints;  // Fully heal the player
        UpdatePlayerStats();
        TxtBoxCombatLog.AppendText("You rest and recover all your health.\n");
    }

    private void BtnQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();  // Close the game
    }

    private Monster GetRandomMonster()
    {
        // Create an instance of the Random class
        Random rnd = new Random();

        // Get a random number between 0 and 3 (for 4 possible monsters)
        int monsterIndex = rnd.Next(0, 4);

        // Return a random monster based on the index
        switch (monsterIndex)
        {
            case 0:
                return MonsterPrototype.GetOrc();
            case 1:
                return MonsterPrototype.GetOgre();
            case 2:
                return MonsterPrototype.GetGoblin();
            case 3:
                return MonsterPrototype.GetTroll();
            default:
                return MonsterPrototype.GetOrc();  // Fallback in case of error
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        PictureBox pictureBox = new PictureBox();
    }

    public void UpdateMonsterImage(Monster monster)
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string imagePath = Path.Combine(basePath, "Resources", "Monsters");

        switch (monster.MonsterClass)
        {
            case Monster.MonsterClassEnum.Orc:
                imagePath = Path.Combine(imagePath, "orc_1.jpg");
                break;
            case Monster.MonsterClassEnum.Ogre:
                imagePath = Path.Combine(imagePath, "ogre_1.jpg");
                break;
            case Monster.MonsterClassEnum.Goblin:
                imagePath = Path.Combine(imagePath, "goblin_1.jpg");
                break;
            case Monster.MonsterClassEnum.Troll:
                imagePath = Path.Combine(imagePath, "orc_1.jpg");
                break;
            default:
                imagePath = Path.Combine(imagePath, "orc_1.jpg");
                break;
        }

        if (File.Exists(imagePath))
        {
            pictureBox1.Image = Image.FromFile(imagePath);
        }
        else
        {
            MessageBox.Show("No image found" + imagePath);
        }
    }

    private void AppendTextToCombatLog(string text, Color color, bool bold = false)
    {
        TxtBoxCombatLog.SelectionStart = TxtBoxCombatLog.TextLength;
        TxtBoxCombatLog.SelectionLength = 0;

        TxtBoxCombatLog.SelectionColor = color;
        if (bold)
        {
            TxtBoxCombatLog.SelectionFont = new Font(TxtBoxCombatLog.Font, FontStyle.Bold);
        }
        TxtBoxCombatLog.AppendText(text);
        TxtBoxCombatLog.SelectionColor = TxtBoxCombatLog.ForeColor;
        TxtBoxCombatLog.ScrollToCaret();
    }

    private void TxtBoxCombatLog_TextChanged(object sender, EventArgs e)
    {

    }
}
