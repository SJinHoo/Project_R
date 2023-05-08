using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_R
{
    public class BattleScene : Scene
    {
        private Monster monster;
        public BattleScene(Game game) : base(game) { }

        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine($"{monster.name}    {monster.curHp,3}/{monster.maxHp,3}");
            Console.WriteLine();
            Console.WriteLine(monster.image);
            Console.WriteLine();
            Console.WriteLine(Data.player.image);
            Console.WriteLine();
            Console.WriteLine($"플레이어    {Data.player.CurHp,3}/{Data.player.MaxHp}");
            Console.WriteLine();
        }

        public override void Update()
        {
            
        }
    }
}
