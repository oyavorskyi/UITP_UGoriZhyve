using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UITP_UGoriZhyve.Models
{
    public class ReserveRecreation
    {
        [Key]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public int DayCount { get; set; }
        public SkiComplect CurrentSki; 

        public ReserveRecreation() { }

        public ReserveRecreation(string email, string phoneNumber, string name,
            int dayCount, SkiComplect currentSki)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Name = name;
            DayCount = dayCount;
            CurrentSki = currentSki;
        }

        public override string ToString()
        {
            string answer = $"Reserve Check" +
                $"\nYour information:" +
                $"\n\tEmail: {Email}" +
                $"\n\tPhone number: {PhoneNumber}" +
                $"\n\tName: {Name}" +
                $"\nYour order:" +
                $"\n\tSki complect: {CurrentSki.Title}:" +
                $"\r\n\tGender - {CurrentSki.Gender} persons." +
                $"\r\n\tPrice - {CurrentSki.GenPrice}$.";
            return answer;
        }
    }
}