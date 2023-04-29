using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string name;
        private string surname;
        private string email;
        private string tel;
        private List<Reservation> reservations = new List<Reservation>();
        
        public User(int id,string username,string password,string name,string surname,string email,string tel)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.tel = tel;
        }

        public void addReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
        public int Id { get { return id; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } }
        public string Name { get { return name; } }
        public string Surname { get {  return surname; } }
        public string Email { get { return email; } }
        public string Tel { get { return tel; } }
        public List<Reservation> Reservations
        {
            get
            {
                return reservations;
            }
            set
            {
                reservations = value;
            }
        }

    }
}
