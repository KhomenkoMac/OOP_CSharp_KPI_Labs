namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public abstract class Polygon
	{
		public virtual bool CanFindArea => true;
		public abstract double AreaOfFigure { get; }
	}
}
