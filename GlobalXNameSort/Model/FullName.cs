using System;
using System.Collections.Generic;
using System.Linq;


namespace GlobalXNameSort.Model
{
    public class FullName : IComparable<FullName>
    {
        public int id { get; set; }
        //Should first name list be from 1 to 3 length
        public string[] firstName;
        //Should has one lastName
        public string lastName;

        public FullName(string nameStr)
        {
            //remove space from start and end, as well as more than one space within the words
            nameStr = nameStr.TrimStart();
            nameStr = nameStr.TrimEnd();
            string[] fullNameArray = nameStr.Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries);
            if ((fullNameArray.Length < 5) && (fullNameArray.Length > 1) && (nameStr.Trim() != ""))
            {
                //Last name is the last element of the full name
                this.lastName = fullNameArray[fullNameArray.Length - 1];

                //Remove last name, the left name would be the first name
                this.firstName = fullNameArray.Take(fullNameArray.Length - 1).ToArray();
            }
            else
            {
                Console.WriteLine("[Warning]: Invalid Full Name " + nameStr + ", will be removed from sorted list.");
                //if this is not a valid string, if it only has one word, then set it as last name. 
                if ((nameStr != null) && (nameStr.Trim() != ""))
                {
                    this.lastName = nameStr;
                }

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
            //Preset the result as is greater than other, if it's not a valid string, always add it to last  
            int result =1;
            if (this.isValid()&&other.isValid()) 
            { 
                result = this.lastName.CompareTo(other.lastName);
                if (result == 0)
                {
                    result = this.firstName.ToString().CompareTo(other.firstName.ToString());

                }
            }else if(!this.isValid() && !other.isValid()){
                result = 0;
            }

            return result;
        }
        override public string ToString()
        {
            if (this.isValid()){
                
                return string.Join(" ", this.firstName) + " " + this.lastName;
            }

            if(this.lastName!= null){
                return this.lastName;
            }
            return Constants.nullFullNamePlaceHolder;
        }
    }
}
