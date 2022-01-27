// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Extensions;

    /// <summary>An authentication key to regenerate.</summary>
    public partial class RegenAuthKeys
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IRegenAuthKeys.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IRegenAuthKeys.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20211030Preview.IRegenAuthKeys FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json ? new RegenAuthKeys(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject into a new instance of <see cref="RegenAuthKeys" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RegenAuthKeys(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_keyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("keyName"), out var __jsonKeyName) ? (string)__jsonKeyName : (string)KeyName;}
            {_authKey1 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("authKey1"), out var __jsonAuthKey1) ? (string)__jsonAuthKey1 : (string)AuthKey1;}
            {_authKey2 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("authKey2"), out var __jsonAuthKey2) ? (string)__jsonAuthKey2 : (string)AuthKey2;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RegenAuthKeys" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RegenAuthKeys" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._keyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._keyName.ToString()) : null, "keyName" ,container.Add );
            AddIf( null != (((object)this._authKey1)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._authKey1.ToString()) : null, "authKey1" ,container.Add );
            AddIf( null != (((object)this._authKey2)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._authKey2.ToString()) : null, "authKey2" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}