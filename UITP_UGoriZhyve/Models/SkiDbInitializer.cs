using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UITP_UGoriZhyve.Models
{
    public class SkiDbInitializer : DropCreateDatabaseAlways<SkiContext>
    {
        protected override void Seed(SkiContext db)
        {
            for (int i = 0; i < 10; i++)
            {
                var scaffSki = SkiComplect.NewSki_CheapAdult_female(false);
                db.SkiComplects.Add(scaffSki);
            }

            for (int i = 0; i < 10; i++)
            {
                var scaffSki = SkiComplect.NewSki_CheapAdult_male(false);
                db.SkiComplects.Add(scaffSki);
            }

            for (int i = 0; i < 5; i++)
            {
                var scaffSki = SkiComplect.NewSki_CheapChildren_female(false);
                db.SkiComplects.Add(scaffSki);
            }

            for (int i = 0; i < 5; i++)
            {
                var scaffSki = SkiComplect.NewSki_CheapChildren_male(false);
                db.SkiComplects.Add(scaffSki);
            }



            base.Seed(db);
        }
    }
}