using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectAngular.Models
{
    public class Recipe
    {
        public int CodeRecipe { get; set; }
        public string NameRecipe { get; set; }
        public int CodeCategory { get; set; }
        public int Time { get; set; }
        private int levelOfDifficul;

        public int LevelOfDifficul
        {
            get { return levelOfDifficul; }
            set {if(value>=1&&value<=5) 
                levelOfDifficul = value; }
        }
        public DateTime DateAddRecipe { get; set; }
        public List <string> ListComponent { get; set; }
        public List<string>  PrepartionM { get; set; }
        public int CodeUser { get; set; }
        public string Image { get; set; }
        public Boolean IfShow { get; set; }
    }
}