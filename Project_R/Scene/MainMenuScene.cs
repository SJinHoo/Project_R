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
            sb.AppendLine("########  ########   #######        ## ########  ######  ########               ########  \r\n##     ## ##     ## ##     ##       ## ##       ##    ##    ##                  ##     ## \r\n##     ## ##     ## ##     ##       ## ##       ##          ##                  ##     ## \r\n########  ########  ##     ##       ## ######   ##          ##       #######    ########  \r\n##        ##   ##   ##     ## ##    ## ##       ##          ##                  ##   ##   \r\n##        ##    ##  ##     ## ##    ## ##       ##    ##    ##                  ##    ##  \r\n##        ##     ##  #######   ######  ########  ######     ##                  ##     ## ");
            sb.AppendLine();
            sb.AppendLine("                                 Project - R                ");
            sb.AppendLine();
            sb.AppendLine("                               게임 시작 : ENTER             ");
            sb.AppendLine("                               게임 종료 : ESC               ");
           

            Console.WriteLine(sb.ToString());
        }

        public override void Update()
        {
            ConsoleKeyInfo Input = Console.ReadKey();

            switch (Input.Key)
            {
                case ConsoleKey.Enter:
                    game.Tutorial();
                    game.GameStart();
                    break;  
                case ConsoleKey.Escape:
                    game.GameOver(" 게임을 종료했습니다. ");
                    break;
                default:
                    Console.WriteLine(" 잘못된 입력입니다. ");
                    Thread.Sleep(1000);
                    break;
                    
            }
            



        }
    }
}
