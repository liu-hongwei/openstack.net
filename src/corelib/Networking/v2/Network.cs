﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenStack.Networking.v2
{
    /// <summary>
    /// Represents a network resource of the <see cref="NetworkingService"/>
    /// <para>
    /// Isolated virtual Layer-2 domains; a network can also be regarded as a virtual (or logical) switch.
    /// </para>
    /// </summary>
    /// <threadsafety static="true" instance="false"/>
    public class Network : NetworkDefinition
    {
        /// <summary>
        /// The network identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The administrative state of the network.
        /// </summary>
        [JsonProperty("admin_state_up")]
        public bool IsUp { get; set; }

        /// <summary>
        /// The tenant identifier.
        /// </summary>
        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// Indicates whether this network is shared across all tenants.
        /// </summary>
        [JsonProperty("shared")]
        public bool IsShared { get; set; }

        /// <summary>
        /// The network status.
        /// </summary>
        [JsonProperty("status")]
        public NetworkStatus Status { get; set; }

        /// <summary>
        /// The associated subnet identifiers.
        /// </summary>
        [JsonProperty("subnets")]
        public IList<Identifier> Subnets { get; set; } 
    }
}