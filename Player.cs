using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Player
    {
        public string _playerName { get; set; }
        public int _playerHealth { get; set; }
        public int _playerMaxHealth { get; set; }
        public int _playerMana { get; set; }
        public int _playerMaxMana { get; set; }
        public int _playerDamage { get; set; }
        public int _playerArmor { get; set; }
        public int _gold { get; set; }
        public int _maxGold {  get; set; }
        public double _playerCritical { get; set; }
        public double _playerCriticalDam { get; set; }
        public int _level {  get; set; }        
        public int _levelExp {  get; set; }
        public List<Skill> Skills { get; set; }
        public Player(string name)
        {
            _playerName = name;
            _playerHealth = 100;            
            _playerMana = 50;
            _playerDamage = 10;
            _playerArmor = 5;
            _playerCritical = 5;
            _playerCriticalDam = 50;
            _level = 1;
            _levelExp = 0;

            Skills = new List<Skill>();
        }

        public void PlayerStats()
        {
            Console.WriteLine($"이름: {_playerName}, 레벨: {_level} \n" +
                $"체력: {_playerHealth}, 마력: {_playerMana}, \n" +
                $"공격력: {_playerDamage}, 방어력: {_playerArmor} \n" +
                $"크리티컬확률: {_playerCritical} \n" +
                $"크리티컬데미지: {_playerCriticalDam} \n" +
                $"경험치: {_levelExp}");


        }
        public void LearnSkill(Skill skill)
        {
            Skills.Add(skill);
            Console.WriteLine($"{skill._SkillName} 스킬을 배웠습니다.");
        }
        public void UseSkill(string skillName)
        {
            Skill skill = Skills.Find(x => x._SkillName == skillName);
            if (skill != null)
            {
                bool cnauserSkill = false;

                if (skill._SkillManaCost > 0 && _playerMana >= skill._SkillManaCost)
                {
                    cnauserSkill = true;
                    _playerMana -= skill._SkillManaCost;
                }
                else if (skill._SkillHealthCost > 1 && _playerHealth >= skill._SkillHealthCost)
                {
                    cnauserSkill = true;
                    _playerHealth -= skill._SkillHealthCost;
                }
                if (cnauserSkill)
                {
                    skill.Use();

                }

            }
        }
    }
}
