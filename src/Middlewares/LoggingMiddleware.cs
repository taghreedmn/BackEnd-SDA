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
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // request
            _logger.LogInformation($"Incoming request: {context.Request.Method} , {context.Request.Path}");
            // how long request
            var stopwatch = Stopwatch.StartNew();
            // server 
            await _next(context);
            stopwatch.Stop();
            // response
            _logger.LogInformation($"Outgoing request: {context.Response.StatusCode} takes ({stopwatch.ElapsedMilliseconds}ms)");

        }


    }
}