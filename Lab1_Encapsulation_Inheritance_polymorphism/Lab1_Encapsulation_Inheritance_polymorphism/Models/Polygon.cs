using Lab1_Encapsulation_Inheritance_polymorphism.interfaces;
using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public record Point(double x, double y);

	public abstract class Polygon : IDisposable, IPaintable, IMoveable
	{
		public abstract event Action<Polygon> FigurePainted;
		public abstract event Func<Point, Polygon, bool> FigureMoved;

		public virtual bool CanFindArea => true;
		public abstract double AreaOfFigure { get; }

		public abstract void Paint();

		public abstract void Move(double x, double y);

		// dispose
		private bool disposed = false;
		protected virtual void CleanUp(bool disposing) // in general
		{
			if (!disposed)
			{
				if (disposing)
				{
					//clean managed resources
				}
				// clean unmanaged resources
			}
			disposed = true;
		}
		public virtual void Dispose()
		{
			CleanUp(true);
			GC.SuppressFinalize(this);
		}
		
	}
}
