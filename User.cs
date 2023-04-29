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
        List<Reservation> reservations = new List<Reservation>();
        
        public User(string username,string password,string name,string surname,string email,string tel,Address adress)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.tel = tel;
            this.address = adress;
        }

        public void addReservation(Reservation reservation)
        {
            this.reservations.Add(reservation);
        }

        public string Username()
        {
            get {
                return username;
            }
        }
    }
}
