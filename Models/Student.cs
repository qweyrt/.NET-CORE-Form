using System;

namespace Ctrlr.Models
{
    public class Student
    {
        public String firstname;
        public String lastname;
        public Byte gender;
        public DateTime dateofbirth;
        public int phonenumber;
        public int age;
        public String placeofbirth;
        public bool grad;

        public String getFirstname()
        {
            return this.firstname;
        }

        public void setFirstname(String firstname)
        {
            this.firstname = firstname;
        }

        public String getLastname()
        {
            return this.lastname;
        }

        public void setLastname(String lastname)
        {
            this.lastname = lastname;
        }

        public Byte getGender()
        {
            return this.gender;
        }

        public void setGender(Byte gender)
        {
            this.gender = gender;
        }

        public DateTime getDateofbirth()
        {
            return this.dateofbirth;
        }

        public void setDateofbirth(DateTime dateofbirth)
        {
            this.dateofbirth = dateofbirth;
        }

        public int getPhonenumber()
        {
            return this.phonenumber;
        }

        public void setPhonenumber(int phonenumber)
        {
            this.phonenumber = phonenumber;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public String getPlaceofbirth()
        {
            return this.placeofbirth;
        }

        public void setPlaceofbirth(String placeofbirth)
        {
            this.placeofbirth = placeofbirth;
        }

        public bool isGrad()
        {
            return this.grad;
        }

        public void setGrad(bool grad)
        {
            this.grad = grad;
        }
        
    }
}