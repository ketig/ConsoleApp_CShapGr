using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CShapGr
{
	abstract class Tech
	{
		protected string _brand;
		protected double _RAM;

		public string Brand { get => _brand; set => _brand = value; }
		public double RAM { get => _RAM; set => _RAM = value; }
	}
}
