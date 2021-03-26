using System;
namespace Ctrlr.Models
{
    public class Member : Student
    {
        public DateTime startdate;
        public DateTime enddate;
        public Member(String firstname,
                       String lastname,
                       Byte gender,
                       DateTime dateofbirth,
                       int phonenumber,
                       int age,
                       String placeofbirth,
                       bool grad,
                       DateTime startdate,
                       DateTime enddate)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.dateofbirth = dateofbirth;
            this.phonenumber = phonenumber;
            this.age = age;
            this.placeofbirth = placeofbirth;
            this.grad = grad;
            this.startdate = startdate;
            this.enddate = enddate;
        }

        public Member()
        {
        }

        public DateTime getStartdate()
        {
            return this.startdate;
        }

        public void setStartdate(DateTime startdate)
        {
            this.startdate = startdate;
        }

        public DateTime getEnddate()
        {
            return this.enddate;
        }

        public void setEnddate(DateTime enddate)
        {
            this.enddate = enddate;
        }
        
    }
}