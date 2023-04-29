using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Reservation
    {
        string restourant;
        string date;
        string hour;
        string username;
        public Reservation(string restourant,string date, string hour, string username)
        {
            this.username = username;
            this.restourant = restourant;
            this.date = date;
            this.hour = hour;
        }

        public string Restourant {  get { return restourant; } }
        public string Date { get { return date; } }
        public string Hour { get { return hour;} }
        public string Username { get { return username; } }
    }
}
