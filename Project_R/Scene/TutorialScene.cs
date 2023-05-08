using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_R
{
    public class TutorialScene : Scene
    {
        public TutorialScene(Game game) : base(game) { }

        public override void Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("8888888 8888888888 8 8888      88 8888888 8888888888     ,o888888o.     8 888888888o.    8 8888          .8.          8 8888         \r\n      8 8888       8 8888      88       8 8888        . 8888     `88.   8 8888    `88.   8 8888         .888.         8 8888         \r\n      8 8888       8 8888      88       8 8888       ,8 8888       `8b  8 8888     `88   8 8888        :88888.        8 8888         \r\n      8 8888       8 8888      88       8 8888       88 8888        `8b 8 8888     ,88   8 8888       . `88888.       8 8888         \r\n      8 8888       8 8888      88       8 8888       88 8888         88 8 8888.   ,88'   8 8888      .8. `88888.      8 8888         \r\n      8 8888       8 8888      88       8 8888       88 8888         88 8 888888888P'    8 8888     .8`8. `88888.     8 8888         \r\n      8 8888       8 8888      88       8 8888       88 8888        ,8P 8 8888`8b        8 8888    .8' `8. `88888.    8 8888         \r\n      8 8888       ` 8888     ,8P       8 8888       `8 8888       ,8P  8 8888 `8b.      8 8888   .8'   `8. `88888.   8 8888         \r\n      8 8888         8888   ,d8P        8 8888        ` 8888     ,88'   8 8888   `8b.    8 8888  .888888888. `88888.  8 8888         \r\n      8 8888          `Y88888P'         8 8888           `8888888P'     8 8888     `88.  8 8888 .8'       `8. `88888. 8 888888888888");
            Console.WriteLine(sb.ToString());
        }

        public override void Update()
        {
            Player player = new Player();
            player.ChooseName();
            Console.WriteLine("당신의 이름은 : {0} ",player.Name);
        }
    }

}
