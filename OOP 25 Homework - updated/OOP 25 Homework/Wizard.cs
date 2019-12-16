using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_25_Homework
{
    public class Wizard
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string FavouriteSpell { get; private set; }

        public Wizard(string name, string birthTown, string favouriteSpell)
        {
            Name = name;
            BirthTown = birthTown;
            FavouriteSpell = favouriteSpell;
        }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return Name;
                if (fieldName == "BirthTown")
                    return BirthTown;
                if (fieldName == "FavouriteSpell")
                    return FavouriteSpell;
                return "UNKNOWN FIELD NAME";
            }
            set
            {
                if (fieldName == "Name")
                    Name = value; ;
                if (fieldName == "BirthTown")
                    BirthTown = value;
                if (fieldName == "FavouriteSpell")
                    FavouriteSpell = value;
            }
        }

        public override string ToString()
        {
            return $"Wizard --- Name: {Name}, Birth Town {BirthTown}, Favourite Spell: {FavouriteSpell}";
        }
    }
}
