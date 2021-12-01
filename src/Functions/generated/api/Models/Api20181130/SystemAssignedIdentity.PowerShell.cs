// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Describes a system assigned identity resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemAssignedIdentityTypeConverter))]
    public partial class SystemAssignedIdentity
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemAssignedIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemAssignedIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemAssignedIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemAssignedIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentityTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecretUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientSecretUrl = (string) content.GetValueForProperty("ClientSecretUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientSecretUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemAssignedIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.SystemAssignedIdentityTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api10.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientId = (string) content.GetValueForProperty("ClientId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientId, global::System.Convert.ToString);
            }
            if (content.Contains("ClientSecretUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientSecretUrl = (string) content.GetValueForProperty("ClientSecretUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20181130.ISystemAssignedIdentityInternal)this).ClientSecretUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes a system assigned identity resource.
    [System.ComponentModel.TypeConverter(typeof(SystemAssignedIdentityTypeConverter))]
    public partial interface ISystemAssignedIdentity

    {

    }
}