// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>An Application Insights workbook template definition.</summary>
    public partial class WorkbookTemplate :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplate,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResource __workbookTemplateResource = new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.WorkbookTemplateResource();

        /// <summary>Information about the author of the workbook template.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Author { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Author; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Author = value ?? null; }

        /// <summary>Workbook galleries supported by the template.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateGallery[] Gallery { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Gallery; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Gallery = value ?? null /* arrayOf */; }

        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Id; }

        /// <summary>
        /// Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesLocalized Localized { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Localized; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Localized = value ?? null /* model class */; }

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 3)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Location = value ; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateProperties Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.WorkbookTemplateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Type = value; }

        /// <summary>Azure resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 1)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Name; }

        /// <summary>
        /// Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public int? Priority { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Priority; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).Priority = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateProperties _property;

        /// <summary>Metadata describing a workbook template for an Azure resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.WorkbookTemplateProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 0)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Tag = value ?? null /* model class */; }

        /// <summary>Valid JSON object containing workbook template payload.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesTemplateData TemplateData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).TemplateData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesInternal)Property).TemplateData = value ?? null /* model class */; }

        /// <summary>Azure resource type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal)__workbookTemplateResource).Type; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workbookTemplateResource), __workbookTemplateResource);
            await eventListener.AssertObjectIsValid(nameof(__workbookTemplateResource), __workbookTemplateResource);
        }

        /// <summary>Creates an new <see cref="WorkbookTemplate" /> instance.</summary>
        public WorkbookTemplate()
        {

        }
    }
    /// An Application Insights workbook template definition.
    public partial interface IWorkbookTemplate :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResource
    {
        /// <summary>Information about the author of the workbook template.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Information about the author of the workbook template.",
        SerializedName = @"author",
        PossibleTypes = new [] { typeof(string) })]
        string Author { get; set; }
        /// <summary>Workbook galleries supported by the template.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Workbook galleries supported by the template.",
        SerializedName = @"galleries",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateGallery) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateGallery[] Gallery { get; set; }
        /// <summary>
        /// Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal.",
        SerializedName = @"localized",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesLocalized) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesLocalized Localized { get; set; }
        /// <summary>
        /// Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode.",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>Valid JSON object containing workbook template payload.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Valid JSON object containing workbook template payload.",
        SerializedName = @"templateData",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesTemplateData) })]
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesTemplateData TemplateData { get; set; }

    }
    /// An Application Insights workbook template definition.
    internal partial interface IWorkbookTemplateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateResourceInternal
    {
        /// <summary>Information about the author of the workbook template.</summary>
        string Author { get; set; }
        /// <summary>Workbook galleries supported by the template.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateGallery[] Gallery { get; set; }
        /// <summary>
        /// Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesLocalized Localized { get; set; }
        /// <summary>
        /// Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode.
        /// </summary>
        int? Priority { get; set; }
        /// <summary>Metadata describing a workbook template for an Azure resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplateProperties Property { get; set; }
        /// <summary>Valid JSON object containing workbook template payload.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20201120.IWorkbookTemplatePropertiesTemplateData TemplateData { get; set; }

    }
}