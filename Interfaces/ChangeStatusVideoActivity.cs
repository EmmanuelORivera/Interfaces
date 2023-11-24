using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal class ChangeStatusVideoActivity : IActivity
	{
		public void Execute()
		{
			Console.WriteLine("Changing the status of the video in the database to: Processing");
		}
	}
}
