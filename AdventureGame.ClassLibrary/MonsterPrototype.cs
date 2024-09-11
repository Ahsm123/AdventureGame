using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.ClassLibrary
{
    public class MonsterPrototype
    {
        public static Monster OrcPrototype = new Monster("PrototypeOrc", Monster.MonsterClassEnum.Orc, 120, 100, new Weapon("Axe", 500));
        public static Monster OgrePrototype = new Monster("PrototypeOgre", Monster.MonsterClassEnum.Ogre, 150, 125, new Weapon("Axe", 50));
        public static Monster GoblinPrototype = new Monster("PrototypeGoblin", Monster.MonsterClassEnum.Goblin, 80, 60, new Weapon("Axe", 100));
        public static Monster TrollPrototype = new Monster("PrototypeTroll", Monster.MonsterClassEnum.Troll, 100, 80, new Weapon("Axe", 80));

        public static Monster GetOrc() => OrcPrototype.Clone();
        public static Monster GetOgre() => OgrePrototype.Clone();
        public static Monster GetGoblin() => GoblinPrototype.Clone();
        public static Monster GetTroll() => TrollPrototype.Clone();
    }
}
