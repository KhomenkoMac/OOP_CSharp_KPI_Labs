using Lab1_Encapsulation_Inheritance_polymorphism.Models;
using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.interfaces
{
	public interface IMoveable
	{
		event Func<Point, Polygon, bool> FigureMoved;
		void Move(double x, double y);
	}
}
