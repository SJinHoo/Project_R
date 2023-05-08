using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Project_R
{
    public class Game
    {
        private bool running = true;
        private Scene scene;
        private MainMenuScene mainMenu;
        private Inventory inventory;
        private BattleScene battle;
        private MapScene map;
        private TutorialScene tutorial;
        
        public void Run()
        {   
            //초기화
            Init();

            while (running)
            {
                Render();
                Update();
            }

            Release();
        }
        
        //초기화
        private void Init()
        {
            mainMenu = new MainMenuScene(this);
            scene = mainMenu;

        }

        private void Render()
        {
            Console.Clear();
            scene.Render();
            
        }

        public void Input()
        {

        }

        public void Update()
        {
            scene.Update();
        }

        public void Release()
        {

        }
        public void MainMenu()
        {
            scene = mainMenu;
        }
        public void Inventory()
        {
            scene = inventory;
        }
        public void Tutorial()
        {
            scene = tutorial;
        }

        public void GameStart()
        {
            scene = tutorial;
        }
        public void GameOver(string text = "")
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("  ***    *   *   * *****       ***  *   * ***** ****  ");
            sb.AppendLine(" *      * *  ** ** *          *   * *   * *     *   * ");
            sb.AppendLine(" * *** ***** * * * *****      *   * *   * ***** ****  ");
            sb.AppendLine(" *   * *   * *   * *          *   *  * *  *     *  *  ");
            sb.AppendLine("  ***  *   * *   * *****       ***    *   ***** *   * ");
            sb.AppendLine();

            sb.AppendLine();
            sb.Append(text);

            Console.WriteLine(sb.ToString());

            running = false;
        }
    }

   
}
