﻿using System.Threading.Tasks;

namespace Lykke.Service.EthereumCore.Services
{
    public interface IErc20DepositContractQueueService
    {
        Task<string> GetContractAddress();

        Task PushContractAddress(string contractAddress);

        Task<int> Count();
    }
}