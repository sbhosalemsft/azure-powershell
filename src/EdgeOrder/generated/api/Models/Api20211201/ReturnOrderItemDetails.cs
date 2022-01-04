// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Return order item request body</summary>
    public partial class ReturnOrderItemDetails :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetails,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal
    {

        /// <summary>Internal Acessors for ReturnAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal.ReturnAddress { get => (this._returnAddress = this._returnAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties()); set { {_returnAddress = value;} } }

        /// <summary>Internal Acessors for ReturnAddressValidationStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReturnOrderItemDetailsInternal.ReturnAddressValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).AddressValidationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).AddressValidationStatus = value; }

        /// <summary>Backing field for <see cref="ReturnAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties _returnAddress;

        /// <summary>customer return address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties ReturnAddress { get => (this._returnAddress = this._returnAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties()); set => this._returnAddress = value; }

        /// <summary>Contact details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails ReturnAddressContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).ContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).ContactDetail = value ?? null /* model class */; }

        /// <summary>Shipping details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress ReturnAddressShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).ShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).ShippingAddress = value ?? null /* model class */; }

        /// <summary>Status of address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? ReturnAddressValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ReturnAddress).AddressValidationStatus; }

        /// <summary>Backing field for <see cref="ReturnReason" /> property.</summary>
        private string _returnReason;

        /// <summary>Return Reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string ReturnReason { get => this._returnReason; set => this._returnReason = value; }

        /// <summary>Backing field for <see cref="ServiceTag" /> property.</summary>
        private string _serviceTag;

        /// <summary>Service tag (located on the bottom-right corner of the device)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string ServiceTag { get => this._serviceTag; set => this._serviceTag = value; }

        /// <summary>Backing field for <see cref="ShippingBoxRequired" /> property.</summary>
        private bool? _shippingBoxRequired;

        /// <summary>Shipping Box required</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public bool? ShippingBoxRequired { get => this._shippingBoxRequired; set => this._shippingBoxRequired = value; }

        /// <summary>Creates an new <see cref="ReturnOrderItemDetails" /> instance.</summary>
        public ReturnOrderItemDetails()
        {

        }
    }
    /// Return order item request body
    public partial interface IReturnOrderItemDetails :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Contact details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contact details for the address",
        SerializedName = @"contactDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails ReturnAddressContactDetail { get; set; }
        /// <summary>Shipping details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shipping details for the address",
        SerializedName = @"shippingAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress ReturnAddressShippingAddress { get; set; }
        /// <summary>Status of address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of address validation",
        SerializedName = @"addressValidationStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? ReturnAddressValidationStatus { get;  }
        /// <summary>Return Reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Return Reason.",
        SerializedName = @"returnReason",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnReason { get; set; }
        /// <summary>Service tag (located on the bottom-right corner of the device)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service tag (located on the bottom-right corner of the device)",
        SerializedName = @"serviceTag",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceTag { get; set; }
        /// <summary>Shipping Box required</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shipping Box required",
        SerializedName = @"shippingBoxRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ShippingBoxRequired { get; set; }

    }
    /// Return order item request body
    internal partial interface IReturnOrderItemDetailsInternal

    {
        /// <summary>customer return address.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties ReturnAddress { get; set; }
        /// <summary>Contact details for the address</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails ReturnAddressContactDetail { get; set; }
        /// <summary>Shipping details for the address</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress ReturnAddressShippingAddress { get; set; }
        /// <summary>Status of address validation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? ReturnAddressValidationStatus { get; set; }
        /// <summary>Return Reason.</summary>
        string ReturnReason { get; set; }
        /// <summary>Service tag (located on the bottom-right corner of the device)</summary>
        string ServiceTag { get; set; }
        /// <summary>Shipping Box required</summary>
        bool? ShippingBoxRequired { get; set; }

    }
}