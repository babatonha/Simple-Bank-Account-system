using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
	public interface IBankAccount
	{
		void PayIn(decimal amount);

		bool Withdraw(decimal amount);
		void OpenAccount(string owner, decimal amount, string type);
		decimal Balance
		{
			get;
		}
	}
}
