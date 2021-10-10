using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Triangle : Polygon
	{
		public override event Action<Polygon> FigurePainted; // event



		public override event Func<Point, Polygon, bool> FigureMoved;


		private double _aSide; // encapsulation principle
		public double A_Side // using accessors (properties) for having an access to private filed
		{
			get 
			{ 
				return _aSide; 
			}
			set // explanation: when passing another value for one of side, checking if triangle exists
			{
				double temp = _aSide;
				_aSide = value;
				if (!CanFindArea)
				{
					_aSide = temp;
					throw new ApplicationException($"Invalid value for {nameof(A_Side)})");
				}
			}
		}

		private double _bSide;
		public double B_Side
		{
			get 
			{
				return _bSide;
			}
			set 
			{
				double temp = _bSide;
				_bSide = value;
				if (!CanFindArea)
				{
					_bSide = temp;
					throw new ApplicationException($"Invalid value for {nameof(B_Side)})");
				}
			}
		}

		private double _cSide;
		public double C_Side
		{
			get 
			{ 
				return _cSide; 
			}
			set 
			{
				double temp = _cSide;
				_cSide = value;
				if (!CanFindArea)
				{
					_cSide = temp;
					throw new ApplicationException($"Invalid value for {nameof(C_Side)})");
				}
			}
		}

		public override bool CanFindArea => CheckTriangle();

		public override double AreaOfFigure => CalcAreaOfTrinagle();

		//static Triangle() // static ctor
		//{
		//	Console.WriteLine("Static ctor worked: {0}", nameof(Triangle));
		//}

		//public Triangle() // a default ctor
		//{
		//	Console.WriteLine("Default ctor worked: {0}", nameof(Triangle));
		//}

		//public Triangle(double a, double b, double c) // a parameterized ctor
		//{
		//	Console.WriteLine("Parameterized ctor worked: {0}", nameof(Triangle));
		//	_aSide = a;
		//	_bSide = b;
		//	_cSide = c;
		//}

		private Triangle(double a, double b, double c)
		{
			_aSide = a;
			_bSide = b;
			_cSide = c;
		}

		public static Triangle CreateTriangle(double a, double b, double c)
		{
			if (!CheckTriangle(a,b,c))
			{
				return null;
			}
			return new Triangle(a, b, c);
		}

		private static bool CheckTriangle(double aSide, double bSide, double cSide)
		{
			if (aSide + bSide > cSide &&
				bSide + cSide > aSide &&
				cSide + aSide > bSide)
			{
				return true;
			}
			return false;
		}

		private double CalcAreaOfTrinagle()
		{
			double perimeter = _aSide + _bSide + _cSide;
			double halfPerimeter = perimeter / 2;
			double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _aSide) * (halfPerimeter - _bSide) * (halfPerimeter - _cSide)); //Heron's formula
			return area;
		}
		
		private bool CheckTriangle()
		{
			if (_aSide + _bSide > _cSide && 
				_bSide + _cSide > _aSide && 
				_cSide + _aSide > _bSide)
			{
				return true;
			}
			return false;
		}

		

		public override void Dispose()
		{
			CleanUp(true);
			GC.SuppressFinalize(this);
		}

		public override void Paint()
		{
			Console.WriteLine($"Paint {nameof(Triangle)}");
		}

		public override void Move(double x, double y)
		{
			Console.WriteLine($"Move {nameof(Triangle)}");
		}

		~Triangle()
		{
			CleanUp(false);
			Console.WriteLine("destruct triangle");
		}
	}
}
