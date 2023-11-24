namespace Interfaces
{
	public class Workflow
	{
		private List<IActivity> _activities;
		public IEnumerable<IActivity> Activities
		{
			get { return _activities; }
		}

		public Workflow()
		{
			_activities = new List<IActivity>();
		}


		public void RegisterActivity(IActivity activity)
		{
			_activities.Add(activity);
		}
	}
}