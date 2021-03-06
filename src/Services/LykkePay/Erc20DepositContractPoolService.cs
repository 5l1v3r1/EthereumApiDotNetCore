﻿using System.Linq;
using System.Threading.Tasks;
using Autofac.Features.AttributeFilters;
using Common.Log;
using Lykke.Service.EthereumCore.Core;
using Lykke.Service.EthereumCore.Core.Settings;

namespace Lykke.Service.EthereumCore.Services
{
    public class LykkePayErc20DepositContractPoolService : IErc20DepositContractPoolService
    {
        private readonly IErc20DepositContractService _contractService;
        private readonly IErc20DepositContractQueueServiceFactory _poolFactory;
        private readonly IBaseSettings _settings;
        private readonly ILog _log;

        public LykkePayErc20DepositContractPoolService(
            [KeyFilter(Constants.LykkePayKey)]IErc20DepositContractService contractService,
            IErc20DepositContractQueueServiceFactory poolFactory,
            IBaseSettings settings,
            ILog log)
        {
            _contractService = contractService;
            _poolFactory = poolFactory;
            _settings = settings;
            _log = log.CreateComponentScope(nameof(LykkePayErc20DepositContractPoolService));
        }

        public async Task ReplenishPool()
        {
            var pool = _poolFactory.Get(Constants.LykkePayErc20DepositContractPoolQueue);
            var currentCount = await pool.Count();

            if (currentCount < _settings.MinContractPoolLength)
            {
                while (currentCount < _settings.MaxContractPoolLength)
                {
                    var tasks = Enumerable.Range(0, _settings.ContractsPerRequest).Select(x => _contractService.CreateContract());
                    var trHashes = (await Task.WhenAll(tasks)).Where(x => !string.IsNullOrEmpty(x));
                    var contractAddresses = await _contractService.GetContractAddresses(trHashes);

                    await Task.WhenAll(contractAddresses.Select(pool.PushContractAddress));
                    
                    currentCount += _settings.ContractsPerRequest;
                }
            }
        }
    }
}