// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>ContainerApp resource specific properties</summary>
    public partial class ContainerAppProperties :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppProperties,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfiguration _configuration;

        /// <summary>Non versioned Container App configuration properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfiguration Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.Configuration()); set => this._configuration = value; }

        /// <summary>
        /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
        /// <list><item>Multiple: multiple revisions can be active.</item><item>Single: Only one revision can be active at a time.
        /// Revision weights can not be used in this mode. If no value if provided, this is the default.</item></list>
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.ActiveRevisionsMode? ConfigurationActiveRevisionsMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).ActiveRevisionsMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).ActiveRevisionsMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.App.Support.ActiveRevisionsMode)""); }

        /// <summary>
        /// Collection of private container registry credentials for containers used by the Container app
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IRegistryCredentials[] ConfigurationRegistry { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Registry; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Registry = value ?? null /* arrayOf */; }

        /// <summary>Collection of secrets used by a Container app</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ISecret[] ConfigurationSecret { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Secret; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Secret = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="CustomDomainVerificationId" /> property.</summary>
        private string _customDomainVerificationId;

        /// <summary>Id used to verify domain name ownership</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string CustomDomainVerificationId { get => this._customDomainVerificationId; }

        /// <summary>Dapr application identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string DaprAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprAppId = value ?? null; }

        /// <summary>Tells Dapr which port your application is listening on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public int? DaprAppPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprAppPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprAppPort = value ?? default(int); }

        /// <summary>
        /// Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? DaprAppProtocol { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprAppProtocol; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprAppProtocol = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol)""); }

        /// <summary>Boolean indicating if the Dapr side car is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public bool? DaprEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).DaprEnabled = value ?? default(bool); }

        /// <summary>
        /// Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS
        /// connections
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public bool? IngressAllowInsecure { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressAllowInsecure; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressAllowInsecure = value ?? default(bool); }

        /// <summary>custom domain bindings for Container Apps' hostnames.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain[] IngressCustomDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressCustomDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressCustomDomain = value ?? null /* arrayOf */; }

        /// <summary>Bool indicating if app exposes an external http endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public bool? IngressExternal { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressExternal; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressExternal = value ?? default(bool); }

        /// <summary>Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string IngressFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressFqdn; }

        /// <summary>Target Port in containers for traffic from ingress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public int? IngressTargetPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressTargetPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressTargetPort = value ?? default(int); }

        /// <summary>Traffic weights for app's revisions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITrafficWeight[] IngressTraffic { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressTraffic; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressTraffic = value ?? null /* arrayOf */; }

        /// <summary>Ingress transport protocol</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.IngressTransportMethod? IngressTransport { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressTransport; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressTransport = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.App.Support.IngressTransportMethod)""); }

        /// <summary>Backing field for <see cref="LatestRevisionFqdn" /> property.</summary>
        private string _latestRevisionFqdn;

        /// <summary>Fully Qualified Domain Name of the latest revision of the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string LatestRevisionFqdn { get => this._latestRevisionFqdn; }

        /// <summary>Backing field for <see cref="LatestRevisionName" /> property.</summary>
        private string _latestRevisionName;

        /// <summary>Name of the latest revision of the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string LatestRevisionName { get => this._latestRevisionName; }

        /// <summary>Backing field for <see cref="ManagedEnvironmentId" /> property.</summary>
        private string _managedEnvironmentId;

        /// <summary>Resource ID of the Container App's environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string ManagedEnvironmentId { get => this._managedEnvironmentId; set => this._managedEnvironmentId = value; }

        /// <summary>Internal Acessors for Configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfiguration Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.Configuration()); set { {_configuration = value;} } }

        /// <summary>Internal Acessors for ConfigurationDapr</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDapr Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.ConfigurationDapr { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Dapr; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Dapr = value; }

        /// <summary>Internal Acessors for ConfigurationIngress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IIngress Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.ConfigurationIngress { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Ingress; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).Ingress = value; }

        /// <summary>Internal Acessors for CustomDomainVerificationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.CustomDomainVerificationId { get => this._customDomainVerificationId; set { {_customDomainVerificationId = value;} } }

        /// <summary>Internal Acessors for IngressFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.IngressFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfigurationInternal)Configuration).IngressFqdn = value; }

        /// <summary>Internal Acessors for LatestRevisionFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.LatestRevisionFqdn { get => this._latestRevisionFqdn; set { {_latestRevisionFqdn = value;} } }

        /// <summary>Internal Acessors for LatestRevisionName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.LatestRevisionName { get => this._latestRevisionName; set { {_latestRevisionName = value;} } }

        /// <summary>Internal Acessors for OutboundIPAddress</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.OutboundIPAddress { get => this._outboundIPAddress; set { {_outboundIPAddress = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.ContainerAppProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Template</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplate Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.Template { get => (this._template = this._template ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.Template()); set { {_template = value;} } }

        /// <summary>Internal Acessors for TemplateScale</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScale Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainerAppPropertiesInternal.TemplateScale { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).Scale; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).Scale = value; }

        /// <summary>Backing field for <see cref="OutboundIPAddress" /> property.</summary>
        private string[] _outboundIPAddress;

        /// <summary>Outbound IP Addresses for container app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string[] OutboundIPAddress { get => this._outboundIPAddress; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Support.ContainerAppProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Support.ContainerAppProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Optional. Maximum number of container replicas. Defaults to 10 if not set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public int? ScaleMaxReplica { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).ScaleMaxReplica; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).ScaleMaxReplica = value ?? default(int); }

        /// <summary>Optional. Minimum number of container replicas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public int? ScaleMinReplica { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).ScaleMinReplica; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).ScaleMinReplica = value ?? default(int); }

        /// <summary>Scaling rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRule[] ScaleRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).ScaleRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).ScaleRule = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplate _template;

        /// <summary>Container App versioned application definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplate Template { get => (this._template = this._template ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.Template()); set => this._template = value; }

        /// <summary>List of container definitions for the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainer[] TemplateContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).Container; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).Container = value ?? null /* arrayOf */; }

        /// <summary>User friendly suffix that is appended to the revision name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string TemplateRevisionSuffix { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).RevisionSuffix; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).RevisionSuffix = value ?? null; }

        /// <summary>List of volume definitions for the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVolume[] TemplateVolume { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).Volume; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplateInternal)Template).Volume = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ContainerAppProperties" /> instance.</summary>
        public ContainerAppProperties()
        {

        }
    }
    /// ContainerApp resource specific properties
    public partial interface IContainerAppProperties :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>
        /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
        /// <list><item>Multiple: multiple revisions can be active.</item><item>Single: Only one revision can be active at a time.
        /// Revision weights can not be used in this mode. If no value if provided, this is the default.</item></list>
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ActiveRevisionsMode controls how active revisions are handled for the Container app:
        <list><item>Multiple: multiple revisions can be active.</item><item>Single: Only one revision can be active at a time. Revision weights can not be used in this mode. If no value if provided, this is the default.</item></list>",
        SerializedName = @"activeRevisionsMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Support.ActiveRevisionsMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.ActiveRevisionsMode? ConfigurationActiveRevisionsMode { get; set; }
        /// <summary>
        /// Collection of private container registry credentials for containers used by the Container app
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of private container registry credentials for containers used by the Container app",
        SerializedName = @"registries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IRegistryCredentials) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IRegistryCredentials[] ConfigurationRegistry { get; set; }
        /// <summary>Collection of secrets used by a Container app</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection of secrets used by a Container app",
        SerializedName = @"secrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ISecret) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ISecret[] ConfigurationSecret { get; set; }
        /// <summary>Id used to verify domain name ownership</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Id used to verify domain name ownership",
        SerializedName = @"customDomainVerificationId",
        PossibleTypes = new [] { typeof(string) })]
        string CustomDomainVerificationId { get;  }
        /// <summary>Dapr application identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Dapr application identifier",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string DaprAppId { get; set; }
        /// <summary>Tells Dapr which port your application is listening on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells Dapr which port your application is listening on",
        SerializedName = @"appPort",
        PossibleTypes = new [] { typeof(int) })]
        int? DaprAppPort { get; set; }
        /// <summary>
        /// Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http",
        SerializedName = @"appProtocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? DaprAppProtocol { get; set; }
        /// <summary>Boolean indicating if the Dapr side car is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean indicating if the Dapr side car is enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DaprEnabled { get; set; }
        /// <summary>
        /// Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS
        /// connections
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS connections",
        SerializedName = @"allowInsecure",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IngressAllowInsecure { get; set; }
        /// <summary>custom domain bindings for Container Apps' hostnames.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"custom domain bindings for Container Apps' hostnames.",
        SerializedName = @"customDomains",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain[] IngressCustomDomain { get; set; }
        /// <summary>Bool indicating if app exposes an external http endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Bool indicating if app exposes an external http endpoint",
        SerializedName = @"external",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IngressExternal { get; set; }
        /// <summary>Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Hostname.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string IngressFqdn { get;  }
        /// <summary>Target Port in containers for traffic from ingress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target Port in containers for traffic from ingress",
        SerializedName = @"targetPort",
        PossibleTypes = new [] { typeof(int) })]
        int? IngressTargetPort { get; set; }
        /// <summary>Traffic weights for app's revisions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Traffic weights for app's revisions",
        SerializedName = @"traffic",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITrafficWeight) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITrafficWeight[] IngressTraffic { get; set; }
        /// <summary>Ingress transport protocol</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ingress transport protocol",
        SerializedName = @"transport",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Support.IngressTransportMethod) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.IngressTransportMethod? IngressTransport { get; set; }
        /// <summary>Fully Qualified Domain Name of the latest revision of the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully Qualified Domain Name of the latest revision of the Container App.",
        SerializedName = @"latestRevisionFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string LatestRevisionFqdn { get;  }
        /// <summary>Name of the latest revision of the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the latest revision of the Container App.",
        SerializedName = @"latestRevisionName",
        PossibleTypes = new [] { typeof(string) })]
        string LatestRevisionName { get;  }
        /// <summary>Resource ID of the Container App's environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID of the Container App's environment.",
        SerializedName = @"managedEnvironmentId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedEnvironmentId { get; set; }
        /// <summary>Outbound IP Addresses for container app.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Outbound IP Addresses for container app.",
        SerializedName = @"outboundIPAddresses",
        PossibleTypes = new [] { typeof(string) })]
        string[] OutboundIPAddress { get;  }
        /// <summary>Provisioning state of the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the Container App.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Support.ContainerAppProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.ContainerAppProvisioningState? ProvisioningState { get;  }
        /// <summary>Optional. Maximum number of container replicas. Defaults to 10 if not set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. Maximum number of container replicas. Defaults to 10 if not set.",
        SerializedName = @"maxReplicas",
        PossibleTypes = new [] { typeof(int) })]
        int? ScaleMaxReplica { get; set; }
        /// <summary>Optional. Minimum number of container replicas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional. Minimum number of container replicas.",
        SerializedName = @"minReplicas",
        PossibleTypes = new [] { typeof(int) })]
        int? ScaleMinReplica { get; set; }
        /// <summary>Scaling rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Scaling rules.",
        SerializedName = @"rules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRule[] ScaleRule { get; set; }
        /// <summary>List of container definitions for the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of container definitions for the Container App.",
        SerializedName = @"containers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainer) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainer[] TemplateContainer { get; set; }
        /// <summary>User friendly suffix that is appended to the revision name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User friendly suffix that is appended to the revision name",
        SerializedName = @"revisionSuffix",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateRevisionSuffix { get; set; }
        /// <summary>List of volume definitions for the Container App.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of volume definitions for the Container App.",
        SerializedName = @"volumes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVolume) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVolume[] TemplateVolume { get; set; }

    }
    /// ContainerApp resource specific properties
    internal partial interface IContainerAppPropertiesInternal

    {
        /// <summary>Non versioned Container App configuration properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IConfiguration Configuration { get; set; }
        /// <summary>
        /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
        /// <list><item>Multiple: multiple revisions can be active.</item><item>Single: Only one revision can be active at a time.
        /// Revision weights can not be used in this mode. If no value if provided, this is the default.</item></list>
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.ActiveRevisionsMode? ConfigurationActiveRevisionsMode { get; set; }
        /// <summary>Dapr configuration for the Container App.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDapr ConfigurationDapr { get; set; }
        /// <summary>Ingress configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IIngress ConfigurationIngress { get; set; }
        /// <summary>
        /// Collection of private container registry credentials for containers used by the Container app
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IRegistryCredentials[] ConfigurationRegistry { get; set; }
        /// <summary>Collection of secrets used by a Container app</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ISecret[] ConfigurationSecret { get; set; }
        /// <summary>Id used to verify domain name ownership</summary>
        string CustomDomainVerificationId { get; set; }
        /// <summary>Dapr application identifier</summary>
        string DaprAppId { get; set; }
        /// <summary>Tells Dapr which port your application is listening on</summary>
        int? DaprAppPort { get; set; }
        /// <summary>
        /// Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.AppProtocol? DaprAppProtocol { get; set; }
        /// <summary>Boolean indicating if the Dapr side car is enabled</summary>
        bool? DaprEnabled { get; set; }
        /// <summary>
        /// Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS
        /// connections
        /// </summary>
        bool? IngressAllowInsecure { get; set; }
        /// <summary>custom domain bindings for Container Apps' hostnames.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain[] IngressCustomDomain { get; set; }
        /// <summary>Bool indicating if app exposes an external http endpoint</summary>
        bool? IngressExternal { get; set; }
        /// <summary>Hostname.</summary>
        string IngressFqdn { get; set; }
        /// <summary>Target Port in containers for traffic from ingress</summary>
        int? IngressTargetPort { get; set; }
        /// <summary>Traffic weights for app's revisions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITrafficWeight[] IngressTraffic { get; set; }
        /// <summary>Ingress transport protocol</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.IngressTransportMethod? IngressTransport { get; set; }
        /// <summary>Fully Qualified Domain Name of the latest revision of the Container App.</summary>
        string LatestRevisionFqdn { get; set; }
        /// <summary>Name of the latest revision of the Container App.</summary>
        string LatestRevisionName { get; set; }
        /// <summary>Resource ID of the Container App's environment.</summary>
        string ManagedEnvironmentId { get; set; }
        /// <summary>Outbound IP Addresses for container app.</summary>
        string[] OutboundIPAddress { get; set; }
        /// <summary>Provisioning state of the Container App.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Support.ContainerAppProvisioningState? ProvisioningState { get; set; }
        /// <summary>Optional. Maximum number of container replicas. Defaults to 10 if not set.</summary>
        int? ScaleMaxReplica { get; set; }
        /// <summary>Optional. Minimum number of container replicas.</summary>
        int? ScaleMinReplica { get; set; }
        /// <summary>Scaling rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRule[] ScaleRule { get; set; }
        /// <summary>Container App versioned application definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ITemplate Template { get; set; }
        /// <summary>List of container definitions for the Container App.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IContainer[] TemplateContainer { get; set; }
        /// <summary>User friendly suffix that is appended to the revision name</summary>
        string TemplateRevisionSuffix { get; set; }
        /// <summary>Scaling properties for the Container App.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScale TemplateScale { get; set; }
        /// <summary>List of volume definitions for the Container App.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVolume[] TemplateVolume { get; set; }

    }
}