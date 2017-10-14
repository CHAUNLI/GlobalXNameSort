using System;
using System.Collections.Generic;
using System.Linq;
namespace GlobalXNameSort.Model
{
    public class FullName : IComparable<FullName>
    {
        public int id { get; set; }
        //should first name list be from 1 to 3 length
        public List<string> firstName = new List<string>();
        //should last name be not empty
        public string lastName;


        public FullName(List<string> newFirstName, string newLastName)
        {
            this.firstName = newFirstName;
            this.lastName = newLastName;
        }

        public FullName(string nameStr)
        {
            string[] fullNameArray = nameStr.Split(new char[0]);
            if (fullNameArray.Length > 1)
            {
                //List <string> list = new List<string>(nameArray[nameArray.Length - 1]);
                this.lastName = fullNameArray[fullNameArray.Length - 1];

                string[] firstNameArray = fullNameArray.Take(fullNameArray.Length - 1).ToArray();

                this.firstName = new List<string>(firstNameArray);
            }
            else
            {
                Console.WriteLine("Invalid Full Name " + nameStr);
                //TODO: should catch this exception when the name is incompleted 
            }
        }



        public int CompareTo(FullName other)
        {
            int result = this.lastName.CompareTo(other.lastName);
            if (result == 0)
            {
                string firstName0 = this.firstName.First();
                result = firstName0.CompareTo(other.firstName.First());
                if (result == 0)
                {
                    if (this.firstName.Count== 1 && other.firstName.Count == 1)
                    {
                        result = 0;
                    }
                    else if ((this.firstName.Count == 1) && (other.firstName.Count > 1))
                    {
                        result = -1;
                    }
                    else if ((this.firstName.Count > 1) && (other.firstName.Count == 1))
                    {
                        result = 1;
                    }
                    else if((this.firstName.Count > 1) && (other.firstName.Count > 1))
                    {
                        string firstName1 = this.firstName[1];
                        result = firstName1.CompareTo(other.firstName[1]);
                        if (result == 0)
                        {

                        }
                    }
                }
            }
            return result;
        }

    }
}
