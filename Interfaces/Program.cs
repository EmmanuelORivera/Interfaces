using System;
namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UseOrders();
			UseLogger();
			UseEmail();
			UseWorkflow();
		}

		static void UseOrders()
		{
			var orderProcessor = new OrderProcessor(new ShippingCalculator());
			var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
			orderProcessor.Process(order);
		}

		static void UseLogger()
		{
			var dbMigrator = new DbMigrator(new ConsoleLogger());
			//var dbMigrator = new DbMigrator(new FileLogger("C:\\Proyectos\\log.txt"));
			dbMigrator.Migrate();
		}

		static void UseEmail()
		{
			var encoder = new VideoEncoder();
			encoder.RegisterNotificationChannel(new MailNotificationChannel());
			encoder.RegisterNotificationChannel(new SmsNotificationChannel());
			encoder.Encode(new Video());
		}
		static void UseWorkflow()
		{
			var workflow = new Workflow();
			workflow.RegisterActivity(new UploadVideoActivity());
			workflow.RegisterActivity(new CallWebServiceActivity());
			workflow.RegisterActivity(new SendEmailActivity());
			workflow.RegisterActivity(new ChangeStatusVideoActivity());

            var workflowEngine = new WorkflowEngine();
			workflowEngine.Run(workflow);
		}
	}
}