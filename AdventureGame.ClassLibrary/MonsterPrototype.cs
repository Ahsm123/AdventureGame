using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.ClassLibrary
{
    class MonsterPrototype
    {
        public static Monster OrcPrototype = new Monster("PrototypeOrc", Monster.MonsterClassEnum.Orc) {Hitpoints = 120};
        public static Monster OgrePrototype = new Monster("PrototypeOgre", Monster.MonsterClassEnum.Ogre) { Hitpoints = 150 };
        public static Monster GoblinPrototype = new Monster("PrototypeGoblin", Monster.MonsterClassEnum.Goblin) { Hitpoints = 80 };
        public static Monster TrollPrototype = new Monster("PrototypeTroll", Monster.MonsterClassEnum.Troll) { Hitpoints = 100 };

    }
}
