using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public abstract class Polygon : IDisposable
	{
		public virtual bool CanFindArea => true;
		public abstract double AreaOfFigure { get; }

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
