// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.EthereumCore.Client.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExceptionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExceptionType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "ContractPoolEmpty")]
        ContractPoolEmpty,
        [EnumMember(Value = "MissingRequiredParams")]
        MissingRequiredParams,
        [EnumMember(Value = "WrongParams")]
        WrongParams,
        [EnumMember(Value = "EntityAlreadyExists")]
        EntityAlreadyExists,
        [EnumMember(Value = "WrongSign")]
        WrongSign,
        [EnumMember(Value = "OperationWithIdAlreadyExists")]
        OperationWithIdAlreadyExists,
        [EnumMember(Value = "TransferInProcessing")]
        TransferInProcessing,
        [EnumMember(Value = "WrongDestination")]
        WrongDestination,
        [EnumMember(Value = "CantEstimateExecution")]
        CantEstimateExecution,
        [EnumMember(Value = "NotEnoughFunds")]
        NotEnoughFunds,
        [EnumMember(Value = "TransactionExists")]
        TransactionExists,
        [EnumMember(Value = "TransactionRequiresMoreGas")]
        TransactionRequiresMoreGas
    }
    internal static class ExceptionTypeEnumExtension
    {
        internal static string ToSerializedValue(this ExceptionType? value)
        {
            return value == null ? null : ((ExceptionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ExceptionType value)
        {
            switch( value )
            {
                case ExceptionType.None:
                    return "None";
                case ExceptionType.ContractPoolEmpty:
                    return "ContractPoolEmpty";
                case ExceptionType.MissingRequiredParams:
                    return "MissingRequiredParams";
                case ExceptionType.WrongParams:
                    return "WrongParams";
                case ExceptionType.EntityAlreadyExists:
                    return "EntityAlreadyExists";
                case ExceptionType.WrongSign:
                    return "WrongSign";
                case ExceptionType.OperationWithIdAlreadyExists:
                    return "OperationWithIdAlreadyExists";
                case ExceptionType.TransferInProcessing:
                    return "TransferInProcessing";
                case ExceptionType.WrongDestination:
                    return "WrongDestination";
                case ExceptionType.CantEstimateExecution:
                    return "CantEstimateExecution";
                case ExceptionType.NotEnoughFunds:
                    return "NotEnoughFunds";
                case ExceptionType.TransactionExists:
                    return "TransactionExists";
                case ExceptionType.TransactionRequiresMoreGas:
                    return "TransactionRequiresMoreGas";
            }
            return null;
        }

        internal static ExceptionType? ParseExceptionType(this string value)
        {
            switch( value )
            {
                case "None":
                    return ExceptionType.None;
                case "ContractPoolEmpty":
                    return ExceptionType.ContractPoolEmpty;
                case "MissingRequiredParams":
                    return ExceptionType.MissingRequiredParams;
                case "WrongParams":
                    return ExceptionType.WrongParams;
                case "EntityAlreadyExists":
                    return ExceptionType.EntityAlreadyExists;
                case "WrongSign":
                    return ExceptionType.WrongSign;
                case "OperationWithIdAlreadyExists":
                    return ExceptionType.OperationWithIdAlreadyExists;
                case "TransferInProcessing":
                    return ExceptionType.TransferInProcessing;
                case "WrongDestination":
                    return ExceptionType.WrongDestination;
                case "CantEstimateExecution":
                    return ExceptionType.CantEstimateExecution;
                case "NotEnoughFunds":
                    return ExceptionType.NotEnoughFunds;
                case "TransactionExists":
                    return ExceptionType.TransactionExists;
                case "TransactionRequiresMoreGas":
                    return ExceptionType.TransactionRequiresMoreGas;
            }
            return null;
        }
    }
}
