// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Job Properties for update</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateJobPropertiesTypeConverter))]
    public partial class UpdateJobProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateJobProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateJobProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateJobProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateJobProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobDetails) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).Detail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DetailContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails) content.GetValueForProperty("DetailContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DetailShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress) content.GetValueForProperty("DetailShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("DetailKeyEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailKeyEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey) content.GetValueForProperty("DetailKeyEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailKeyEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.KeyEncryptionKeyTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateJobProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobDetails) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).Detail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.UpdateJobDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DetailContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IContactDetails) content.GetValueForProperty("DetailContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DetailShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IShippingAddress) content.GetValueForProperty("DetailShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("DetailKeyEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailKeyEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IKeyEncryptionKey) content.GetValueForProperty("DetailKeyEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.IUpdateJobPropertiesInternal)this).DetailKeyEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20210301.KeyEncryptionKeyTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Job Properties for update
    [System.ComponentModel.TypeConverter(typeof(UpdateJobPropertiesTypeConverter))]
    public partial interface IUpdateJobProperties

    {

    }
}