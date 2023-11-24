using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class MailService
	{
		public void Send(Mail mail)
		{
            Console.WriteLine("Sending email...");
        }
	}
}
