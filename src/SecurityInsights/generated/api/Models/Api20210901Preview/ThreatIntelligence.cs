// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>ThreatIntelligence property bag.</summary>
    public partial class ThreatIntelligence :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligence,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal
    {

        /// <summary>Backing field for <see cref="Confidence" /> property.</summary>
        private double? _confidence;

        /// <summary>Confidence (must be between 0 and 1)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public double? Confidence { get => this._confidence; }

        /// <summary>Internal Acessors for Confidence</summary>
        double? Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal.Confidence { get => this._confidence; set { {_confidence = value;} } }

        /// <summary>Internal Acessors for ProviderName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal.ProviderName { get => this._providerName; set { {_providerName = value;} } }

        /// <summary>Internal Acessors for ReportLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal.ReportLink { get => this._reportLink; set { {_reportLink = value;} } }

        /// <summary>Internal Acessors for ThreatDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal.ThreatDescription { get => this._threatDescription; set { {_threatDescription = value;} } }

        /// <summary>Internal Acessors for ThreatName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal.ThreatName { get => this._threatName; set { {_threatName = value;} } }

        /// <summary>Internal Acessors for ThreatType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceInternal.ThreatType { get => this._threatType; set { {_threatType = value;} } }

        /// <summary>Backing field for <see cref="ProviderName" /> property.</summary>
        private string _providerName;

        /// <summary>
        /// Name of the provider from whom this Threat Intelligence information was received
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ProviderName { get => this._providerName; }

        /// <summary>Backing field for <see cref="ReportLink" /> property.</summary>
        private string _reportLink;

        /// <summary>Report link</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ReportLink { get => this._reportLink; }

        /// <summary>Backing field for <see cref="ThreatDescription" /> property.</summary>
        private string _threatDescription;

        /// <summary>Threat description (free text)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ThreatDescription { get => this._threatDescription; }

        /// <summary>Backing field for <see cref="ThreatName" /> property.</summary>
        private string _threatName;

        /// <summary>Threat name (e.g. "Jedobot malware")</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ThreatName { get => this._threatName; }

        /// <summary>Backing field for <see cref="ThreatType" /> property.</summary>
        private string _threatType;

        /// <summary>Threat type (e.g. "Botnet")</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ThreatType { get => this._threatType; }

        /// <summary>Creates an new <see cref="ThreatIntelligence" /> instance.</summary>
        public ThreatIntelligence()
        {

        }
    }
    /// ThreatIntelligence property bag.
    public partial interface IThreatIntelligence :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Confidence (must be between 0 and 1)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Confidence (must be between 0 and 1)",
        SerializedName = @"confidence",
        PossibleTypes = new [] { typeof(double) })]
        double? Confidence { get;  }
        /// <summary>
        /// Name of the provider from whom this Threat Intelligence information was received
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the provider from whom this Threat Intelligence information was received",
        SerializedName = @"providerName",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderName { get;  }
        /// <summary>Report link</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Report link",
        SerializedName = @"reportLink",
        PossibleTypes = new [] { typeof(string) })]
        string ReportLink { get;  }
        /// <summary>Threat description (free text)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Threat description (free text)",
        SerializedName = @"threatDescription",
        PossibleTypes = new [] { typeof(string) })]
        string ThreatDescription { get;  }
        /// <summary>Threat name (e.g. "Jedobot malware")</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Threat name (e.g. ""Jedobot malware"")",
        SerializedName = @"threatName",
        PossibleTypes = new [] { typeof(string) })]
        string ThreatName { get;  }
        /// <summary>Threat type (e.g. "Botnet")</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Threat type (e.g. ""Botnet"")",
        SerializedName = @"threatType",
        PossibleTypes = new [] { typeof(string) })]
        string ThreatType { get;  }

    }
    /// ThreatIntelligence property bag.
    internal partial interface IThreatIntelligenceInternal

    {
        /// <summary>Confidence (must be between 0 and 1)</summary>
        double? Confidence { get; set; }
        /// <summary>
        /// Name of the provider from whom this Threat Intelligence information was received
        /// </summary>
        string ProviderName { get; set; }
        /// <summary>Report link</summary>
        string ReportLink { get; set; }
        /// <summary>Threat description (free text)</summary>
        string ThreatDescription { get; set; }
        /// <summary>Threat name (e.g. "Jedobot malware")</summary>
        string ThreatName { get; set; }
        /// <summary>Threat type (e.g. "Botnet")</summary>
        string ThreatType { get; set; }

    }
}