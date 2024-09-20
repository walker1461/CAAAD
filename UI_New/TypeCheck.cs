using System;
using System.Text.RegularExpressions;

namespace TypeCheck
{
	public class TypeChecker
	{
		
		public TypeChecker() { }
		public static string ParseString(string inputString, int maxChars)
		{
			int subLength = 6;
			if (subLength > inputString.Length) subLength = inputString.Length;
			if (inputString.Length > maxChars) throw new ArgumentException(inputString.Substring(0, subLength) + "... must be at most " + maxChars + " characters.");
			return inputString;
		}


		// FUNCTION: Cleans the given string of non-numeric values and returns the cleaned string if the interpreted value is within range.
		//           Intended for use with fields similar to HouseholdSize.
		// THROWS: ArgumentException if the string cannot be converted or interpreted integer is out of range
		public static string ParsePosInt(string inputString, int min, int max)
        {
			Regex rgx = new Regex("[^0-9]");
			string filteredString = rgx.Replace(inputString, "");

			// Try to interpret the string as an integer
			int intValue = 0;
			bool canConvert = int.TryParse(filteredString, out intValue);
			if(canConvert == false)
            {
				int subLength = 6;
				if (subLength > inputString.Length) subLength = inputString.Length;
				throw new ArgumentException(inputString.Substring(0, subLength) + "... must be an integer value");
            }

			// Check the value against the range
			if (min > max)
			{
				int temp = min;
				min = max;
				max = temp;
			}

			if (intValue < min || intValue > max)
			{
				int subLength = 6;
				if (subLength > inputString.Length) subLength = inputString.Length;
				throw new ArgumentException(inputString.Substring(0, subLength) + "... must be between " + min + " and " + max + ".");
            }

			string returnString = intValue.ToString();
			return returnString;
        }


		public static string ParsePosDouble(string inputString, double min, double max)
        {
			Regex rgx = new Regex("[^0-9.]");
			string filteredString = rgx.Replace(inputString, "");

			// Try to interpret the string as a double
			double doubleValue = 0;
			bool canConvert = double.TryParse(filteredString, out doubleValue);
			if(canConvert == false)
            {
				int subLength = 6;
				if (subLength > inputString.Length) subLength = inputString.Length;
				throw new ArgumentException(inputString.Substring(0, subLength) + "... must be an integer or decimal value");
            }

			// Check the value against the range
			if (min > max)
			{
				double temp = min;
				min = max;
				max = temp;
			}

			if (doubleValue < min || doubleValue > max)
			{
				int subLength = 6;
				if (subLength > inputString.Length) subLength = inputString.Length;
				throw new ArgumentException(inputString.Substring(0, subLength) + "... must be between " + min + " and " + max + ".");
			}

			string returnString = doubleValue.ToString();
			return returnString;
        }


		// FUNCTION: Cleans the string of any non-numeric values and checks that the resulting number of digits is as given or less than if specified.
		//           Intended for use with fields such as ZipCode.
		// THROWS: ArgumentException if the cleansed string is not the given number of digits
		public static string ParsePosInt(string inputString, int numDigits, bool isExactly = true)
        {
			Regex rgx = new Regex("[^0-9]");
			string filteredString = rgx.Replace(inputString, "");

			if (isExactly)
			{
				if (filteredString.Length != numDigits)
				{
					int subLength = 6;
					if (subLength > inputString.Length) subLength = inputString.Length;
					throw new ArgumentException(inputString.Substring(0, subLength) + "... must be exactly " + numDigits + " digits.");
				}
			}
			else if (filteredString.Length > numDigits)
            {
				int subLength = 6;
				if (subLength > inputString.Length) subLength = inputString.Length;
				throw new ArgumentException(inputString.Substring(0, subLength) + "... must be at most " + numDigits + " digits.");
			}

			return filteredString;
		}


		// FUNCTION: Cleans and formats the given string from "MM/DD/YYYY" to "DD-MM-YYYY"
		// THROWS: ArgumentException if the string does not contain exactly 8 numeric values
		public static string ParseDate(string inputString)
        {
			// Remove non-numeric characters
			Regex rgx = new Regex("[^0-9/_-]");
			string filteredString = rgx.Replace(inputString, "");
			if (filteredString.Length < 6) throw new ArgumentException("Invalid date");

			// Separate MM, DD, YYYY and make sure they are minimum length by prefixing
			string[] splitVal = filteredString.Split(new char[] { '/', '-', '_' });
			if (splitVal.Length < 3) throw new ArgumentException("Invalid date");
			while (splitVal[0].Length < 2) splitVal[0] = "0" + splitVal[0];
			while (splitVal[1].Length < 2) splitVal[1] = "0" + splitVal[1];
			while (splitVal[2].Length < 4) splitVal[2] = "0" + splitVal[2];

			if (splitVal[0] == "00" || splitVal[1] == "00" || splitVal[2] == "0000") throw new ArgumentException("Invalid date");

			string returnString = splitVal[2] + "-" + splitVal[0] + "-" + splitVal[1];
			Console.WriteLine(returnString);
			if (returnString.Length != 10) throw new ArgumentException("Date must be in MM/DD/YYYY format");

			return returnString;
        }
	}
}
