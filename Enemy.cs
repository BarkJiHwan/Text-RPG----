using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace TextRPG
{
    internal class Enemy
    {
        public string _enemyName {  get; set; }
        public int _enemyHealth { get; set; }
        public int _enemyDamage { get; set; }
        public int _enemyArmor { get; set; }

        public Enemy(string name, int health, int damage, int armor)
        {
            _enemyName = name;
            _enemyHealth = health;
            _enemyDamage = damage;
            _enemyArmor = armor;
        }

        public void EnemyStats()
        {
            Console.WriteLine($"적 이름: {_enemyName} \n" +
                $"체력: {_enemyHealth}, 공격력: {_enemyDamage}, 방어력: {_enemyArmor}");
        }
    }
}
