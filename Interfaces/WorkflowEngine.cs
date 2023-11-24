using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class WorkflowEngine
	{
		public void Run(Workflow workflow)
		{
			var activities = workflow.Activities;

			foreach (var activity in activities)
			{
				activity.Execute();
			}

		}
	}
}
