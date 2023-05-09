using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_R
{
    public class Player
    {
        public string image;
        public char icon = '♥';
        public Position pos;
        public List<Skill> skills;
        public string Name { get; set; }
        public int CurHp { get; set; }
        public int MaxHp { get; set; }
        public int Level { get; set; }
        public int CurExp { get; set; }
        public int MaxExp { get; set; }
        public int AP { get; set; }
        public int DP { get; set; }
        public int Gold { get; set; }

        public Player()
        {
            CurHp = 100;
            MaxHp = 100;
            Level = 1;
            CurExp = 0;
            MaxExp = 100;
            AP = 10;
            DP = 10;
            Gold = 0;

            skills = new List<Skill>();
            skills.Add(new Skill("기본 공격", Attack));
            skills.Add(new Skill("회복", Recovery));
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡒⠲⡶⠦⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠤⠂⠃⢀⣵⣾⣿⡏⠢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢠⠒⣢⠀⠀⠀⠎⠀⠀⠀⠀⠛⠛⠿⣿⣇⡀⠈⠱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠘⠻⣋⣧⡀⡄⡀⢠⠀⢈⣭⠛⣙⠒⠂⠈⠉⠃⠀⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢶⡹⢱⠃⡞⠀⣸⡟⢸⣟⢸⡿⣰⡆⠀⠀⠹⢷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢇⣿⢸⡇⣤⣿⣧⣿⣧⣼⣧⣿⣥⣤⠀⣰⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢮⣷⣯⡧⣻⣻⣿⣿⣿⣿⣿⣿⠻⠏⡠⡐⡣⠊⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢧⠾⢿⠞⣌⡛⣙⣛⣛⣏⣀⠶⣾⣝⠊⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠢⠋⠀⠈⣿⣉⡿⠿⣿⡋⣿⡱⣾⣇⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⣼⣟⣽⢪⣿⣶⣚⢭⣶⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠔⣻⢷⣶⣿⡿⣿⡛⠺⣿⡔⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢯⣺⣿⣿⣿⣧⣿⣮⣱⣿⣿⣧⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣿⣇⢿⣿⣖⣿⣿⣿⡄⣿⣿⣷⣇⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⡟⡻⡃⣳⣛⡧⣛⣟⣿⣇⠿⠿⢟⣿⣷⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠉⠉⠀⠀⠉⠉⢟⣛⣛⡀");
            image = sb.ToString();
        }
        public void ChooseName()
        {
            Console.Write("플레이어의 이름을 입력하세요 : ");
            Name = Console.ReadLine(); 
        }

        public void TryMove(Direction dir)
        {
            Position prevPos = pos;
            // 플레이어 이동
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
        }

        public void GetItem(Item item)
        {
            Data.inventory.Add(item);
        }

        public void UseItem(Item item)
        {
            Data.inventory.Remove(item);
            item.Use();
        }
        public void Heal(int heal)
        {
            CurHp += heal;
            if ( CurHp > MaxHp)
                CurHp = MaxHp;
        }

        public void Attack(Monster monster)
        {
            Console.WriteLine($"플레리어가 {monster.name}(을/를) 공격합니다.");
            Thread.Sleep(100);
            monster.TakeDamage(AP);
        }
        public void Recovery(Monster monster)
        {
            Console.WriteLine("플레이어가 회복을 시도합니다.");
            Thread.Sleep(1000);
            Heal(5);
            Console.WriteLine($"플레이어의 체력이 {CurHp}가 되었습니다.");
            Thread.Sleep(1000);
        }

        public void TakeDamage(int damage)
        {
            if (damage > DP)
            {
                Console.WriteLine($"플레이어는 {damage - DP} 데미지를 받았다.");
                CurHp -= damage - DP;
            }
            else
                Console.WriteLine($"공격은 플레이어에게 먹히지 않았다.");

            Thread.Sleep(1000);

            if (CurHp <= 0)
            {
                Console.WriteLine($"플레이어는 쓰려졌다!");
                Thread.Sleep(1000);
            }
        }
    }   

}
