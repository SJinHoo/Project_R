using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_R
{
    public class MapScene : Scene
    {
        public MapScene(Game game) : base(game) { }

        public override void Render()
        {
            
        }

        public override void Update()
        {
            ConsoleKeyInfo input;

            while (true)
            {
                input = Console.ReadKey();

                if (input.Key == ConsoleKey.Q ||
                    input.Key == ConsoleKey.I ||
                    input.Key == ConsoleKey.UpArrow ||
                    input.Key == ConsoleKey.DownArrow ||
                    input.Key == ConsoleKey.LeftArrow ||
                    input.Key == ConsoleKey.RightArrow)
                {
                    break;
                }
            }

            if (input.Key == ConsoleKey.Q)
            {
                game.MainMenu();
                return;
            }
            else if (input.Key == ConsoleKey.I)
            {
                game.Inventory();
                return;
            }

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    Data.player.TryMove(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    Data.player.TryMove(Direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    Data.player.TryMove(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    Data.player.TryMove(Direction.Right);
                    break;
            }

            Item item = Data.ItemInPos(Data.player.pos);
            if(item != null)
            {
                Data.player.GetItem(item);
                Data.items.Remove(item);
            }

            Monster monster = Data.MonsterInPos(Data.player.pos);
            if (monster != null)
            {
                game.Battle(monster);
                return;
            }

            // 몬스터 이동
            foreach (Monster m in Data.monsters)
            {
                m.MoveAction();
                if (m.pos.x == Data.player.pos.x &&
                    m.pos.y == Data.player.pos.y)
                {
                    game.Battle(m);
                    return;
                }
            }

            //
        }
    }
}
