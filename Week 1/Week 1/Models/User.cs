﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week_1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public  string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}