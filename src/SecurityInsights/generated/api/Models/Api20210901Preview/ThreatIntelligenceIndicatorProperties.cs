// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Describes threat intelligence entity properties</summary>
    public partial class ThreatIntelligenceIndicatorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties __entityCommonProperties = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityCommonProperties();

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData; }

        /// <summary>Backing field for <see cref="Confidence" /> property.</summary>
        private int? _confidence;

        /// <summary>Confidence of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public int? Confidence { get => this._confidence; set => this._confidence = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        /// <summary>Created by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="CreatedByRef" /> property.</summary>
        private string _createdByRef;

        /// <summary>Created by reference of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string CreatedByRef { get => this._createdByRef; set => this._createdByRef = value; }

        /// <summary>Backing field for <see cref="Defanged" /> property.</summary>
        private bool? _defanged;

        /// <summary>Is threat intelligence entity defanged</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? Defanged { get => this._defanged; set => this._defanged = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Extension" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesExtensions _extension;

        /// <summary>Extensions map</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesExtensions Extension { get => (this._extension = this._extension ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ThreatIntelligenceIndicatorPropertiesExtensions()); set => this._extension = value; }

        /// <summary>Backing field for <see cref="ExternalId" /> property.</summary>
        private string _externalId;

        /// <summary>External ID of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ExternalId { get => this._externalId; set => this._externalId = value; }

        /// <summary>Backing field for <see cref="ExternalLastUpdatedTimeUtc" /> property.</summary>
        private string _externalLastUpdatedTimeUtc;

        /// <summary>External last updated time in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ExternalLastUpdatedTimeUtc { get => this._externalLastUpdatedTimeUtc; set => this._externalLastUpdatedTimeUtc = value; }

        /// <summary>Backing field for <see cref="ExternalReference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceExternalReference[] _externalReference;

        /// <summary>External References</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceExternalReference[] ExternalReference { get => this._externalReference; set => this._externalReference = value; }

        /// <summary>
        /// The graph item display name which is a short humanly readable description of the graph item instance. This property is
        /// optional and might be system generated.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName; }

        /// <summary>Backing field for <see cref="GranularMarking" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel[] _granularMarking;

        /// <summary>Granular Markings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel[] GranularMarking { get => this._granularMarking; set => this._granularMarking = value; }

        /// <summary>Backing field for <see cref="IndicatorType" /> property.</summary>
        private string[] _indicatorType;

        /// <summary>Indicator types of threat intelligence entities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] IndicatorType { get => this._indicatorType; set => this._indicatorType = value; }

        /// <summary>Backing field for <see cref="KillChainPhase" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceKillChainPhase[] _killChainPhase;

        /// <summary>Kill chain phases</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceKillChainPhase[] KillChainPhase { get => this._killChainPhase; set => this._killChainPhase = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string[] _label;

        /// <summary>Labels of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="Language" /> property.</summary>
        private string _language;

        /// <summary>Language of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Language { get => this._language; set => this._language = value; }

        /// <summary>Backing field for <see cref="LastUpdatedTimeUtc" /> property.</summary>
        private string _lastUpdatedTimeUtc;

        /// <summary>Last updated time in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string LastUpdatedTimeUtc { get => this._lastUpdatedTimeUtc; set => this._lastUpdatedTimeUtc = value; }

        /// <summary>Internal Acessors for AdditionalData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesAdditionalData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal.AdditionalData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).AdditionalData = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal)__entityCommonProperties).FriendlyName = value; }

        /// <summary>Backing field for <see cref="Modified" /> property.</summary>
        private string _modified;

        /// <summary>Modified by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Modified { get => this._modified; set => this._modified = value; }

        /// <summary>Backing field for <see cref="ObjectMarkingRef" /> property.</summary>
        private string[] _objectMarkingRef;

        /// <summary>Threat intelligence entity object marking references</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] ObjectMarkingRef { get => this._objectMarkingRef; set => this._objectMarkingRef = value; }

        /// <summary>Backing field for <see cref="ParsedPattern" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceParsedPattern[] _parsedPattern;

        /// <summary>Parsed patterns</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceParsedPattern[] ParsedPattern { get => this._parsedPattern; set => this._parsedPattern = value; }

        /// <summary>Backing field for <see cref="Pattern" /> property.</summary>
        private string _pattern;

        /// <summary>Pattern of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Pattern { get => this._pattern; set => this._pattern = value; }

        /// <summary>Backing field for <see cref="PatternType" /> property.</summary>
        private string _patternType;

        /// <summary>Pattern type of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string PatternType { get => this._patternType; set => this._patternType = value; }

        /// <summary>Backing field for <see cref="PatternVersion" /> property.</summary>
        private string _patternVersion;

        /// <summary>Pattern version of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string PatternVersion { get => this._patternVersion; set => this._patternVersion = value; }

        /// <summary>Backing field for <see cref="Revoked" /> property.</summary>
        private bool? _revoked;

        /// <summary>Is threat intelligence entity revoked</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public bool? Revoked { get => this._revoked; set => this._revoked = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>Source of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Backing field for <see cref="ThreatIntelligenceTag" /> property.</summary>
        private string[] _threatIntelligenceTag;

        /// <summary>List of tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] ThreatIntelligenceTag { get => this._threatIntelligenceTag; set => this._threatIntelligenceTag = value; }

        /// <summary>Backing field for <see cref="ThreatType" /> property.</summary>
        private string[] _threatType;

        /// <summary>Threat types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] ThreatType { get => this._threatType; set => this._threatType = value; }

        /// <summary>Backing field for <see cref="ValidFrom" /> property.</summary>
        private string _validFrom;

        /// <summary>Valid from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ValidFrom { get => this._validFrom; set => this._validFrom = value; }

        /// <summary>Backing field for <see cref="ValidUntil" /> property.</summary>
        private string _validUntil;

        /// <summary>Valid until</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ValidUntil { get => this._validUntil; set => this._validUntil = value; }

        /// <summary>Creates an new <see cref="ThreatIntelligenceIndicatorProperties" /> instance.</summary>
        public ThreatIntelligenceIndicatorProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entityCommonProperties), __entityCommonProperties);
            await eventListener.AssertObjectIsValid(nameof(__entityCommonProperties), __entityCommonProperties);
        }
    }
    /// Describes threat intelligence entity properties
    public partial interface IThreatIntelligenceIndicatorProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonProperties
    {
        /// <summary>Confidence of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Confidence of threat intelligence entity",
        SerializedName = @"confidence",
        PossibleTypes = new [] { typeof(int) })]
        int? Confidence { get; set; }
        /// <summary>Created by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Created by",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }
        /// <summary>Created by reference of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Created by reference of threat intelligence entity",
        SerializedName = @"createdByRef",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByRef { get; set; }
        /// <summary>Is threat intelligence entity defanged</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is threat intelligence entity defanged",
        SerializedName = @"defanged",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Defanged { get; set; }
        /// <summary>Description of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of a threat intelligence entity",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Display name of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of a threat intelligence entity",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Extensions map</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Extensions map",
        SerializedName = @"extensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesExtensions) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesExtensions Extension { get; set; }
        /// <summary>External ID of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External ID of threat intelligence entity",
        SerializedName = @"externalId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalId { get; set; }
        /// <summary>External last updated time in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External last updated time in UTC",
        SerializedName = @"externalLastUpdatedTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalLastUpdatedTimeUtc { get; set; }
        /// <summary>External References</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External References",
        SerializedName = @"externalReferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceExternalReference) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceExternalReference[] ExternalReference { get; set; }
        /// <summary>Granular Markings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Granular Markings",
        SerializedName = @"granularMarkings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel[] GranularMarking { get; set; }
        /// <summary>Indicator types of threat intelligence entities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicator types of threat intelligence entities",
        SerializedName = @"indicatorTypes",
        PossibleTypes = new [] { typeof(string) })]
        string[] IndicatorType { get; set; }
        /// <summary>Kill chain phases</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Kill chain phases",
        SerializedName = @"killChainPhases",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceKillChainPhase) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceKillChainPhase[] KillChainPhase { get; set; }
        /// <summary>Labels of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Labels  of threat intelligence entity",
        SerializedName = @"labels",
        PossibleTypes = new [] { typeof(string) })]
        string[] Label { get; set; }
        /// <summary>Language of threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Language of threat intelligence entity",
        SerializedName = @"language",
        PossibleTypes = new [] { typeof(string) })]
        string Language { get; set; }
        /// <summary>Last updated time in UTC</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last updated time in UTC",
        SerializedName = @"lastUpdatedTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTimeUtc { get; set; }
        /// <summary>Modified by</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Modified by",
        SerializedName = @"modified",
        PossibleTypes = new [] { typeof(string) })]
        string Modified { get; set; }
        /// <summary>Threat intelligence entity object marking references</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Threat intelligence entity object marking references",
        SerializedName = @"objectMarkingRefs",
        PossibleTypes = new [] { typeof(string) })]
        string[] ObjectMarkingRef { get; set; }
        /// <summary>Parsed patterns</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parsed patterns",
        SerializedName = @"parsedPattern",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceParsedPattern) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceParsedPattern[] ParsedPattern { get; set; }
        /// <summary>Pattern of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pattern of a threat intelligence entity",
        SerializedName = @"pattern",
        PossibleTypes = new [] { typeof(string) })]
        string Pattern { get; set; }
        /// <summary>Pattern type of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pattern type of a threat intelligence entity",
        SerializedName = @"patternType",
        PossibleTypes = new [] { typeof(string) })]
        string PatternType { get; set; }
        /// <summary>Pattern version of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pattern version of a threat intelligence entity",
        SerializedName = @"patternVersion",
        PossibleTypes = new [] { typeof(string) })]
        string PatternVersion { get; set; }
        /// <summary>Is threat intelligence entity revoked</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is threat intelligence entity revoked",
        SerializedName = @"revoked",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Revoked { get; set; }
        /// <summary>Source of a threat intelligence entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source of a threat intelligence entity",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
        /// <summary>List of tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of tags",
        SerializedName = @"threatIntelligenceTags",
        PossibleTypes = new [] { typeof(string) })]
        string[] ThreatIntelligenceTag { get; set; }
        /// <summary>Threat types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Threat types",
        SerializedName = @"threatTypes",
        PossibleTypes = new [] { typeof(string) })]
        string[] ThreatType { get; set; }
        /// <summary>Valid from</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Valid from",
        SerializedName = @"validFrom",
        PossibleTypes = new [] { typeof(string) })]
        string ValidFrom { get; set; }
        /// <summary>Valid until</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Valid until",
        SerializedName = @"validUntil",
        PossibleTypes = new [] { typeof(string) })]
        string ValidUntil { get; set; }

    }
    /// Describes threat intelligence entity properties
    internal partial interface IThreatIntelligenceIndicatorPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityCommonPropertiesInternal
    {
        /// <summary>Confidence of threat intelligence entity</summary>
        int? Confidence { get; set; }
        /// <summary>Created by</summary>
        string Created { get; set; }
        /// <summary>Created by reference of threat intelligence entity</summary>
        string CreatedByRef { get; set; }
        /// <summary>Is threat intelligence entity defanged</summary>
        bool? Defanged { get; set; }
        /// <summary>Description of a threat intelligence entity</summary>
        string Description { get; set; }
        /// <summary>Display name of a threat intelligence entity</summary>
        string DisplayName { get; set; }
        /// <summary>Extensions map</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceIndicatorPropertiesExtensions Extension { get; set; }
        /// <summary>External ID of threat intelligence entity</summary>
        string ExternalId { get; set; }
        /// <summary>External last updated time in UTC</summary>
        string ExternalLastUpdatedTimeUtc { get; set; }
        /// <summary>External References</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceExternalReference[] ExternalReference { get; set; }
        /// <summary>Granular Markings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceGranularMarkingModel[] GranularMarking { get; set; }
        /// <summary>Indicator types of threat intelligence entities</summary>
        string[] IndicatorType { get; set; }
        /// <summary>Kill chain phases</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceKillChainPhase[] KillChainPhase { get; set; }
        /// <summary>Labels of threat intelligence entity</summary>
        string[] Label { get; set; }
        /// <summary>Language of threat intelligence entity</summary>
        string Language { get; set; }
        /// <summary>Last updated time in UTC</summary>
        string LastUpdatedTimeUtc { get; set; }
        /// <summary>Modified by</summary>
        string Modified { get; set; }
        /// <summary>Threat intelligence entity object marking references</summary>
        string[] ObjectMarkingRef { get; set; }
        /// <summary>Parsed patterns</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IThreatIntelligenceParsedPattern[] ParsedPattern { get; set; }
        /// <summary>Pattern of a threat intelligence entity</summary>
        string Pattern { get; set; }
        /// <summary>Pattern type of a threat intelligence entity</summary>
        string PatternType { get; set; }
        /// <summary>Pattern version of a threat intelligence entity</summary>
        string PatternVersion { get; set; }
        /// <summary>Is threat intelligence entity revoked</summary>
        bool? Revoked { get; set; }
        /// <summary>Source of a threat intelligence entity</summary>
        string Source { get; set; }
        /// <summary>List of tags</summary>
        string[] ThreatIntelligenceTag { get; set; }
        /// <summary>Threat types</summary>
        string[] ThreatType { get; set; }
        /// <summary>Valid from</summary>
        string ValidFrom { get; set; }
        /// <summary>Valid until</summary>
        string ValidUntil { get; set; }

    }
}