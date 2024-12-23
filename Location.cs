using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Location
    {        
        public Location()
        {
        }

        public virtual void Place()
        {
            //Console.WriteLine($"{Name}, {Description}");            
        }
    }
    public class Village : Location
    {
        public Village()
        {
        }

        public void StartingVillage()
        {
            //Console.WriteLine("시작의 마을, 낯선 풍경이지만 왠지 익숙한 느낌이 든다.");
            Console.WriteLine("\n무엇을 하시겠습니까?");
            Console.WriteLine("1.촌장의 집으로 이동");
            Console.WriteLine("2.초원으로 이동");
            Console.WriteLine("3.상점으로 이동");
            Console.WriteLine("4.메인으로 이동");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("촌장님");
                    break;
                case "2":
                    Console.WriteLine("초원");
                    
                    break;
                case "3":
                    Console.WriteLine("상점");
                    break;
                case "4":
                    Console.WriteLine("메인");

                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                    break;
            }
        }

        public void TowVillage()
        {
            Console.WriteLine("\n무엇을 하시겠습니까?");
            Console.WriteLine("1.촌장의 집으로 이동");
            Console.WriteLine("2.초원으로 이동");
            Console.WriteLine("3.상점으로 이동");
            Console.WriteLine("4.메인으로 이동");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("촌장님");
                    break;
                case "2":
                    Console.WriteLine("초원");
                    break;
                case "3":
                    Console.WriteLine("상점");
                    break;
                case "4":
                    Console.WriteLine("메인");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요.");
                    break;
            }
        }
    }
    public class Field : Location
    {
        public Field()
        {

        }
        public void OneField()
        {
            Console.WriteLine("초원", "푸른 초원 위로 다양한 몬스터들이 보인다.");
            Console.WriteLine("몬스터와 전투를 합니다. 투닥투닥....");            
        }
        public void TowField()
        {
            Console.WriteLine("대 평야", "넓은 평야다..");
            Console.WriteLine("몬스터와 전투를 합니다. 투닥투닥....");

        }
    }
    public class Dungeon : Location
    {
        public Dungeon()
        {
        }
    }
}
