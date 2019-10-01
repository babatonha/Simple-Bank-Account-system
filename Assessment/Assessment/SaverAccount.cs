using System;
using System.Collections.Generic;

namespace Assessment
{
	public class SaverAccount : IBankAccount
	{
		private decimal balance;
		private string accHolder;
		private string accType;

		// deposit
		public void PayIn(decimal amount)
		{
			balance += amount;
			
		}

		public bool Withdraw(decimal amount)
		{
			if (balance < 1000)//check to make sure that balance is always above 1000
			{
				Console.WriteLine("Balance should always be above 1000");
			}
			if (balance >= amount)
			{
				balance -= amount;
				return true;
			}
			Console.WriteLine("Withraw Attempt Failed");
			return false;
		}

		
		public decimal Balance
		{
			get { return balance; }
		}

		public override string ToString()
		{
			return string.Format("Test Bank Saver: Balance={0,6:c}", balance);
		}

		//Saver account opening
		public void OpenAccount(string owner, decimal amount, string type)
		{
			accHolder = owner;
			balance = amount;
			accType = type;
			Console.WriteLine("Account for " + accHolder + "is created");
			Console.WriteLine("Initial balance is: " + balance);
			Console.WriteLine("Account type is: " + accType);

		}

		//How to get account history
		public string AccountHistory()
		{
            var report = new System.Text.StringBuilder();
			report.AppendLine("Amount");
			report.AppendLine($"{balance}");
			return report.ToString();
		}
	}
}

