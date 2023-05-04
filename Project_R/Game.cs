using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_R
{
    public class Game
    {
        public bool running = true;

        public void Run()
        {   
            //초기화
            Init();

            while (running)
            {
                Render();
                Input();
                Update();
            }

            Release();
        }
        
        //초기화
        public void Init()
        {

        }

        public void Render()
        {

        }

        public void Input()
        {

        }

        public void Update()
        {

        }

        public void Release()
        {

        }
    }

   
}
