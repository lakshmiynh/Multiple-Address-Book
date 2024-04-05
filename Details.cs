﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class Details
    {
        public string firstname {  get; set; }  
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }

        public string state { get; set; }

        public int zipcode { get; set; }
        public double phonenumber { get; set; }
        public string email { get; set; }


        public Details(string firstname, string lastname, string address, string city, string state, int zipcode, double phonenumber, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phonenumber = phonenumber;
            this.email=email;



         }


    }
}

