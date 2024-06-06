// Copyright (c) 2024 Files Community
// Licensed under the MIT License. See the LICENSE.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Files.Bot.FormatXAML
{
	public class Function1
	{
		private readonly ILogger<Function1> _logger;

		public Function1(ILogger<Function1> logger)
		{
			_logger = logger;
		}

		[Function("Function1")]
		public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
		{
			_logger.LogInformation("C# HTTP trigger function processed a request.");
			return new OkObjectResult("Welcome to Azure Functions!");
		}
	}
}
