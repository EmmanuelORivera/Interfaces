using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class CallWebServiceActivity : IActivity
	{
		public void Execute()
		{
            Console.WriteLine("Web service called: Video is ready for encoding.");
        }
	}
}
