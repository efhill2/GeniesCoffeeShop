using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GeniesCoffeeShop.Models
{
    public class Orders : Users
    {
        public string DrinkSize { get; set; }
        public string DrinkSelection { get; set; }
        public string UserChoice { get; set; }
        public string PickUpTime { get; set; }        
        public string Delivery { get; set; }
    }
}