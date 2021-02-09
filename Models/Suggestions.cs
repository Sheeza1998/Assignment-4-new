using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4__new_.Models
{
    public class Suggestions
    {
        public string User_Name { get; set; }
        public string Restuarant_Name { get; set; }
        public string Fav_Dish { get; set; }

        //validating phone number
        public string Phone { get; set; }
    }
}
