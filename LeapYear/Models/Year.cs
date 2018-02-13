using System.Collections.Generic;
using System;
namespace LeapYear.Models
{
    public class Year
    {
        private int _year;

        public Year(int year)
        {
          _year = year;
        }
        //GETTERS
        public int GetYear()
        {
            return _year;
        }

        //SETTERS
        public void SetYear(int year)
        {
            _year = year;
        }

        public bool CheckForLeapYear(int inputYear){
          if(inputYear%400==0)
          {
            return true;
          }
          else if (inputYear%100 ==0)
          {
            return false;
          }
          else
          {
            return inputYear%4 == 0;
          }
        }
      }
}
