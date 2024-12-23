using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static TextRPG.Location;

namespace TextRPG
{

    public class Game
    {
        private Player player;
        public Location location = new Location();
        static Village village = new Village();
        static Field field = new Field();
        static Dungeon dungeon = new Dungeon();

        private Random random = new Random();

        public Game()
        {

        }

        public void Start()
        {
            Console.WriteLine("[RPG 세계]에 오신 것을 환영합니다!");
            Console.Write("플레이어 이름을 입력하세요: ");
            string playerName = Console.ReadLine();
            player = new Player(playerName);


            MainLoop();
        }
        public void MainLoop()
        {

            Console.WriteLine($"환영합니다 {player._playerName}님");
            Console.WriteLine("\n무엇을 하시겠습니까?");
            Console.WriteLine("1. 마을 이동");
            Console.WriteLine("2. 게임 종료");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("시작의 마을낯선 풍경이지만 왠지 익숙한 느낌이 든다.");
                    village.StartingVillage();
                    break;
                case "2":
                    Console.WriteLine("게임을 종료합니다. 안녕히가세요.");
                    return;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                    break;
            }

        }
        
        public void EnemyPool()
        {
            List<Enemy> enemies = new List<Enemy>();
            {
                enemies.Add(new Enemy("고블린", 50, 5, 3));
                enemies.Add(new Enemy("임프", 80, 15, 4));
                enemies.Add(new Enemy("스켈레톤", 100, 5, 3));
                enemies.Add(new Enemy("망령", 100, 3, 10));
                enemies.Add(new Enemy("오크", 100, 10, 5));
                enemies.Add(new Enemy("오우거", 250, 25, 10));
                enemies.Add(new Enemy("트롤", 400, 15, 15));
            }
        }

    }
}