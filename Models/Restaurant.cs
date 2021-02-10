using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4__new_.Models
{
    public class Restaurant
    {
        //creating properties

        //Creating a constructor to set Restuarant ranking
        public Restaurant(int Rank)
        {
            Ranking = Rank;
            Fav_Dish = "It's all tasyt!";
            Website = "Coming soon!";
        }

        [Required]
        public int Ranking { get;}
        [Required]
        public string Name { get; set; }

        //protection against null values
        //Setting up default values

        #nullable enable
        public string? Fav_Dish { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        public string? Phone { get; set; }
        public string? Website { get; set; }


        //method to build array
        public static Restaurant[] GetRestaurants()
        {

            Restaurant R1 = new Restaurant(1)
            {
                Name = "Olive Garden",
                Fav_Dish = "Chicken and Shrimp Carbonara",
                Address = "504 W 2230 North Provo,UT 84604",
                Phone = "(801) 377-0062",
                Website = "https://www.olivegarden.com/home"
            };
           
            Restaurant R2 = new Restaurant(2)
            {
                Name = "The Cheesecake Factory",
                Fav_Dish = "Fried shrimp",
                Address = "504 W 2230 North Provo,UT 84604",
                Phone = "(801) 377-0062",
                Website = "https://www.thecheesecakefactory.com/home"
            };

            Restaurant R3 = new Restaurant(3)
            {
                Name = "Texas Steak House",
                Fav_Dish = "Mushroom Steak",
                Address = "504 W 2230 North Provo,UT 84604",
                Phone = "(801) 377-0062",
                Website = "https://togo.texasroadhouse.com/home"
            };

            Restaurant R4 = new Restaurant(4)
            {
                Name = "Tucanos",
                Fav_Dish = "Grilled Pineapples",
                Address = "504 W 2230 North Provo,UT 84604",
                Phone = "(801) 377-0062",
                Website = "https://www.tucanos.com/menu"
            };

            Restaurant R5 = new Restaurant(5)
            {
                Name = "Zupas",
                Fav_Dish = "Soups",
                Address = "504 W 2230 North Provo,UT 84604",
                Phone = "(801) 377-0062",
                Website = "https://cafezupas.com/menu.html"
                //checking for nullvalues
            };

            //building a restaurant array and returning it
            return new Restaurant[] { R1, R2, R3, R4, R5 };
        }
    }
}
