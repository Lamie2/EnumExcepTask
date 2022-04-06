﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Product
    {
        static int _totalCount;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType Type { get; set; }
    }
}
