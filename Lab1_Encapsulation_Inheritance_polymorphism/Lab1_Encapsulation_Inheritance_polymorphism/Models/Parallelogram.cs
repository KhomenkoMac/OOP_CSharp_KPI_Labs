using Lab1_Encapsulation_Inheritance_polymorphism.interfaces;
using System;
using System.Threading;

namespace Lab1_Encapsulation_Inheritance_polymorphism.Models
{
	public class Parallelogram : Rectangle, IBuildable, IBuildableQuickly, IMoveable
	{
		public Parallelogram(double aSide, double bSide) : base(aSide, bSide) 
		{
			Console.WriteLine($"{nameof(Parallelogram)} -> derived ctor executed");
		}

		public override void Move(int x, int y)
		{
			Console.WriteLine($"{nameof(Parallelogram)} placed into ({x};{y})");
		}


		// implements two interfaces
		//public void Build()
		//{
		//	throw new NotImplementedException();
		//}

		// implementing IBuildable
		public void Build()
		{
			int proggressUpperbound = 100;
			for (int i = 0; i < proggressUpperbound; i += 10)
			{
				Console.WriteLine($"Building triangle {i}% progress");
				Thread.Sleep(2000);
			}
		}

		void IBuildableQuickly.Build()
		{
			int proggressUpperbound = 100;
			for (int i = 0; i < proggressUpperbound; i += 10)
			{
				Console.WriteLine($"Building triangle {i}% progress");
				Thread.Sleep(100);
			}
		}

	}
}
