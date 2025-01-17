using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
    class Mouse
    {
        public string _brand;
        public int _dpi;
        public bool _bluetooth;
        public bool _wireless;
        public string _color;

        public Mouse()
        {

        }

        public Mouse(string brand, int dpi, bool bluetooth, bool wireless, string color)
        {
            _brand = brand;
            _dpi = dpi;
            _bluetooth = bluetooth;
            _wireless = wireless;
            _color = color;
        }
    }
}
