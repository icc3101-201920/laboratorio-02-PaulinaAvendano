using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        private string name;
        private string type;
        private string effect;

        public Card(string name, string type, string effect)
        {
            Name = name;
            Type = type;
            Effect = effect;
        }

        public string Name { get => name; set => Name = name; }

        public string Type { get => type; set => Type = type; }

        public string Effect { get => effect; set => Effect = effect; }
        }
    }