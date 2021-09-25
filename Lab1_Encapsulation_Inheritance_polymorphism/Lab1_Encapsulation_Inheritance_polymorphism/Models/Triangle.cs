using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Triangle : Polygon
	{
		public override double Square { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
