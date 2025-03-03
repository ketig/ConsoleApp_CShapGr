using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
	class Cellphone : Tech
	{
		private double _storage;
		public double Storage { get => _storage; set => _storage = value; }

		// Constructor
		public Cellphone() // უპარამეტრო კონსტრუქტორი
		{

		}

		public Cellphone(double ram, string brand, double storage)
		{
			RAM = ram;
			Brand = brand;
			Storage = storage;
		}
	}
}
