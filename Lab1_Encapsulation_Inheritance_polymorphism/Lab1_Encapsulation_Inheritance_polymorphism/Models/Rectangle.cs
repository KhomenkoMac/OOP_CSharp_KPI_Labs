namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Rectangle : Polygon
	{
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
			_aSide = aSide;
			_bSide = bSide;
		}

		public override double AreaOfFigure => CalcAreaOfRectangle();
		
		private double CalcAreaOfRectangle()
		{
			return _aSide * _bSide;
		}
	}

}
