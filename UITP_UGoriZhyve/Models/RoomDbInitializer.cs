using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UITP_UGoriZhyve.Models
{
    public class RoomDbInitializer : DropCreateDatabaseAlways<RoomContext>
    {
        Random random = new Random();

        protected override void Seed(RoomContext db)
        {
            int n = 15;
            for (int i = 0; i < n; i++)
            {
                var choice = random.Next(1, 4);
                switch (choice)
                {
                    case 1:
                        var scaffRoom = Room.NewRoom_1C(i + 1, false);
                        db.Rooms.Add(scaffRoom);
                        break;
                    case 2:
                        scaffRoom = Room.NewRoom_2C(i + 1, false);
                        db.Rooms.Add(scaffRoom);
                        break;
                    case 3:
                        scaffRoom = Room.NewRoom_4C(i + 1, false);
                        db.Rooms.Add(scaffRoom);
                        break;
                    default: break;
                }
            }

            

            base.Seed(db);
        }
    }
}