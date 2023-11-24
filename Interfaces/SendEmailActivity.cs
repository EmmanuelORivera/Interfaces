using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class SendEmailActivity : IActivity
	{
		public void Execute()
		{
            Console.WriteLine("Sending an email to the owner: The video started processing");
        }
	}
}
