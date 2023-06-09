// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>NSX DHCP Server</summary>
    public partial class WorkloadNetworkDhcpServer :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpServer,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpServerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntity __workloadNetworkDhcpEntity = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.WorkloadNetworkDhcpEntity();

        /// <summary>Type of DHCP: SERVER or RELAY.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DhcpTypeEnum DhcpType { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DhcpType; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DhcpType = value ; }

        /// <summary>Display name of the DHCP entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).DisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="LeaseTime" /> property.</summary>
        private long? _leaseTime;

        /// <summary>DHCP Server Lease Time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public long? LeaseTime { get => this._leaseTime; set => this._leaseTime = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkDhcpProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).ProvisioningState = value; }

        /// <summary>Internal Acessors for Segment</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal.Segment { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Segment; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Segment = value; }

        /// <summary>The provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.WorkloadNetworkDhcpProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).ProvisioningState; }

        /// <summary>NSX revision number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public long? Revision { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Revision; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Revision = value ?? default(long); }

        /// <summary>NSX Segments consuming DHCP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string[] Segment { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal)__workloadNetworkDhcpEntity).Segment; }

        /// <summary>Backing field for <see cref="ServerAddress" /> property.</summary>
        private string _serverAddress;

        /// <summary>DHCP Server Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string ServerAddress { get => this._serverAddress; set => this._serverAddress = value; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workloadNetworkDhcpEntity), __workloadNetworkDhcpEntity);
            await eventListener.AssertObjectIsValid(nameof(__workloadNetworkDhcpEntity), __workloadNetworkDhcpEntity);
        }

        /// <summary>Creates an new <see cref="WorkloadNetworkDhcpServer" /> instance.</summary>
        public WorkloadNetworkDhcpServer()
        {

        }
    }
    /// NSX DHCP Server
    public partial interface IWorkloadNetworkDhcpServer :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntity
    {
        /// <summary>DHCP Server Lease Time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DHCP Server Lease Time.",
        SerializedName = @"leaseTime",
        PossibleTypes = new [] { typeof(long) })]
        long? LeaseTime { get; set; }
        /// <summary>DHCP Server Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DHCP Server Address.",
        SerializedName = @"serverAddress",
        PossibleTypes = new [] { typeof(string) })]
        string ServerAddress { get; set; }

    }
    /// NSX DHCP Server
    internal partial interface IWorkloadNetworkDhcpServerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20211201.IWorkloadNetworkDhcpEntityInternal
    {
        /// <summary>DHCP Server Lease Time.</summary>
        long? LeaseTime { get; set; }
        /// <summary>DHCP Server Address.</summary>
        string ServerAddress { get; set; }

    }
}