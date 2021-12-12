using System;
using System.ComponentModel.DataAnnotations;

namespace UITP_UGoriZhyve.Models
{

    [Serializable]
    public class Room
    {
        public string Title { get; set; }
        public int ID { get; set; }
        public int Capacity { get; set; }
        public double PricePerWeek { get; set; }
        public bool Occupied { get; set; }
        public string Description { get; set; }

        public Room() { }        

        public override string ToString()
        {
            string answer = $"Room №{ID}:" +
                $"\r\n\tCapacity - {Capacity} persons." +
                $"\r\n\tPrice per week - {PricePerWeek}$" +
                $"\r\n\tOccupied - {(Occupied ? "Yes" : "No")}.";
            return answer;
        }

        //PROTOTYPE
        public static Room Room_1C_7000 = new Room { Title = "One-room Lux, 7 000$", Description = "-", Capacity = 1, PricePerWeek = 7000 };
        public static Room Room_2C_14000 = new Room { Title = "Two-room Lux, 14 000$", Description = "-", Capacity = 2, PricePerWeek = 14000 };
        public static Room Room_4C_28000 = new Room { Title = "Four-room Lux, 28 000$", Description = "-", Capacity = 4, PricePerWeek = 28000 };


        public static Room NewRoom(int iD, bool occupied, Room prototype)
        {
            var scaff = prototype.DeepCopy();
            scaff.ID = iD;
            scaff.Occupied = occupied;
            return scaff;
        }

        public static Room NewRoom_1C(int iD, bool occupied)
        {
            return NewRoom(iD, occupied, Room_1C_7000);
        }

        public static Room NewRoom_2C(int iD, bool occupied)
        {
            return NewRoom(iD,  occupied, Room_2C_14000);
        }

        public static Room NewRoom_4C(int iD, bool occupied)
        {
            return NewRoom(iD, occupied, Room_4C_28000);
        }

    }
}