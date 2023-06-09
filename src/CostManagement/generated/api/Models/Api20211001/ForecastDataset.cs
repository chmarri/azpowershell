// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Extensions;

    /// <summary>The definition of data present in the forecast.</summary>
    public partial class ForecastDataset :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDataset,
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal
    {

        /// <summary>Backing field for <see cref="Aggregation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetAggregation _aggregation;

        /// <summary>
        /// Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the
        /// aggregated column. forecast can have up to 2 aggregation clauses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetAggregation Aggregation { get => (this._aggregation = this._aggregation ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ForecastDatasetAggregation()); set => this._aggregation = value; }

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetConfiguration _configuration;

        /// <summary>
        /// Has configuration information for the data in the export. The configuration will be ignored if aggregation and grouping
        /// are provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetConfiguration Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ForecastDatasetConfiguration()); set => this._configuration = value; }

        /// <summary>
        /// Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then
        /// forecast includes all columns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string[] ConfigurationColumn { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetConfigurationInternal)Configuration).Column; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetConfigurationInternal)Configuration).Column = value ?? null /* arrayOf */; }

        /// <summary>The name of the column to use in comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DimensionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionName = value ?? null; }

        /// <summary>The operator to use for comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DimensionOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionOperator; }

        /// <summary>Array of values to use for comparison</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string[] DimensionValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionValue = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter _filter;

        /// <summary>Has filter expression to use in the forecast.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter Filter { get => (this._filter = this._filter ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ForecastFilter()); set => this._filter = value; }

        /// <summary>The logical "AND" expression. Must have at least 2 items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter[] FilterAnd { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).And; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).And = value ?? null /* arrayOf */; }

        /// <summary>The logical "OR" expression. Must have at least 2 items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter[] FilterOr { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).Or; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).Or = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Granularity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType? _granularity;

        /// <summary>The granularity of rows in the forecast.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType? Granularity { get => this._granularity; set => this._granularity = value; }

        /// <summary>Internal Acessors for Configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetConfiguration Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal.Configuration { get => (this._configuration = this._configuration ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ForecastDatasetConfiguration()); set { {_configuration = value;} } }

        /// <summary>Internal Acessors for DimensionOperator</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal.DimensionOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionOperator; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).DimensionOperator = value; }

        /// <summary>Internal Acessors for Filter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal.Filter { get => (this._filter = this._filter ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ForecastFilter()); set { {_filter = value;} } }

        /// <summary>Internal Acessors for FilterDimension</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastComparisonExpression Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal.FilterDimension { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).Dimension; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).Dimension = value; }

        /// <summary>Internal Acessors for FilterTag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastComparisonExpression Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal.FilterTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).Tag = value; }

        /// <summary>Internal Acessors for TagOperator</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetInternal.TagOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagOperator; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagOperator = value; }

        /// <summary>The name of the column to use in comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string TagName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagName = value ?? null; }

        /// <summary>The operator to use for comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string TagOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagOperator; }

        /// <summary>Array of values to use for comparison</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string[] TagValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilterInternal)Filter).TagValue = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ForecastDataset" /> instance.</summary>
        public ForecastDataset()
        {

        }
    }
    /// The definition of data present in the forecast.
    public partial interface IForecastDataset :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the
        /// aggregated column. forecast can have up to 2 aggregation clauses.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the aggregated column. forecast can have up to 2 aggregation clauses.",
        SerializedName = @"aggregation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetAggregation) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetAggregation Aggregation { get; set; }
        /// <summary>
        /// Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then
        /// forecast includes all columns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then forecast includes all columns.",
        SerializedName = @"columns",
        PossibleTypes = new [] { typeof(string) })]
        string[] ConfigurationColumn { get; set; }
        /// <summary>The name of the column to use in comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the column to use in comparison.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DimensionName { get; set; }
        /// <summary>The operator to use for comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The operator to use for comparison.",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(string) })]
        string DimensionOperator { get;  }
        /// <summary>Array of values to use for comparison</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of values to use for comparison",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(string) })]
        string[] DimensionValue { get; set; }
        /// <summary>The logical "AND" expression. Must have at least 2 items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The logical ""AND"" expression. Must have at least 2 items.",
        SerializedName = @"and",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter[] FilterAnd { get; set; }
        /// <summary>The logical "OR" expression. Must have at least 2 items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The logical ""OR"" expression. Must have at least 2 items.",
        SerializedName = @"or",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter[] FilterOr { get; set; }
        /// <summary>The granularity of rows in the forecast.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The granularity of rows in the forecast.",
        SerializedName = @"granularity",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType? Granularity { get; set; }
        /// <summary>The name of the column to use in comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the column to use in comparison.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TagName { get; set; }
        /// <summary>The operator to use for comparison.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The operator to use for comparison.",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(string) })]
        string TagOperator { get;  }
        /// <summary>Array of values to use for comparison</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of values to use for comparison",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(string) })]
        string[] TagValue { get; set; }

    }
    /// The definition of data present in the forecast.
    public partial interface IForecastDatasetInternal

    {
        /// <summary>
        /// Dictionary of aggregation expression to use in the forecast. The key of each item in the dictionary is the alias for the
        /// aggregated column. forecast can have up to 2 aggregation clauses.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetAggregation Aggregation { get; set; }
        /// <summary>
        /// Has configuration information for the data in the export. The configuration will be ignored if aggregation and grouping
        /// are provided.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastDatasetConfiguration Configuration { get; set; }
        /// <summary>
        /// Array of column names to be included in the forecast. Any valid forecast column name is allowed. If not provided, then
        /// forecast includes all columns.
        /// </summary>
        string[] ConfigurationColumn { get; set; }
        /// <summary>The name of the column to use in comparison.</summary>
        string DimensionName { get; set; }
        /// <summary>The operator to use for comparison.</summary>
        string DimensionOperator { get; set; }
        /// <summary>Array of values to use for comparison</summary>
        string[] DimensionValue { get; set; }
        /// <summary>Has filter expression to use in the forecast.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter Filter { get; set; }
        /// <summary>The logical "AND" expression. Must have at least 2 items.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter[] FilterAnd { get; set; }
        /// <summary>Has comparison expression for a dimension</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastComparisonExpression FilterDimension { get; set; }
        /// <summary>The logical "OR" expression. Must have at least 2 items.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastFilter[] FilterOr { get; set; }
        /// <summary>Has comparison expression for a tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IForecastComparisonExpression FilterTag { get; set; }
        /// <summary>The granularity of rows in the forecast.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.GranularityType? Granularity { get; set; }
        /// <summary>The name of the column to use in comparison.</summary>
        string TagName { get; set; }
        /// <summary>The operator to use for comparison.</summary>
        string TagOperator { get; set; }
        /// <summary>Array of values to use for comparison</summary>
        string[] TagValue { get; set; }

    }
}