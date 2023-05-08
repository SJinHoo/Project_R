using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_R.Monster
{
    public abstract class Monster
    {
        public string name;
        public Position pos;


        public string image;
        public int curHp;
        public int maxHp;

        public abstract void MoveAction();
        public void TryMove(Direction dir)
        {
            Position prevPos = pos;
            switch (dir)
            {
                case Direction.Up:
                    pos.y--;
                    break;
                case Direction.Down:
                    pos.y++;
                    break;
                case Direction.Left:
                    pos.x--;
                    break;
                case Direction.Right:
                    pos.x++;
                    break;
            }

            
        }


    }
}
