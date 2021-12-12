using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UITP_UGoriZhyve.Models
{
    public class ReserveRoom
    {
        [Key]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
        public Room CurrentRoom;
        public int GenPrice { get; set; }

        public ReserveRoom() { }

        public ReserveRoom(string email, string phoneNumber, string name,
            DateTime dateStart, DateTime dateEnd, Room currentRoom)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Name = name;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            CurrentRoom = currentRoom;
        }

        public override string ToString()
        {
            string answer = $"Reserve Check" +
                $"\nYour information:" +
                $"\n\tEmail: {Email}" +
                $"\n\tPhone number: {PhoneNumber}" +
                $"\n\tName: {Name}" +
                $"\nYour order:" +
                $"\n\tRoom №{CurrentRoom.ID}:" +
                $"\r\n\tCapacity - {CurrentRoom.Capacity} persons." +
                $"\r\n\tPrice per week - {CurrentRoom.PricePerWeek}$.";
            return answer;
        }
    }
}