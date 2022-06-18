using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.web.Models
{
    public class DateService : ISignletonDateService, IScopeDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning("It Works!");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
