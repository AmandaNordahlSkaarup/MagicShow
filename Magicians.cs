using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicShow
{
    public class Magicians : Person
    {
        private List<string> fav_tricks = new List<string>();
        // Constructor

        public Magicians(int id, string name, string password, int level) : base(id, name, password, level)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.level = level;
        }

        public void AddFavoriteTrick(string trick)
        {
            if (trick != "") 
            {
                if (trick.Contains(','))
                {
                    List<string> tricksArr = trick.Split(',').ToList();
                    for (int i = 0; i < tricksArr.Count; i++)
                    {
                        fav_tricks.Add(tricksArr[i].ToString());
                    }
                }
                else
                {
                    fav_tricks.Add(trick);
                }
            }
        }
        public List<string> FavTricks
        {
            get { return fav_tricks; }
            // No set
        }

        public string displayTricks()
        {
            string tricks = "";
            if (fav_tricks.Count > 0)
            {

                return tricks = string.Join(", ", fav_tricks.ToArray());
            }
            else
            {
                return tricks = "-";
            }

        }
        public override string ToString()
        {
            return name + " - Magician";
        }
    }
}