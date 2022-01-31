using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Sample3App
{
	public static class DateTimeExtensions
	{
		public static int Age(this DateTime birthDate)
		{
			DateTime today = DateTime.Today;

			int age = today.Year - birthDate.Year;

			if (birthDate.Date > today.AddYears(-age)) age--;

			return age;
		}
	}
}
