// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A common class for general resource information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        public VirtualNetworkGatewayConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        /// <param name="virtualNetworkGateway1">The reference to virtual
        /// network gateway resource.</param>
        /// <param name="connectionType">Gateway connection type. Possible
        /// values include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute',
        /// 'VPNClient'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="authorizationKey">The authorizationKey.</param>
        /// <param name="virtualNetworkGateway2">The reference to virtual
        /// network gateway resource.</param>
        /// <param name="localNetworkGateway2">The reference to local network
        /// gateway resource.</param>
        /// <param name="ingressNatRules">List of ingress NatRules.</param>
        /// <param name="egressNatRules">List of egress NatRules.</param>
        /// <param name="connectionProtocol">Connection protocol used for this
        /// connection. Possible values include: 'IKEv2', 'IKEv1'</param>
        /// <param name="routingWeight">The routing weight.</param>
        /// <param name="dpdTimeoutSeconds">The dead peer detection timeout of
        /// this connection in seconds.</param>
        /// <param name="connectionMode">The connection mode for this
        /// connection. Possible values include: 'Default', 'ResponderOnly',
        /// 'InitiatorOnly'</param>
        /// <param name="sharedKey">The IPSec shared key.</param>
        /// <param name="connectionStatus">Virtual Network Gateway connection
        /// status. Possible values include: 'Unknown', 'Connecting',
        /// 'Connected', 'NotConnected'</param>
        /// <param name="tunnelConnectionStatus">Collection of all tunnels'
        /// connection health status.</param>
        /// <param name="egressBytesTransferred">The egress bytes transferred
        /// in this connection.</param>
        /// <param name="ingressBytesTransferred">The ingress bytes transferred
        /// in this connection.</param>
        /// <param name="peer">The reference to peerings resource.</param>
        /// <param name="enableBgp">EnableBgp flag.</param>
        /// <param
        /// name="gatewayCustomBgpIpAddresses">GatewayCustomBgpIpAddresses to
        /// be used for virtual network gateway Connection.</param>
        /// <param name="useLocalAzureIpAddress">Use private local Azure IP for
        /// the connection.</param>
        /// <param name="usePolicyBasedTrafficSelectors">Enable policy-based
        /// traffic selectors.</param>
        /// <param name="ipsecPolicies">The IPSec Policies to be considered by
        /// this connection.</param>
        /// <param name="trafficSelectorPolicies">The Traffic Selector Policies
        /// to be considered by this connection.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// virtual network gateway connection resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// virtual network gateway connection resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="expressRouteGatewayBypass">Bypass ExpressRoute Gateway
        /// for data forwarding.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VirtualNetworkGatewayConnection(VirtualNetworkGateway virtualNetworkGateway1, string connectionType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string authorizationKey = default(string), VirtualNetworkGateway virtualNetworkGateway2 = default(VirtualNetworkGateway), LocalNetworkGateway localNetworkGateway2 = default(LocalNetworkGateway), IList<SubResource> ingressNatRules = default(IList<SubResource>), IList<SubResource> egressNatRules = default(IList<SubResource>), string connectionProtocol = default(string), int? routingWeight = default(int?), int? dpdTimeoutSeconds = default(int?), string connectionMode = default(string), string sharedKey = default(string), string connectionStatus = default(string), IList<TunnelConnectionHealth> tunnelConnectionStatus = default(IList<TunnelConnectionHealth>), long? egressBytesTransferred = default(long?), long? ingressBytesTransferred = default(long?), SubResource peer = default(SubResource), bool? enableBgp = default(bool?), IList<GatewayCustomBgpIpAddressIpConfiguration> gatewayCustomBgpIpAddresses = default(IList<GatewayCustomBgpIpAddressIpConfiguration>), bool? useLocalAzureIpAddress = default(bool?), bool? usePolicyBasedTrafficSelectors = default(bool?), IList<IpsecPolicy> ipsecPolicies = default(IList<IpsecPolicy>), IList<TrafficSelectorPolicy> trafficSelectorPolicies = default(IList<TrafficSelectorPolicy>), string resourceGuid = default(string), string provisioningState = default(string), bool? expressRouteGatewayBypass = default(bool?), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            IngressNatRules = ingressNatRules;
            EgressNatRules = egressNatRules;
            ConnectionType = connectionType;
            ConnectionProtocol = connectionProtocol;
            RoutingWeight = routingWeight;
            DpdTimeoutSeconds = dpdTimeoutSeconds;
            ConnectionMode = connectionMode;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            TunnelConnectionStatus = tunnelConnectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            GatewayCustomBgpIpAddresses = gatewayCustomBgpIpAddresses;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            TrafficSelectorPolicies = trafficSelectorPolicies;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            ExpressRouteGatewayBypass = expressRouteGatewayBypass;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the authorizationKey.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// Gets or sets the reference to virtual network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway1")]
        public VirtualNetworkGateway VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// Gets or sets the reference to virtual network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway2")]
        public VirtualNetworkGateway VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets the reference to local network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkGateway2")]
        public LocalNetworkGateway LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets list of ingress NatRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressNatRules")]
        public IList<SubResource> IngressNatRules { get; set; }

        /// <summary>
        /// Gets or sets list of egress NatRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressNatRules")]
        public IList<SubResource> EgressNatRules { get; set; }

        /// <summary>
        /// Gets or sets gateway connection type. Possible values include:
        /// 'IPsec', 'Vnet2Vnet', 'ExpressRoute', 'VPNClient'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets connection protocol used for this connection. Possible
        /// values include: 'IKEv2', 'IKEv1'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionProtocol")]
        public string ConnectionProtocol { get; set; }

        /// <summary>
        /// Gets or sets the routing weight.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets the dead peer detection timeout of this connection in
        /// seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dpdTimeoutSeconds")]
        public int? DpdTimeoutSeconds { get; set; }

        /// <summary>
        /// Gets or sets the connection mode for this connection. Possible
        /// values include: 'Default', 'ResponderOnly', 'InitiatorOnly'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionMode")]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// Gets or sets the IPSec shared key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets virtual Network Gateway connection status. Possible values
        /// include: 'Unknown', 'Connecting', 'Connected', 'NotConnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; private set; }

        /// <summary>
        /// Gets collection of all tunnels' connection health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tunnelConnectionStatus")]
        public IList<TunnelConnectionHealth> TunnelConnectionStatus { get; private set; }

        /// <summary>
        /// Gets the egress bytes transferred in this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets the ingress bytes transferred in this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets or sets the reference to peerings resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peer")]
        public SubResource Peer { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets gatewayCustomBgpIpAddresses to be used for virtual
        /// network gateway Connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayCustomBgpIpAddresses")]
        public IList<GatewayCustomBgpIpAddressIpConfiguration> GatewayCustomBgpIpAddresses { get; set; }

        /// <summary>
        /// Gets or sets use private local Azure IP for the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.useLocalAzureIpAddress")]
        public bool? UseLocalAzureIpAddress { get; set; }

        /// <summary>
        /// Gets or sets enable policy-based traffic selectors.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usePolicyBasedTrafficSelectors")]
        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        /// <summary>
        /// Gets or sets the IPSec Policies to be considered by this
        /// connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsecPolicies")]
        public IList<IpsecPolicy> IpsecPolicies { get; set; }

        /// <summary>
        /// Gets or sets the Traffic Selector Policies to be considered by this
        /// connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficSelectorPolicies")]
        public IList<TrafficSelectorPolicy> TrafficSelectorPolicies { get; set; }

        /// <summary>
        /// Gets the resource GUID property of the virtual network gateway
        /// connection resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the virtual network gateway
        /// connection resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets bypass ExpressRoute Gateway for data forwarding.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteGatewayBypass")]
        public bool? ExpressRouteGatewayBypass { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkGateway1 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetworkGateway1");
            }
            if (ConnectionType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionType");
            }
            if (VirtualNetworkGateway1 != null)
            {
                VirtualNetworkGateway1.Validate();
            }
            if (VirtualNetworkGateway2 != null)
            {
                VirtualNetworkGateway2.Validate();
            }
            if (LocalNetworkGateway2 != null)
            {
                LocalNetworkGateway2.Validate();
            }
            if (GatewayCustomBgpIpAddresses != null)
            {
                foreach (var element in GatewayCustomBgpIpAddresses)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (IpsecPolicies != null)
            {
                foreach (var element1 in IpsecPolicies)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (TrafficSelectorPolicies != null)
            {
                foreach (var element2 in TrafficSelectorPolicies)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
