using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Unit_Tests
{
    [TestClass]
    public class PokemonUnitTest
    {
        //identifiers
        [TestMethod]
        public void Pokemon_ConstucterTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            Assert.AreEqual(10, pikachu.id);
            Assert.AreEqual(false, pikachu.have);
            Assert.AreEqual("Subject 10", pikachu.name);
        }
        [TestMethod]
        public void Pokemon_AcquireTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.Acquire();

            Assert.AreEqual(true, pikachu.have);
        }
        [TestMethod]
        public void Pokemon_NewNameTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.SetName("Pika");

            Assert.AreEqual("Pika", pikachu.name);
        }

        //important stats
        [TestMethod]
        public void Pokemon_AffectionTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.AffectionGain(5);

            Assert.AreEqual(5, pikachu.affection);
        }
        [TestMethod]
        public void Pokemon_AdvanceQuest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.AdvanceQuest();

            Assert.AreEqual(1, pikachu.quest);
        }
        [TestMethod]
        public void Pokemon_EvolutionTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.Evolve();

            Assert.AreEqual(2, pikachu.evolution);
        }
        [TestMethod]
        public void Pokemon_EvolveHoldTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.HoldEvolve();

            Assert.AreEqual(true, pikachu.evolutionstopped);
        }

        //stamina stats
        [TestMethod]
        public void Pokemon_StaminaResetTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.StaminaChange(-30);
            pikachu.StaminaReset();

            Assert.AreEqual(pikachu.stamina, pikachu.maxstamina);
            Assert.AreEqual(false, pikachu.tired);
        }
        [TestMethod]
        public void Pokemon_StaminaChangeTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            Class_Library.Pokemon chu = new Class_Library.Pokemon(11, "Subject 11", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            Class_Library.Pokemon pika = new Class_Library.Pokemon(12, "Subject 12", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.StaminaChange(-10);
            pikachu.StaminaChange(5);
            chu.StaminaChange(-5);
            pika.StaminaChange(-30);

            Assert.AreEqual(15, pikachu.stamina);
            Assert.AreEqual(15, chu.stamina);
            Assert.AreEqual(0, pika.stamina);
            Assert.AreEqual(true, pika.tired);
        }
        [TestMethod]
        public void Pokemon_MaxStaminaTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.StaminaIncrease(2);

            Assert.AreEqual(22, pikachu.maxstamina);
        }
        [TestMethod]
        public void Pokemon_TiredTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.TiredChange();

            Assert.AreEqual(0, pikachu.stamina);
            Assert.AreEqual(true, pikachu.tired);
        }

        //milk stats
        [TestMethod]
        public void Pokemon_LactationChangeTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            Class_Library.Pokemon chu = new Class_Library.Pokemon(11, "Subject 11", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.LactationStart();
            chu.LactationStart();
            chu.LactationStop();

            Assert.AreEqual(true, pikachu.lactating);
            Assert.AreEqual(false, chu.lactating);
        }
        [TestMethod]
        public void Pokemon_MilkChangeTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            Class_Library.Pokemon chu = new Class_Library.Pokemon(11, "Subject 11", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.MilkIncrease();
            chu.MilkIncrease();
            chu.MilkIncrease();
            chu.MilkDecrease(1);

            Assert.AreEqual(1, pikachu.milk);
            Assert.AreEqual(1, chu.milk);
        }
        [TestMethod]
        public void Pokemon_MilkLevelChangeTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            Class_Library.Pokemon chu = new Class_Library.Pokemon(11, "Subject 11", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.SetMilkLevel(4);

            Assert.AreEqual(4, pikachu.maxmilk);
        }

        //pregnancy stats
        [TestMethod]
        public void Pokemon_PregnancyRollTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.SetFert(5);
            pikachu.PregnancyRoll();

            Assert.AreEqual(true, pikachu.pregnant);
        }
        [TestMethod]
        public void Pokemon_PregnancyStartTest()
        {
            bool inrange = false;
            bool haschildren = false;
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.PregnancyStart();
            if (pikachu.pregtracker >= 173 && pikachu.pregtracker <= 187)
            {
                inrange = true;
            }
            if (pikachu.pregamount >= 1)
            {
                haschildren = true;
            }

            Assert.AreEqual(true, pikachu.pregnant);
            Assert.AreEqual(true, inrange);
            Assert.AreEqual(true, haschildren);
            Assert.AreEqual(true, pikachu.pregform1);
        }
        [TestMethod]
        public void Pokemon_PregnancyAdvanceTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            int pregnanttrack;

            pikachu.PregnancyStart();
            pregnanttrack = pikachu.pregtracker;
            pregnanttrack--;
            pikachu.PregnancyAdvance(1);

            Assert.AreEqual(pregnanttrack, pikachu.pregtracker);
        }
        [TestMethod]
        public void Pokemon_BirthTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            int babies;

            pikachu.PregnancyStart();
            babies = pikachu.pregamount;
            pikachu.PregnancyAdvance(pikachu.pregtracker);
            pikachu.GiveBirth();

            Assert.AreEqual(babies, pikachu.childrenMothered);
        }

        //children stats
        [TestMethod]
        public void Pokemon_SetFertilityTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.SetFert(3);

            Assert.AreEqual(3, pikachu.fertility);
            Assert.AreEqual(3, pikachu.currentfertility);
        }
        [TestMethod]
        public void Pokemon_IncreaseFertilityTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.IncreaseCurrentFert(1);

            Assert.AreEqual(3, pikachu.currentfertility);
        }
        [TestMethod]
        public void Pokemon_ChangeFertilityTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.ChangeCurrentFert(0);

            Assert.AreEqual(0, pikachu.currentfertility);
        }
        [TestMethod]
        public void Pokemon_ResetFertilityTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.ChangeCurrentFert(0);
            pikachu.ResetCurrentFert();

            Assert.AreEqual(2, pikachu.currentfertility);
        }
        [TestMethod]
        public void Pokemon_MMChildrenChangeTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");

            pikachu.ChangeBabyAmount(2, 3);

            Assert.AreEqual(2, pikachu.minbabies);
            Assert.AreEqual(3, pikachu.maxbabies);
        }
        [TestMethod]
        public void Pokemon_ChildrenTest()
        {
            Class_Library.Pokemon pikachu = new Class_Library.Pokemon(10, "Subject 10", 2, 20, 2, 1, 4, "tiny", "none", "head", "mouth", "hands", "tongue");
            int babies;

            pikachu.PregnancyStart();
            babies = pikachu.pregamount;
            pikachu.PregnancyAdvance(pikachu.pregtracker);
            pikachu.GiveBirth();

            Assert.AreEqual(babies, pikachu.GetBabiesAmount());
        }
    }
}
