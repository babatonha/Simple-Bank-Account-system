using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
	public interface ITransferAccount : IBankAccount
	{

		bool TransferTo(IBankAccount destination, decimal amount);
        string AccountHistory();

    }
}
