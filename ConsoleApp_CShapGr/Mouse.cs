using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
    class Mouse
    {
        public string Brand;
        public int Dpi;
        public bool Bluetooth;
        public bool Wireless;
        public string Color;

        public Mouse()
        {

        }

        public Mouse(string brand, int dpi, bool bluetooth, bool wireless, string color)
        {
            Brand = brand;
            Dpi = dpi;
            Bluetooth = bluetooth;
            Wireless = wireless;
            Color = color;
        }
    }
}
