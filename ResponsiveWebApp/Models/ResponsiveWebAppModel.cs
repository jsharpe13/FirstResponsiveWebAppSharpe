using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ResponsiveWebApp.Models
{
    public class ResponsiveWebAppModel
    {
        private string? _name;
        private int? _birthyear;
        private int? _birthmonth;
        private int? _birthday;

        private const int MIN_YEAR = 1900;
        private const int CURRENT_YEAR = 2020;

        [Required(ErrorMessage ="Please enter your name.")]
        public string? Name
        {
            get { return _name;  }
            set { _name = value; }
        }
        [Required(ErrorMessage ="Please enter your year of birth.")]
        [Range(MIN_YEAR, CURRENT_YEAR, ErrorMessage ="Enter a year between 1900 and the current year")]
        public int? BirthYear
        {
            get { return _birthyear; }
            set { _birthyear = value; }
        }
        [Required(ErrorMessage = "Please enter the month of birth.")]
        [Range(1, 12, ErrorMessage = "Enter a month between 1 and 12")]
        public int? BirthMonth
        {
            get { return _birthmonth; }
            set { _birthmonth = value; }
        }
        [Required(ErrorMessage = "Please enter the day of birth.")]
        [Range(1, 31, ErrorMessage = "Enter a day between 1 and 31")]
        public int? BirthDay
        {
            get { return _birthday; }
            set { _birthday = value; }
        }


        public int? AgeThisYear()
        {
            int? age = CURRENT_YEAR - _birthyear;
            if(DateTime.Now.Month < _birthmonth)
            {
                age = age - 1;  
            }
            else if(DateTime.Now.Month == _birthmonth)
            {
                if(DateTime.Now.Day < _birthday)
                {
                    age = age - 1;
                }
            }
            if(age < 0)
            {
                age = 0;
            }
            return age;
        }

        public override string ToString()
        {
            return "Name: " + _name + ",Birth Year: " + _birthyear + ",Birth Month: " + _birthmonth + ",Birth Day: " + _birthday ;
        }
    }
}
