using System;
using System.Threading;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Rectangle : Polygon
	{
		public override event Func<Point, Polygon, bool> FigureMoved; // event
		
		public override event Action<Polygon> FigurePainted; 


		static int currentValue = 0; // for showing life time of instance
		private int Id => currentValue;


		private double _aSide; // encapsulation principle
		public double A_Side // using accessors (properties) for having an access to private field
		{
			get
			{
				return _aSide;
			}
			set
			{
				_bSide = value;
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
				_bSide = value;
			}
		}

		public Rectangle(double aSide, double bSide)
		{
			++currentValue;
			Console.WriteLine($"{nameof(Rectangle)} -> base ctor {Id} executed");
			_aSide = aSide;
			_bSide = bSide;
		}

		public override double AreaOfFigure => CalcAreaOfRectangle();
		
		private double CalcAreaOfRectangle()
		{
			return _aSide * _bSide;
		}

		public override void Paint()
		{
			Console.WriteLine($"Paint {nameof(Rectangle)}");
			this.FigurePainted?.Invoke(this);
		}

		public override void Move(int x, int y)
		{
			Console.WriteLine($"Move {nameof(Rectangle)}");
		}

		~Rectangle()
		{
			CleanUp(false);
			Console.WriteLine($"Destruct Rectangle {Id} Gen:{GC.GetGeneration(this)}");
			Thread.Sleep(100);
		}
	}

}
