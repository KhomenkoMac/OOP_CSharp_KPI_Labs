using Lab1_Encapsulation_Inheritance_polymorphism.interfaces;
using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public abstract class Polygon : IDisposable, IPaintable, IMoveable
	{
		public virtual bool CanFindArea => true;
		public abstract double AreaOfFigure { get; }

		public abstract void Paint();

		public abstract void Move(int x, int y);

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
