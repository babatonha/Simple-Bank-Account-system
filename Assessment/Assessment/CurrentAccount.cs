using System;

namespace Assessment
{
	public class CurrentAccount :  ITransferAccount 
	{
		private decimal balance;
		private string accHolder;
		private string accType;

		public void PayIn(decimal amount)
		{
			balance += amount;

        }

		public bool Withdraw(decimal amount)
		{
			if (balance >= -100000)// you can withdraw with an overdraft
			{
				balance -= amount;
				return true;
			}
			Console.WriteLine("Withdraw Attempt Failed");
			return false;
		}

		public decimal Balance
		{
			get { return balance; }
		}

		//transfer amount from 
		public bool TransferTo(IBankAccount destination, decimal amount)
		{
			bool result;
			if ((result = Withdraw(amount)) == true)
				destination.PayIn(amount);
			return result;
		}

		public override string ToString()
		{
			return string.Format("Investment Bank Current Account:Balance={0,6:c}", balance);
		}

		//open account 
		public void OpenAccount(string owner, decimal amount, string type)
		{
			if (type == "Current")
			{
				if (amount >= 1000)
				{
					accHolder = owner;
					balance = amount;
					accType = type;

					Console.WriteLine("Account for "+ accHolder + "is created");
					Console.WriteLine("Initial balance is: "+ balance);
					Console.WriteLine("Account type is: " + accType);
				}
			}
		}
		// for this a list can be created of all transactions and fire them here
		public string AccountHistory()
		{
			var report = new System.Text.StringBuilder();

			report.AppendLine("Amount");
			report.AppendLine($"{balance}");
			return report.ToString();

		}
	}
}

