using Lab1_Encapsulation_Inheritance_polymorphism.Models;
using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.interfaces
{
	public interface IPaintable
	{
		event Action<Polygon> FigurePainted;
		void Paint();
	}
}
