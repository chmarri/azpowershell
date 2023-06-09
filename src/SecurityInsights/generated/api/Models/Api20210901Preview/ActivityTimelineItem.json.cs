// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Represents Activity timeline item.</summary>
    public partial class ActivityTimelineItem
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject into a new instance of <see cref="ActivityTimelineItem" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ActivityTimelineItem(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __entityTimelineItem = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityTimelineItem(json);
            {_queryId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("queryId"), out var __jsonQueryId) ? (string)__jsonQueryId : (string)QueryId;}
            {_bucketStartTimeUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("bucketStartTimeUTC"), out var __jsonBucketStartTimeUtc) ? global::System.DateTime.TryParse((string)__jsonBucketStartTimeUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonBucketStartTimeUtcValue) ? __jsonBucketStartTimeUtcValue : BucketStartTimeUtc : BucketStartTimeUtc;}
            {_bucketEndTimeUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("bucketEndTimeUTC"), out var __jsonBucketEndTimeUtc) ? global::System.DateTime.TryParse((string)__jsonBucketEndTimeUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonBucketEndTimeUtcValue) ? __jsonBucketEndTimeUtcValue : BucketEndTimeUtc : BucketEndTimeUtc;}
            {_firstActivityTimeUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("firstActivityTimeUTC"), out var __jsonFirstActivityTimeUtc) ? global::System.DateTime.TryParse((string)__jsonFirstActivityTimeUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonFirstActivityTimeUtcValue) ? __jsonFirstActivityTimeUtcValue : FirstActivityTimeUtc : FirstActivityTimeUtc;}
            {_lastActivityTimeUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("lastActivityTimeUTC"), out var __jsonLastActivityTimeUtc) ? global::System.DateTime.TryParse((string)__jsonLastActivityTimeUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastActivityTimeUtcValue) ? __jsonLastActivityTimeUtcValue : LastActivityTimeUtc : LastActivityTimeUtc;}
            {_content = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("content"), out var __jsonContent) ? (string)__jsonContent : (string)Content;}
            {_title = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityTimelineItem.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityTimelineItem.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityTimelineItem FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject json ? new ActivityTimelineItem(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ActivityTimelineItem" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ActivityTimelineItem" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __entityTimelineItem?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._queryId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._queryId.ToString()) : null, "queryId" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._bucketStartTimeUtc.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "bucketStartTimeUTC" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._bucketEndTimeUtc.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "bucketEndTimeUTC" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._firstActivityTimeUtc.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "firstActivityTimeUTC" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._lastActivityTimeUtc.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)), "lastActivityTimeUTC" ,container.Add );
            AddIf( null != (((object)this._content)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._content.ToString()) : null, "content" ,container.Add );
            AddIf( null != (((object)this._title)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonString(this._title.ToString()) : null, "title" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}