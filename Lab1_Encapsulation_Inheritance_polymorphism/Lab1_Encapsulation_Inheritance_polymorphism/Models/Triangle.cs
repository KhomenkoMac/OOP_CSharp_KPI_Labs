using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Triangle : Polygon
	{
		private double _aSide;
		public double A_Side
		{
			get { return _aSide; }
			set { _bSide = value; }
		}

		private double _bSide;
		public double B_Side
		{
			get { return _bSide; }
			set { _bSide = value; }
		}

		private double _cSide;
		public double C_Side
		{
			get { return _cSide; }
			set { _cSide = value; }
		}

		public Triangle(double a, double b, double c)
		{
			_aSide = a;
			_bSide = b;
			_cSide = c;
		}

		public override double Square { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
