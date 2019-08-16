using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards { get => meleeCards; }
        public List<CombatCard>[] RangeCards { get => rangeCards; }
        public List<CombatCard>[] LongRangeCards { get => longRangeCards; }
        public SpecialCard[] SpecialMeleeCards { get => specialMeleeCards; set => specialMeleeCards = value;}
        public SpecialCard[] SpecialRangeCards { get => specialRangeCards; set => specialRangeCards = value; }
        public SpecialCard[] SpecialLongRangeCards { get => specialLongRangeCards; set => specialLongRangeCards = value; }
        public SpecialCard[] CaptainCards { get => captainCards; }
        public List<SpecialCard> WeatherCards { get => weatherCards; }
        

        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }


        public void AddCombatCard(Player player, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddSpecialCard(SpecialCard specialCard, Player player, string buffType)
        {
            throw new NotImplementedException();
        }
        public void DestroyCombatCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialCards()
        {
            throw new NotImplementedException();
        }
        public int[] GetMeleeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
    }
}
