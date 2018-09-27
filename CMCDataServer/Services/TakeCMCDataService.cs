using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CMCDataServer.Services
{
    public class TakeCMCDataService : BackgroundService
    {
        private readonly ILogger<TakeCMCDataService> _logger;
        readonly CMCDataSettings _settings;


        public TakeCMCDataService(IOptions<CMCDataSettings> settings,
                                  ILogger<TakeCMCDataService> logger)
        {

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug($"GracePeriodManagerService is starting.");

            stoppingToken.Register(() =>
                    _logger.LogDebug($" GracePeriod background task is stopping."));

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogDebug($"GracePeriod task doing background work.");

                // Taking API Data form CMC ones in 30 sec and writing main data in DB
                CheckConfirmedGracePeriodOrders();

                await Task.Delay(_settings.CMCDelay, stoppingToken);
            }

            _logger.LogDebug($"GracePeriod background task is stopping.");

        }

        protected override async Task StopAsync(CancellationToken stoppingToken)
        {
            // Run your graceful clean-up actions
        }
    }

    public class CMCDataSettings
    {
        int cmc_delay;

        public int CMCDelay { get => cmc_delay; set => cmc_delay = value; }

        public CMCDataSettings()
        {
            // Set default value in ms.
            CMCDelay = 30000; //30s=30000ms
        }

    }

}
