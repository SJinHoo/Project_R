using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_R
{
    public abstract class Monster
    {
        public string name;
        public char icon = 'M';
        public Position pos;


        public string image;
        public int curHp;
        public int maxHp;
        public int AP;
        public int DP;

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

            // 이동한 자리가 벽일 경우
            if (!Data.map[pos.y, pos.x])
            {
                // 원위치 시키기
                pos = prevPos;
            }
            else if (Data.IsObjectInPos(pos))
            {
                pos = prevPos;
            }


        }

        public void TakeDamage(int damage)
        {
            if (damage > DP)
            {
                Console.WriteLine($"{name}은/는 {damage - DP} 데미지를 받았았습니다.");
                curHp -= damage - DP;
            }
            else
                Console.WriteLine($"{name}에게 공격을 가했지만 {name}은 아무런 피해를 입지 않았습니다.");

            Thread.Sleep(100);

            if(curHp <= 0)
            {
                Console.WriteLine($"{name}을 쓰러트렸습니다!");
                Thread.Sleep(1000);
                Console.WriteLine("몬스터가 아이템을 떨어뜨렸습니다!");
                Data.player.GetItem(new HPpotion());
                Thread.Sleep(1000);
            }

        }
        public void Attack(Player player)
        {
            Console.WriteLine($"{name}(이/가) 플레이어에게 공격을 가합니다.");
            Thread.Sleep(1000);
            player.TakeDamage(AP);
        }


    }
}
