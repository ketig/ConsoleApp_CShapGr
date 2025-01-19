using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
    class Cellphone
    {
        private string _brand;
        private double _RAM;
        private double _storage;

        public string Brand { get => _brand; set => _brand = value; }
        public double RAM { get => _RAM; set => _RAM = value; }
        public double Storage { get => _storage; set => _storage = value; }

        // Constructor
        public Cellphone() // უპარამეტრო კონსტრუქტორი
        {

        }

        public Cellphone(double Ram, string Brand, double Storage)
        {
            this.RAM = Ram;
            this.Brand = Brand;
            this Storage = Storage;
        }
    }
}
