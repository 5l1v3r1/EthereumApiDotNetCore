﻿using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Job.EthereumCore.Contracts.Enums.LykkePay;

namespace Lykke.Job.EthereumCore.Contracts.Events.LykkePay
{
    public abstract class Erc20TransferBase
    {
        public DateTime DetectedTime { get; protected set; }
        public string TransactionHash { get; protected set; }
        public string Amount { get; protected set; }
        public string TokenAddress { get; protected set; }
        public string FromAddress { get; protected set; }
        public string ToAddress { get; protected set; }
        public int ConfirmationAmount { get; protected set; }
        public SenderType SenderType { get; protected set; }

        public Erc20TransferBase(string transactionHash,
            string amount,
            string tokenAddress,
            string fromAddress,
            string toAddress,
            int confirmationAmount,
            SenderType senderType)
        {
            DetectedTime = DateTime.UtcNow;
            TransactionHash = transactionHash;
            Amount = amount;
            TokenAddress = tokenAddress;
            FromAddress = fromAddress;
            ToAddress = toAddress;
            ConfirmationAmount = confirmationAmount;
            SenderType = senderType;
        }

    }
}