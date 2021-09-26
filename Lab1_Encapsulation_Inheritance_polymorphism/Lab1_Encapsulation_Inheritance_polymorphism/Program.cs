using Lab1_Encapsulation_Inheritance_polymorphism.Models;
using System.Collections;
using System.Threading;

namespace Lab1_Encapsulation_Inheritance_polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			// demonstrating the order call of ctors
			Square square = new(5);

			// demonstrating the deliberate GC collection
			ArrayList arrayList = new(); // showing life time of instance
			for (int i = 0; i < 1_000_000; i++)
			{
				Rectangle r = new(5, 4);
				arrayList.Add(r);
				arrayList[i] = null;
			}

			for (int i = 0; i < 500_000; i++)
			{
				arrayList.Add(new object());
				arrayList[i] = null;
			}
			Thread.Sleep(10000);
		}
	}
}
