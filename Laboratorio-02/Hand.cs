using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Hand : Deck
    {
        public Hand() : base()
        {

        }

        public List<CombatCard> CombatCards1 { get => CombatCards; set => CombatCards = value; }
        public List<SpecialCard> SpecialCards1 { get => SpecialCards; set => SpecialCards = value; }
    }
}
