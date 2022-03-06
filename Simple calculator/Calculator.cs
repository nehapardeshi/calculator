using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
	public class Calculator
	{
		public decimal Sum(decimal a, decimal b)
		{
			return a+b;
		}
		public decimal Difference(decimal a, decimal b)
		{
			return a-b;
		}
		public decimal Multiply(decimal a, decimal b)
		{
			return a*b;
		}
		public decimal Divide(decimal a, decimal b)
		{
			return a/b;
		}
		public decimal Mod(decimal a, decimal b)
		{
			return a%b;
		}
	}
}
