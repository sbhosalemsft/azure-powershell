// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>New plans notification details</summary>
    public partial class NewNotifications :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.INewNotifications,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.INewNotificationsInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Gets offer display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private string _icon;

        /// <summary>Gets or sets the icon url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Icon { get => this._icon; set => this._icon = value; }

        /// <summary>Backing field for <see cref="IsFuturePlansEnabled" /> property.</summary>
        private bool? _isFuturePlansEnabled;

        /// <summary>Gets a value indicating whether future plans is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public bool? IsFuturePlansEnabled { get => this._isFuturePlansEnabled; set => this._isFuturePlansEnabled = value; }

        /// <summary>Backing field for <see cref="MessageCode" /> property.</summary>
        private long? _messageCode;

        /// <summary>Gets or sets the notification message id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public long? MessageCode { get => this._messageCode; set => this._messageCode = value; }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Gets offer id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] _plan;

        /// <summary>Gets or sets removed plans notifications</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] Plan { get => this._plan; set => this._plan = value; }

        /// <summary>Creates an new <see cref="NewNotifications" /> instance.</summary>
        public NewNotifications()
        {

        }
    }
    /// New plans notification details
    public partial interface INewNotifications :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets offer display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets offer display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Gets or sets the icon url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the icon url",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string Icon { get; set; }
        /// <summary>Gets a value indicating whether future plans is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets a value indicating whether future plans is enabled.",
        SerializedName = @"isFuturePlansEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsFuturePlansEnabled { get; set; }
        /// <summary>Gets or sets the notification message id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the notification message id",
        SerializedName = @"messageCode",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageCode { get; set; }
        /// <summary>Gets offer id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets offer id",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>Gets or sets removed plans notifications</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets removed plans notifications",
        SerializedName = @"plans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] Plan { get; set; }

    }
    /// New plans notification details
    internal partial interface INewNotificationsInternal

    {
        /// <summary>Gets offer display name</summary>
        string DisplayName { get; set; }
        /// <summary>Gets or sets the icon url</summary>
        string Icon { get; set; }
        /// <summary>Gets a value indicating whether future plans is enabled.</summary>
        bool? IsFuturePlansEnabled { get; set; }
        /// <summary>Gets or sets the notification message id</summary>
        long? MessageCode { get; set; }
        /// <summary>Gets offer id</summary>
        string OfferId { get; set; }
        /// <summary>Gets or sets removed plans notifications</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] Plan { get; set; }

    }
}