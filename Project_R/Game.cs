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
            Console.CursorVisible = false;

            Data.Init();
            mainMenu = new MainMenuScene(this);
            map = new MapScene(this);
            inventory = new Inventory(this);
            battle = new BattleScene(this);
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
        public void Map()
        {
            scene = map;
        }

        public void Battle(Monster monster)
        {
            scene = battle;
            battle.StartBattle(monster);
        }
        public void GameStart()
        {
            scene = map;
            map.GenerateMap();
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
