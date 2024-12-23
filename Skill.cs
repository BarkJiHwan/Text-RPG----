using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Skill
    {
        public string _SkillName { get; set; }
        public int _SkillDamage { get; set; }
        public int _SkillManaCost { get; set; }
        public int _SkillHealthCost { get; set; }
        public int _SkillAttack {  get; set; }
        public int _SkillDefense {  get; set; }
        public int _SkillCritical {  get; set; }
        public int _SkillCriticalDam { get; set; }

        public Skill(string name, int damage, int manaCost)
        {
            _SkillName = name;
            _SkillDamage = damage;
            _SkillManaCost = manaCost;
        }
        public void Use()
        {
            Console.WriteLine($"{_SkillName} 스킬을 사용했습니다.");
        }
        public void AttSkill()
        {

        }
        public void BufSkill()
        {

        }
        public void HealSkill()
        {

        }
        public void ManaHealSkill()
        {

        }
    }
}
