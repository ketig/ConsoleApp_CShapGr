using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
    class Computer
    {
        private string _color;
        private string _gpu;
        private string _cpu;
        private string _ram;
        private string _brand;
        private string _model;
        private uint _quantity;

        public string Color { get => _color; set => _color = value; }
        public string GPU { get => _gpu; set => _gpu = value; }
        public string CPU { get => _cpu; set => _cpu = value; }
        public string RAM { get => _ram; set => _ram = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public uint Quantity { get => _quantity; set => _quantity = value; }
    }
}
