using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_R
{
    public class MainMenuScene : Scene
    {
        public MainMenuScene(Game game) : base(game)
        {

        }

        public override void Render()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(" 1. 게임 시작 ");
            sb.AppendLine(" 2. 게임 종료 ");
            sb.Append(" ");

            Console.WriteLine(sb.ToString());
        }

        public override void Update()
        {
            string input = Console.ReadLine();

            int index;
            if(! int .TryParse(input, out index))
            {
                Console.WriteLine("잘 못된 입력입니다.");
                Thread.Sleep(2000);
                return;
            }

            switch (index)
            {
                case 1:
                    
            }
        }
    }
}
