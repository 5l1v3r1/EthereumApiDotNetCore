// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.EthereumCoreClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateErc20TokenModel
    {
        /// <summary>
        /// Initializes a new instance of the CreateErc20TokenModel class.
        /// </summary>
        public CreateErc20TokenModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateErc20TokenModel class.
        /// </summary>
        public CreateErc20TokenModel(string address = default(string), string name = default(string))
        {
            Address = address;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
