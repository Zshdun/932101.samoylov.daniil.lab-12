namespace lab12.Services
{
	public class CalcService
	{
		public string calc(int firstValue, string operation, int secondValue)
		{
			switch (operation)
			{
				case "+":
					return $"{firstValue} + {secondValue} = " + (firstValue + secondValue);
				case "-":
					return $"{firstValue} - {secondValue} = " + (firstValue - secondValue);
				case "*":
					return $"{firstValue} * {secondValue} = " + (firstValue * secondValue);
				case "/":
					return _division(firstValue, secondValue);
			}

			return "";
		}
		private string _division(int firstValue, int secondValue)
		{
			try
			{
				var divResult = firstValue / secondValue;
				return $"{firstValue} / {secondValue} = " + (firstValue / secondValue);
			}
			catch (DivideByZeroException)
			{
				return "Can not divide by zero";
			}
		}
	}
}
