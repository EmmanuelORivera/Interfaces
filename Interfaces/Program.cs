using System;
namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UseOrders();
			UseLogger();
		}

		static void UseOrders()
		{
			var orderProcessor = new OrderProcessor(new ShippingCalculator());
			var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
			orderProcessor.Process(order);
		}

		static void UseLogger()
		{
			//var dbMigrator = new DbMigrator(new ConsoleLogger());
			var dbMigrator = new DbMigrator(new FileLogger("C:\\Proyectos\\log.txt"));
			dbMigrator.Migrate();
		}
	}
}