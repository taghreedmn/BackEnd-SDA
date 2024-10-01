using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FusionTech.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //request
            _logger.LogInformation($"Incoming request: {context.Request.Method}, {context.Request.Path}");

            //measure how long request
            var stopWatch = Stopwatch.StartNew();
            await _next(context);
            stopWatch.Stop();

            //response
            _logger.LogInformation($"Outgoing request: {context.Response.StatusCode}, takes {stopWatch.ElapsedMilliseconds}");
        }




    }
}