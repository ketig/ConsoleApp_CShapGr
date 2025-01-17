using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
    enum Color { Black, Green, Red, Blue }
    class Computer
    {
        private Color _color;
        private string _gpu;
        private string _cpu;
        private string _ram;
        private string _brand;
        private string _model;
        private uint _quantity;

        public Color Color { get => _color; set => _color = value; }
        public string GPU { get => _gpu; set => _gpu = value; }
        public string CPU { get => _cpu; set => _cpu = value; }
        public string RAM { get => _ram; set => _ram = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public uint Quantity { get => _quantity; set => _quantity = value; }

        public Computer()
        {

        }

        public Computer(Color Color, string GPU, string CPU, string RAM, string Brand, string Model, uint Quantity)
        {
            this.Color = Color;
            this.GPU = GPU;
            this.CPU = CPU;
            this.RAM = RAM;
            this.Brand = Brand;
            this.Model = Model;
            this.Quantity = Quantity;
        }
    }
}
