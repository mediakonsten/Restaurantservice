﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantservice
{
    public class Label
    {

        public string Name { get; set; }
        public string Dish { get; set; }
        public string Date { get; set; }
        public string Addr { get; set; }
        public string Logo { get; set; }
        public bool DeliverCold { get; set; }

        public Label(string name, string dish, string date, string addr, bool deliverCold)
        {
            Name = name;
            Dish = dish;
            Date = date;
            Addr = addr;
            Logo = @"..\..\Media\kniv-och-gaffel-logotyp-1.png";
            DeliverCold = deliverCold;
        }
    }
}
