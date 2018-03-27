using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Pokemon
    {
        //identifiers
        public int id;
        public bool have;
        public string name;

        //important stats
        public int evolution;
        public bool evolutionstopped;
        public int affection;
        public int quest;

        //stamina stats
        public int stamina;
        public int maxstamina;
        public bool tired;

        //milk stats
        public bool lactating;
        public int milk;
        public int maxmilk;

        //pregnancy stats
        public bool pregnant;
        public int pregdiff;
        public int pregtracker;
        public int preglength;
        public int pregamount;
        public bool pregform1;
        public bool pregform2;
        public bool pregform3;
        public string babysize;

        //children stats
        public int fertility;
        public int currentfertility;
        public int minbabies;
        public int maxbabies;
        public int childrenMothered;
        public int childrenFathered;

        //Body stats
        public string size;
        public string oddities;
        public string head;
        public string mouth;
        public string hands;
        public string tongue;

        public Pokemon(int subjectId, string currentName, int maxMilkLevel, int startStamina, int currentFert, int minbabiesOnce, int maxbabiesOnce, string Psize, string Poddities, string Phead, string Pmouth, string Phands, string Ptongue)
        {
            //identifiers
            id = subjectId;
            have = false;
            name = currentName;

            //important stats
            affection = 0;
            quest = 0;
            evolution = 1;
            evolutionstopped = false;

            //stamina stats
            stamina = startStamina;
            maxstamina = startStamina;
            tired = false;

            //milk stats
            lactating = false;
            milk = 0;
            maxmilk = maxMilkLevel;

            //pregnancy stats
            pregnant = false;
            pregdiff = 0; //TODO
            pregtracker = 0;
            preglength = 0;
            pregamount = 0;
            pregform1 = false;
            pregform2 = false;
            pregform3 = false;
            babysize = Psize;

            //children
            fertility = currentFert;
            currentfertility = currentFert;
            minbabies = minbabiesOnce;
            maxbabies = maxbabiesOnce;
            childrenMothered = 0;
            childrenFathered = 0;

            //Body
            size = Psize;
            oddities = Poddities;
            head = Phead;
            mouth = Pmouth;
            hands = Phands;
            tongue = Ptongue;
            
        }

        //identifiers
        public void Acquire()
        {
            have = true;
        }
        public void SetName(string newName)
        {
            name = newName;
        }

        //important stats
        public void AffectionGain(int Naffection)
        {
            affection += Naffection;
        }
        public void AdvanceQuest()
        {
            quest++;
        }
        public void Evolve()
        {
            if (pregnant == false)
            {
                evolution++;
            }
        }
        public void HoldEvolve()
        {
            if (evolutionstopped == false)
            {
                evolutionstopped = true;
            }
            else if (evolutionstopped == true)
            {
                evolutionstopped = false;
            }

        }

        //stamina stats
        public void StaminaReset()
        {
            stamina = maxstamina;
            tired = false;
        }
        public void StaminaChange(int Nstamina)
        {
            stamina += Nstamina;
            if (stamina > maxstamina)
            {
                stamina = maxstamina;
            }
            if (stamina <= 0)
            {
                stamina = 0;
                tired = true;
            }
        }
        public void StaminaIncrease(int Nstamina)
        {
            maxstamina += Nstamina;
        }
        public void TiredChange()
        {
            tired = true;
            stamina = 0;

        }

        //milk stats
        public void LactationStart()
        {
            lactating = true;
        }
        public void LactationStop()
        {
            lactating = false;
        }
        public void MilkIncrease()
        {
            milk += 1;
        }
        public void MilkDecrease(int milking)
        {
            milk -= milking;
        }
        public void SetMilkLevel(int MilkLev)
        {
            maxmilk = MilkLev;
        }

        //pregnancy stats
        public void PregnancyRoll()
        {
            Random rnd = new Random();
            int chance = 0;
            if (currentfertility == 1)
            {
                chance = rnd.Next(1, 20);
            }
            else if (currentfertility == 2)
            {
                chance = rnd.Next(1, 10);
            }
            else if (currentfertility == 3)
            {
                chance = rnd.Next(1, 5);
            }
            else if (currentfertility == 4)
            {
                chance = rnd.Next(1, 2);
            }
            else if (currentfertility >= 5)
            {
                chance = 1;
            }
            if (chance == 1)
            {
                PregnancyStart();
            }
        }
        public void PregnancyStart()
        {
            Random rnd = new Random();
            pregnant = true;
            pregamount = rnd.Next(minbabies, maxbabies);
            if (babysize == "tiny")
            {
                pregtracker = 180;
                pregtracker += rnd.Next(-7, 7);
            }
            else if (babysize == "small")
            {
                pregtracker = 230;
                pregtracker += rnd.Next(-10, 11);
            }
            else if (babysize == "medium")
            {
                pregtracker = 280;
                pregtracker += rnd.Next(-14, 14);
            }
            else if (babysize == "large")
            {
                pregtracker = 330;
                pregtracker += rnd.Next(-17, 18);
            }
            else if (babysize == "huge")
            {
                pregtracker = 380;
                pregtracker += rnd.Next(-21, 21);
                preglength = pregtracker;
            }
            if (evolution == 1 && pregform1 == false)
            {
                pregform1 = true;
            }
            else if (evolution == 2 && pregform2 == false)
            {
                pregform2 = true;
            }
            else if (evolution == 3 && pregform2 == false)
            {
                pregform3 = true;
            }
            preglength = pregtracker;
        }
        public void PregnancyAdvance(int days)
        {
            if (pregtracker > 0 && pregnant == true)
            {
                pregtracker -= days;
            }
        }
        public int GiveBirth()
        {
            int hold = 0;
            if (pregtracker == 0 && pregnant == true)
            {
                pregnant = false;
                childrenMothered += pregamount;
                hold = pregamount;
                pregamount = 0;
            }
            return hold;
        }
        public void FatheredChanged(int babies)
        {
            childrenFathered += babies;
        } //Unit Test TODO

        //children stats
        public void SetFert(int fert)
        {
            int hold = currentfertility;
            hold -= fertility;
            fertility = fert;
            currentfertility = hold + fertility;
        }
        public void IncreaseCurrentFert(int fert)
        {
            currentfertility += fert;
        }
        public void ChangeCurrentFert(int fert)
        {
            currentfertility = fert;
        }
        public void ResetCurrentFert()
        {
            currentfertility = fertility;
        }
        public void ChangeBabyAmount(int min, int max)
        {
            minbabies = min;
            maxbabies = max;
        }
        public int GetBabiesAmount()
        {
            int children = childrenFathered + childrenMothered;
            return children;
        }
    }
}
