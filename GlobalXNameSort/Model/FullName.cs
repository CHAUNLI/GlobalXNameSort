using System;
using System.Collections.Generic;
using System.Linq;
namespace GlobalXNameSort.Model
{
    public class FullName : IComparable<FullName>
    {
        public int id { get; set; }
        //should first name list be from 1 to 3 length
        public string[] firstName;
        //should last name be not empty
        public string lastName;

        public FullName(string[] newFirstName, string newLastName)
        {

            this.firstName = newFirstName;
            this.lastName = newLastName;
        }

        public FullName(string nameStr)
        {
            string[] fullNameArray = nameStr.Split(new char[0]);
            if (fullNameArray.Length > 1)
            {
                //Last name is the last element of the full name
                this.lastName = fullNameArray[fullNameArray.Length - 1];

                //Remove last name, the left name would be the first name
                this.firstName = fullNameArray.Take(fullNameArray.Length - 1).ToArray();
            }
            else
            {
                Console.WriteLine("Invalid Full Name " + nameStr);
                //TODO: should catch this exception when the name is incompleted 
            }
        }

        public bool isValid(){
            if (this.firstName!=null && this.lastName!=null){
                return true;
            }
            return false;
        }

        public int CompareTo(FullName other)
        {
            int result = this.lastName.CompareTo(other.lastName);
            if (result == 0)
            {
                result = this.firstName.ToString().CompareTo(other.firstName.ToString());

            }
            return result;
        }

    }
}
