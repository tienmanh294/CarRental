using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Rent
    {
        public string firstName;
        public string lastName;
        public int phoneNumber;
        public string address;
        public DateTime dateRent;
        public DateTime dueDate;
        public string location;

        public Rent(string fName, string lName, int pNumber, string _address, DateTime _dateRent, DateTime _dueDate, string _location)
        {
            firstName = fName;
            lastName = lName;
            phoneNumber = pNumber;
            address = _address;
            dateRent = _dateRent;
            dueDate = _dueDate;
            location = _location;
        }
    }
}
