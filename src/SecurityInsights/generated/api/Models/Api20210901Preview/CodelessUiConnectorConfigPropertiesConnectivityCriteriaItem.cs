// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    public partial class CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICodelessUiConnectorConfigPropertiesConnectivityCriteriaItem,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ICodelessUiConnectorConfigPropertiesConnectivityCriteriaItemInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteria"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteria __connectivityCriteria = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ConnectivityCriteria();

        /// <summary>type of connectivity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConnectivityType? Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteriaInternal)__connectivityCriteria).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteriaInternal)__connectivityCriteria).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.ConnectivityType)""); }

        /// <summary>Queries for checking connectivity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string[] Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteriaInternal)__connectivityCriteria).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteriaInternal)__connectivityCriteria).Value = value ?? null /* arrayOf */; }

        /// <summary>
        /// Creates an new <see cref="CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem" /> instance.
        /// </summary>
        public CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem()
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
            await eventListener.AssertNotNull(nameof(__connectivityCriteria), __connectivityCriteria);
            await eventListener.AssertObjectIsValid(nameof(__connectivityCriteria), __connectivityCriteria);
        }
    }
    public partial interface ICodelessUiConnectorConfigPropertiesConnectivityCriteriaItem :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteria
    {

    }
    internal partial interface ICodelessUiConnectorConfigPropertiesConnectivityCriteriaItemInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IConnectivityCriteriaInternal
    {

    }
}