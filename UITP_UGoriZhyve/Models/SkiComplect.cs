using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UITP_UGoriZhyve.Models
{   

    [Serializable]
    public class SkiComplect
    {
        public string Title { get; set; }
        public int ID { get; set; }
        public string Gender { get; set; }//Male/Female
        public double Weight { get; set; }
        public double Length { get; set; }
        public string Type { get; set; } //Дитячі - Дорослі
        public bool Occupied { get; set; }
        public int GenPrice { get; set; }

        public SkiComplect() { }

        //PROTOTYPE
        private static SkiComplect Ski_CheapChildren_female = new SkiComplect
        {
            Title = "Ski-LightF (Child, female)",
            Gender = "Female",
            Weight = 2,
            Length = 150,
            Type = "Child",
            GenPrice = 120
        };

        private static SkiComplect Ski_CheapChildren_male = new SkiComplect
        {
            Title = "Ski-LightM (Child, male)",
            Gender = "Male",
            Weight = 2,
            Length = 150,
            Type = "Child",
            GenPrice = 120
        };

        private static SkiComplect Ski_CheapAdult_female = new SkiComplect
        {
            Title = "Ski-MediumF (Adult, female)",
            Gender = "Female",
            Weight = 5,
            Length = 170,
            Type = "Adult",
            GenPrice = 240
        };

        private static SkiComplect Ski_CheapAdult_male = new SkiComplect
        {
            Title = "Ski-MediumM (Adult, male)",
            Gender = "Male",
            Weight = 5,
            Length = 170,
            Type = "Adult",
            GenPrice = 240
        };

        private static SkiComplect NewSki(bool occupied, SkiComplect prototype)
        {
            var scaff = prototype.DeepCopy();
            scaff.Occupied = occupied;
            return scaff;
        }

        public static SkiComplect NewSki_CheapChildren_female( bool occupied)
        {
            return NewSki(occupied, Ski_CheapChildren_female);
        }

        public static SkiComplect NewSki_CheapChildren_male(bool occupied)
        {
            return NewSki(occupied, Ski_CheapChildren_male);
        }

        public static SkiComplect NewSki_CheapAdult_female(bool occupied)
        {
            return NewSki(occupied, Ski_CheapAdult_female);
        }

        public static SkiComplect NewSki_CheapAdult_male(bool occupied)
        {
            return NewSki(occupied, Ski_CheapAdult_male);
        }


    }
}