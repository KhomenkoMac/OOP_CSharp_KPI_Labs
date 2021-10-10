using System;

namespace Lab1_Encapsulation_Inheritance_polymorphism.ExceptionHierarchy
{

	public record FigureNotMovedExceptionArgs(string Message, Exception InnerException);

	public class FigureNotMovedException : ApplicationException
	{
		public FigureNotMovedException() : base()
		{

		}

		public FigureNotMovedException(string message) : base(message)
		{
			
		}

		public FigureNotMovedException(string message, Exception innerException) : base(message, innerException)
		{

		}

		public FigureNotMovedException(FigureNotMovedExceptionArgs arg) : base(arg.Message, arg.InnerException)
		{

		}
	}
}
