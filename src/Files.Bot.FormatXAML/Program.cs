// Copyright (c) 2024 Files Community
// Licensed under the MIT License. See the LICENSE.

using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Files.Bot.FormatXAML
{
	public class Program
	{
		static void Main()
		{
			var host = new HostBuilder()
				.ConfigureFunctionsWebApplication()
				.ConfigureServices(services =>
				{
					services.AddApplicationInsightsTelemetryWorkerService();
					services.ConfigureFunctionsApplicationInsights();
				})
				.Build();

			host.Run();
		}
	}
}
