﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStuForm
{
    public class Student
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
  


        public override string ToString()
        {
            return $"{Name} {Surname} {Email}";
        }
    }
}
