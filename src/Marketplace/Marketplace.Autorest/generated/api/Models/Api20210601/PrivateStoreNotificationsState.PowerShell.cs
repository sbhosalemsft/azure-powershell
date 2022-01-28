// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.PowerShell;

    /// <summary>Get private store notifications state</summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateStoreNotificationsStateTypeConverter))]
    public partial class PrivateStoreNotificationsState
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.PrivateStoreNotificationsState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsState"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsState DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateStoreNotificationsState(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.PrivateStoreNotificationsState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsState"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsState DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateStoreNotificationsState(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateStoreNotificationsState" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsState FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.PrivateStoreNotificationsState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateStoreNotificationsState(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StopSellNotification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).StopSellNotification = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IStopSellNotifications[]) content.GetValueForProperty("StopSellNotification",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).StopSellNotification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IStopSellNotifications>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.StopSellNotificationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("NewNotification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).NewNotification = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.INewNotifications[]) content.GetValueForProperty("NewNotification",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).NewNotification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.INewNotifications>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.NewNotificationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApprovalRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).ApprovalRequest = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IRequestApprovalsDetails[]) content.GetValueForProperty("ApprovalRequest",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).ApprovalRequest, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IRequestApprovalsDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.RequestApprovalsDetailsTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.PrivateStoreNotificationsState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateStoreNotificationsState(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("StopSellNotification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).StopSellNotification = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IStopSellNotifications[]) content.GetValueForProperty("StopSellNotification",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).StopSellNotification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IStopSellNotifications>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.StopSellNotificationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("NewNotification"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).NewNotification = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.INewNotifications[]) content.GetValueForProperty("NewNotification",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).NewNotification, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.INewNotifications>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.NewNotificationsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ApprovalRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).ApprovalRequest = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IRequestApprovalsDetails[]) content.GetValueForProperty("ApprovalRequest",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPrivateStoreNotificationsStateInternal)this).ApprovalRequest, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IRequestApprovalsDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.RequestApprovalsDetailsTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Get private store notifications state
    [System.ComponentModel.TypeConverter(typeof(PrivateStoreNotificationsStateTypeConverter))]
    public partial interface IPrivateStoreNotificationsState

    {

    }
}