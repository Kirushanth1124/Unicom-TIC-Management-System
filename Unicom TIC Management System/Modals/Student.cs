﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Modals
{
    public class Student 
    {
 

        public int StudentID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; } 
        public string DOB { get; set; }
        public string Gender { get; set; }
        public int  PhoneNumber { get; set; }


    }
}

