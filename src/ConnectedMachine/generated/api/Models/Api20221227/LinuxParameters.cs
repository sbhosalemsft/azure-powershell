// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Input for InstallPatches on a Linux VM, as directly received by the API</summary>
    public partial class LinuxParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.ILinuxParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.Api20221227.ILinuxParametersInternal
    {

        /// <summary>Backing field for <see cref="ClassificationsToInclude" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.VMGuestPatchClassificationLinux[] _classificationsToInclude;

        /// <summary>The update classifications to select when installing patches for Linux.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.VMGuestPatchClassificationLinux[] ClassificationsToInclude { get => this._classificationsToInclude; set => this._classificationsToInclude = value; }

        /// <summary>Backing field for <see cref="PackageNameMasksToExclude" /> property.</summary>
        private string[] _packageNameMasksToExclude;

        /// <summary>packages to exclude in the patch operation. Format: packageName_packageVersion</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string[] PackageNameMasksToExclude { get => this._packageNameMasksToExclude; set => this._packageNameMasksToExclude = value; }

        /// <summary>Backing field for <see cref="PackageNameMasksToInclude" /> property.</summary>
        private string[] _packageNameMasksToInclude;

        /// <summary>packages to include in the patch operation. Format: packageName_packageVersion</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string[] PackageNameMasksToInclude { get => this._packageNameMasksToInclude; set => this._packageNameMasksToInclude = value; }

        /// <summary>Creates an new <see cref="LinuxParameters" /> instance.</summary>
        public LinuxParameters()
        {

        }
    }
    /// Input for InstallPatches on a Linux VM, as directly received by the API
    public partial interface ILinuxParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>The update classifications to select when installing patches for Linux.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The update classifications to select when installing patches for Linux.",
        SerializedName = @"classificationsToInclude",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.VMGuestPatchClassificationLinux) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.VMGuestPatchClassificationLinux[] ClassificationsToInclude { get; set; }
        /// <summary>packages to exclude in the patch operation. Format: packageName_packageVersion</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"packages to exclude in the patch operation. Format: packageName_packageVersion",
        SerializedName = @"packageNameMasksToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] PackageNameMasksToExclude { get; set; }
        /// <summary>packages to include in the patch operation. Format: packageName_packageVersion</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"packages to include in the patch operation. Format: packageName_packageVersion",
        SerializedName = @"packageNameMasksToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] PackageNameMasksToInclude { get; set; }

    }
    /// Input for InstallPatches on a Linux VM, as directly received by the API
    internal partial interface ILinuxParametersInternal

    {
        /// <summary>The update classifications to select when installing patches for Linux.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Support.VMGuestPatchClassificationLinux[] ClassificationsToInclude { get; set; }
        /// <summary>packages to exclude in the patch operation. Format: packageName_packageVersion</summary>
        string[] PackageNameMasksToExclude { get; set; }
        /// <summary>packages to include in the patch operation. Format: packageName_packageVersion</summary>
        string[] PackageNameMasksToInclude { get; set; }

    }
}