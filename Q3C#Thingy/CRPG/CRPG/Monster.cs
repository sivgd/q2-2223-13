﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
   public class Monster:LivingCreature
    {

        public int ID;
        public string Name;
        public int MaximumDamage;
        public int RewardExperiencePoints;
        public int RewardGold;
        public List<LootItem> LootTable;
        public int Defense;

        public Monster(int iD, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints, int defense):base (currentHitPoints, maximumHitPoints)
        {

            ID = iD;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
            Defense = defense;



        }



    }
}
