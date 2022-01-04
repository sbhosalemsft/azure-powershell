// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    /// <summary>The object that describes a single Microsoft.ManagedServices operation.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplay _display;

        /// <summary>The object that represents the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.OperationDisplay()); }

        /// <summary>The description of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Description = value ?? null; }

        /// <summary>The operation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>The service provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>The resource on which the operation is performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The operation name with the format: {provider}/{resource}/{operation}</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// The object that describes a single Microsoft.ManagedServices operation.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>The description of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the operation.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>The operation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operation type.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>The service provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The service provider.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>The resource on which the operation is performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource on which the operation is performed.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>The operation name with the format: {provider}/{resource}/{operation}</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The operation name with the format: {provider}/{resource}/{operation}",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// The object that describes a single Microsoft.ManagedServices operation.
    internal partial interface IOperationInternal

    {
        /// <summary>The object that represents the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IOperationDisplay Display { get; set; }
        /// <summary>The description of the operation.</summary>
        string DisplayDescription { get; set; }
        /// <summary>The operation type.</summary>
        string DisplayOperation { get; set; }
        /// <summary>The service provider.</summary>
        string DisplayProvider { get; set; }
        /// <summary>The resource on which the operation is performed.</summary>
        string DisplayResource { get; set; }
        /// <summary>The operation name with the format: {provider}/{resource}/{operation}</summary>
        string Name { get; set; }

    }
}