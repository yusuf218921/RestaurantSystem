using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    internal class Reservation
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
    }
}
