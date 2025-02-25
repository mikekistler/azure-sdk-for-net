// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> The updatable properties of a Fluid Relay server. </summary>
    public partial class FluidRelayServerPatch
    {
        /// <summary> Initializes a new instance of FluidRelayServerPatch. </summary>
        public FluidRelayServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The type of identity used for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> All encryption configuration for a resource. </summary>
        internal EncryptionProperties Encryption { get; set; }
        /// <summary> All Customer-managed key encryption properties for the resource. </summary>
        public CustomerManagedKeyEncryptionProperties CustomerManagedKeyEncryption
        {
            get => Encryption is null ? default : Encryption.CustomerManagedKeyEncryption;
            set
            {
                if (Encryption is null)
                    Encryption = new EncryptionProperties();
                Encryption.CustomerManagedKeyEncryption = value;
            }
        }
    }
}
