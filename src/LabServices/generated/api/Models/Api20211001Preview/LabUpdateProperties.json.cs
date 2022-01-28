// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>Properties of a lab resource used for updates.</summary>
    public partial class LabUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ILabUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ILabUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ILabUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json ? new LabUpdateProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject into a new instance of <see cref="LabUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LabUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_autoShutdownProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject>("autoShutdownProfile"), out var __jsonAutoShutdownProfile) ? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.AutoShutdownProfile.FromJson(__jsonAutoShutdownProfile) : AutoShutdownProfile;}
            {_connectionProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject>("connectionProfile"), out var __jsonConnectionProfile) ? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.ConnectionProfile.FromJson(__jsonConnectionProfile) : ConnectionProfile;}
            {_virtualMachineProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject>("virtualMachineProfile"), out var __jsonVirtualMachineProfile) ? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.VirtualMachineProfile.FromJson(__jsonVirtualMachineProfile) : VirtualMachineProfile;}
            {_securityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject>("securityProfile"), out var __jsonSecurityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.SecurityProfile.FromJson(__jsonSecurityProfile) : SecurityProfile;}
            {_rosterProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject>("rosterProfile"), out var __jsonRosterProfile) ? Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.Api20211001Preview.RosterProfile.FromJson(__jsonRosterProfile) : RosterProfile;}
            {_labPlanId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("labPlanId"), out var __jsonLabPlanId) ? (string)__jsonLabPlanId : (string)LabPlanId;}
            {_title = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("title"), out var __jsonTitle) ? (string)__jsonTitle : (string)Title;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LabUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LabUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._autoShutdownProfile ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) this._autoShutdownProfile.ToJson(null,serializationMode) : null, "autoShutdownProfile" ,container.Add );
            AddIf( null != this._connectionProfile ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) this._connectionProfile.ToJson(null,serializationMode) : null, "connectionProfile" ,container.Add );
            AddIf( null != this._virtualMachineProfile ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) this._virtualMachineProfile.ToJson(null,serializationMode) : null, "virtualMachineProfile" ,container.Add );
            AddIf( null != this._securityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) this._securityProfile.ToJson(null,serializationMode) : null, "securityProfile" ,container.Add );
            AddIf( null != this._rosterProfile ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) this._rosterProfile.ToJson(null,serializationMode) : null, "rosterProfile" ,container.Add );
            AddIf( null != (((object)this._labPlanId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._labPlanId.ToString()) : null, "labPlanId" ,container.Add );
            AddIf( null != (((object)this._title)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._title.ToString()) : null, "title" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}