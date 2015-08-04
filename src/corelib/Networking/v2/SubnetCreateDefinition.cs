﻿using Newtonsoft.Json;

namespace OpenStack.Networking.v2
{
    /// <summary>
    /// Represents the definition of a subnet resource when creating a new subnet.
    /// </summary>
    /// <threadsafety static="true" instance="false"/>
    public class SubnetCreateDefinition : SubnetUpdateDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubnetCreateDefinition"/> class.
        /// </summary>
        protected SubnetCreateDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubnetCreateDefinition"/> class.
        /// </summary>
        /// <param name="networkId">The network identifier.</param>
        /// <param name="ipVersion">The ip version.</param>
        /// <param name="cidr">The cidr.</param>
        public SubnetCreateDefinition(Identifier networkId, IPVersion ipVersion, string cidr)
        {
            NetworkId = networkId;
            IPVersion = ipVersion;
            CIDR = cidr;
        }

        /// <summary>
        /// The ID of the attached network.
        /// </summary>
        [JsonProperty("network_id")]
        public Identifier NetworkId { get; set; }

        /// <summary>
        /// The IP version.
        /// </summary>
        [JsonProperty("ip_version")]
        public IPVersion IPVersion { get; set; }

        /// <summary>
        /// The CIDR.
        /// </summary>
        [JsonProperty("cidr")]
        public string CIDR { get; set; }
    }
}