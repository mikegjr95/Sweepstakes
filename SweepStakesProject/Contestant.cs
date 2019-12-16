using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string registrationNum;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
       

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }


        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }


        public string RegistrationNumber
        {
            get
            {
                return registrationNum;
            }
            set
            {
                registrationNum = value;
            }
        }
    }
}
