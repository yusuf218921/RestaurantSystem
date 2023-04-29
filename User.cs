using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    internal class User
    {
        string username;
        string password;
        string name;
        string surname;
        string email;
        string tel;
        Address address;
        public Reservation[] reservations;
    }
}
