// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001
{
    using Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.PowerShell;

    /// <summary>Alert details</summary>
    [System.ComponentModel.TypeConverter(typeof(AlertPropertiesDetailsTypeConverter))]
    public partial class AlertPropertiesDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.AlertPropertiesDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AlertPropertiesDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TimeGrainType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TimeGrainType = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType?) content.GetValueForProperty("TimeGrainType",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TimeGrainType, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType.CreateFrom);
            }
            if (content.Contains("PeriodStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).PeriodStartDate = (string) content.GetValueForProperty("PeriodStartDate",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).PeriodStartDate, global::System.Convert.ToString);
            }
            if (content.Contains("TriggeredBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TriggeredBy = (string) content.GetValueForProperty("TriggeredBy",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TriggeredBy, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceGroupFilter = (string[]) content.GetValueForProperty("ResourceGroupFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceGroupFilter, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ResourceFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceFilter = (string[]) content.GetValueForProperty("ResourceFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceFilter, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MeterFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).MeterFilter = (string[]) content.GetValueForProperty("MeterFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).MeterFilter, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TagFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TagFilter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IAny) content.GetValueForProperty("TagFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TagFilter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Threshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Threshold = (decimal?) content.GetValueForProperty("Threshold",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Threshold, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            if (content.Contains("Operator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Operator = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertOperator?) content.GetValueForProperty("Operator",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Operator, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertOperator.CreateFrom);
            }
            if (content.Contains("Amount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Amount = (decimal?) content.GetValueForProperty("Amount",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Amount, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentSpend"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CurrentSpend = (decimal?) content.GetValueForProperty("CurrentSpend",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CurrentSpend, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            if (content.Contains("ContactEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactEmail = (string[]) content.GetValueForProperty("ContactEmail",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactEmail, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactGroup = (string[]) content.GetValueForProperty("ContactGroup",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactGroup, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactRole"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactRole = (string[]) content.GetValueForProperty("ContactRole",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactRole, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OverridingAlert"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).OverridingAlert = (string) content.GetValueForProperty("OverridingAlert",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).OverridingAlert, global::System.Convert.ToString);
            }
            if (content.Contains("DepartmentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).DepartmentName = (string) content.GetValueForProperty("DepartmentName",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).DepartmentName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("EnrollmentNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentNumber = (string) content.GetValueForProperty("EnrollmentNumber",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentNumber, global::System.Convert.ToString);
            }
            if (content.Contains("EnrollmentStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentStartDate = (string) content.GetValueForProperty("EnrollmentStartDate",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentStartDate, global::System.Convert.ToString);
            }
            if (content.Contains("EnrollmentEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentEndDate = (string) content.GetValueForProperty("EnrollmentEndDate",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentEndDate, global::System.Convert.ToString);
            }
            if (content.Contains("InvoicingThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).InvoicingThreshold = (decimal?) content.GetValueForProperty("InvoicingThreshold",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).InvoicingThreshold, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.AlertPropertiesDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AlertPropertiesDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TimeGrainType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TimeGrainType = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType?) content.GetValueForProperty("TimeGrainType",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TimeGrainType, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertTimeGrainType.CreateFrom);
            }
            if (content.Contains("PeriodStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).PeriodStartDate = (string) content.GetValueForProperty("PeriodStartDate",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).PeriodStartDate, global::System.Convert.ToString);
            }
            if (content.Contains("TriggeredBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TriggeredBy = (string) content.GetValueForProperty("TriggeredBy",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TriggeredBy, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceGroupFilter = (string[]) content.GetValueForProperty("ResourceGroupFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceGroupFilter, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ResourceFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceFilter = (string[]) content.GetValueForProperty("ResourceFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ResourceFilter, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MeterFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).MeterFilter = (string[]) content.GetValueForProperty("MeterFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).MeterFilter, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TagFilter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TagFilter = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IAny) content.GetValueForProperty("TagFilter",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).TagFilter, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("Threshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Threshold = (decimal?) content.GetValueForProperty("Threshold",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Threshold, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            if (content.Contains("Operator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Operator = (Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertOperator?) content.GetValueForProperty("Operator",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Operator, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertOperator.CreateFrom);
            }
            if (content.Contains("Amount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Amount = (decimal?) content.GetValueForProperty("Amount",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Amount, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            if (content.Contains("Unit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Unit = (string) content.GetValueForProperty("Unit",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).Unit, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentSpend"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CurrentSpend = (decimal?) content.GetValueForProperty("CurrentSpend",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CurrentSpend, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            if (content.Contains("ContactEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactEmail = (string[]) content.GetValueForProperty("ContactEmail",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactEmail, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactGroup = (string[]) content.GetValueForProperty("ContactGroup",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactGroup, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactRole"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactRole = (string[]) content.GetValueForProperty("ContactRole",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).ContactRole, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OverridingAlert"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).OverridingAlert = (string) content.GetValueForProperty("OverridingAlert",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).OverridingAlert, global::System.Convert.ToString);
            }
            if (content.Contains("DepartmentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).DepartmentName = (string) content.GetValueForProperty("DepartmentName",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).DepartmentName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("EnrollmentNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentNumber = (string) content.GetValueForProperty("EnrollmentNumber",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentNumber, global::System.Convert.ToString);
            }
            if (content.Contains("EnrollmentStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentStartDate = (string) content.GetValueForProperty("EnrollmentStartDate",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentStartDate, global::System.Convert.ToString);
            }
            if (content.Contains("EnrollmentEndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentEndDate = (string) content.GetValueForProperty("EnrollmentEndDate",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).EnrollmentEndDate, global::System.Convert.ToString);
            }
            if (content.Contains("InvoicingThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).InvoicingThreshold = (decimal?) content.GetValueForProperty("InvoicingThreshold",((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetailsInternal)this).InvoicingThreshold, (__y)=> (decimal) global::System.Convert.ChangeType(__y, typeof(decimal)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.AlertPropertiesDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AlertPropertiesDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.AlertPropertiesDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AlertPropertiesDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AlertPropertiesDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AlertPropertiesDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IAlertPropertiesDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Alert details
    [System.ComponentModel.TypeConverter(typeof(AlertPropertiesDetailsTypeConverter))]
    public partial interface IAlertPropertiesDetails

    {

    }
}