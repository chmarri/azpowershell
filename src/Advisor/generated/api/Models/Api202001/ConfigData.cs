// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Extensions;

    /// <summary>The Advisor configuration data structure.</summary>
    public partial class ConfigData :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigData,
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.Resource();

        /// <summary>Advisor digest configuration. Valid only for subscriptions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig[] Digest { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataPropertiesInternal)Property).Digest; set => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataPropertiesInternal)Property).Digest = value ?? null /* arrayOf */; }

        /// <summary>
        /// Exclude the resource from Advisor evaluations. Valid values: False (default) or True.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.FormatTable(Index = 1)]
        public bool? Exclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataPropertiesInternal)Property).Exclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataPropertiesInternal)Property).Exclude = value ?? default(bool); }

        /// <summary>The resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Id; }

        /// <summary>
        /// Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5
        /// (default), 10, 15 or 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.FormatTable(Index = 2)]
        public Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold? LowCpuThreshold { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataPropertiesInternal)Property).LowCpuThreshold; set => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataPropertiesInternal)Property).LowCpuThreshold = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold)""); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataProperties Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.ConfigDataProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataProperties _property;

        /// <summary>The Advisor configuration data structure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.ConfigDataProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Origin(Microsoft.Azure.PowerShell.Cmdlets.Advisor.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ConfigData" /> instance.</summary>
        public ConfigData()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The Advisor configuration data structure.
    public partial interface IConfigData :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResource
    {
        /// <summary>Advisor digest configuration. Valid only for subscriptions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Advisor digest configuration. Valid only for subscriptions",
        SerializedName = @"digests",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig) })]
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig[] Digest { get; set; }
        /// <summary>
        /// Exclude the resource from Advisor evaluations. Valid values: False (default) or True.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Exclude the resource from Advisor evaluations. Valid values: False (default) or True.",
        SerializedName = @"exclude",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Exclude { get; set; }
        /// <summary>
        /// Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5
        /// (default), 10, 15 or 20.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Advisor.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5 (default), 10, 15 or 20.",
        SerializedName = @"lowCpuThreshold",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold) })]
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold? LowCpuThreshold { get; set; }

    }
    /// The Advisor configuration data structure.
    internal partial interface IConfigDataInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IResourceInternal
    {
        /// <summary>Advisor digest configuration. Valid only for subscriptions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IDigestConfig[] Digest { get; set; }
        /// <summary>
        /// Exclude the resource from Advisor evaluations. Valid values: False (default) or True.
        /// </summary>
        bool? Exclude { get; set; }
        /// <summary>
        /// Minimum percentage threshold for Advisor low CPU utilization evaluation. Valid only for subscriptions. Valid values: 5
        /// (default), 10, 15 or 20.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Support.CpuThreshold? LowCpuThreshold { get; set; }
        /// <summary>The Advisor configuration data structure.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Advisor.Models.Api202001.IConfigDataProperties Property { get; set; }

    }
}