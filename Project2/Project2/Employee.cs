﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Employee : Person
    {
        private int phoneNumber;
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public Employee(string name, string surname, int idNumber, int phoneNumber) : base(name, surname, idNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            //string personType = "Employee";
            return string.Format("{0},{1},{2},{3}", Name, Surname, IdNumber, phoneNumber);
        }
    }
}
