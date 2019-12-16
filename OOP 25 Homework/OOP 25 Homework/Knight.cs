using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_25_Homework
{
    public class Knight
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthTown, string title)
        {
            Name = name;
            BirthTown = birthTown;
            Title = title;
        }

        public string this[string fieldName]
        {
            get
            {
                if (fieldName == "Name")
                    return Name;
                if (fieldName == "BirthTown")
                    return BirthTown;
                if (fieldName == "Title")
                    return Title;
                return "UNKNOWN FIELD NAME";
            }

            set
            {
                if (fieldName == "Name")
                    Name = value; ;
                if (fieldName == "BirthTown")
                    BirthTown = value;
                if (fieldName == "Title")
                    Title = value;
            }
        }

        public override string ToString()
        {
            return $"Knight --- Name: {Name}, Birth Town {BirthTown}, Title: {Title}";
        }
    }
}
