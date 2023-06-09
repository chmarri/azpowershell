// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Extensions;

    /// <summary>Backup Configuration</summary>
    public partial class BackupConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfigurationInternal
    {

        /// <summary>Storage Account Key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string AzureBlobAccountKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlobAccountKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlobAccountKey = value ?? null; }

        /// <summary>Blob container name where backups are stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string AzureBlobContainerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlobContainerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlobContainerName = value ?? null; }

        /// <summary>Resource Id of the storage account where backups are stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string AzureBlobStorageAccountResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlobStorageAccountResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlobStorageAccountResourceId = value ?? null; }

        /// <summary>Password for username to access file share location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public System.Security.SecureString FileSharePassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileSharePassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileSharePassword = value ?? null; }

        /// <summary>Location as SMB share or local drive where backups are placed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string FileSharePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileSharePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileSharePath = value ?? null; }

        /// <summary>Username to access the file share location for backups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string FileShareUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileShareUsername; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileShareUsername = value ?? null; }

        /// <summary>Internal Acessors for SourceLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfigurationInternal.SourceLocation { get => (this._sourceLocation = this._sourceLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SourceLocation()); set { {_sourceLocation = value;} } }

        /// <summary>Internal Acessors for SourceLocationAzureBlob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IAzureBlob Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfigurationInternal.SourceLocationAzureBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlob; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).AzureBlob = value; }

        /// <summary>Internal Acessors for SourceLocationFileShare</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISqlFileShare Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfigurationInternal.SourceLocationFileShare { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileShare; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileShare = value; }

        /// <summary>Internal Acessors for SourceLocationFileStorageType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfigurationInternal.SourceLocationFileStorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileStorageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileStorageType = value; }

        /// <summary>Internal Acessors for TargetLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocation Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IBackupConfigurationInternal.TargetLocation { get => (this._targetLocation = this._targetLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.TargetLocation()); set { {_targetLocation = value;} } }

        /// <summary>Backing field for <see cref="SourceLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation _sourceLocation;

        /// <summary>Source location of backups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation SourceLocation { get => (this._sourceLocation = this._sourceLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SourceLocation()); set => this._sourceLocation = value; }

        /// <summary>Backup storage Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string SourceLocationFileStorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)SourceLocation).FileStorageType; }

        /// <summary>Backing field for <see cref="TargetLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocation _targetLocation;

        /// <summary>Target location for copying backups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocation TargetLocation { get => (this._targetLocation = this._targetLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.TargetLocation()); set => this._targetLocation = value; }

        /// <summary>Storage Account Key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string TargetLocationAccountKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocationInternal)TargetLocation).AccountKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocationInternal)TargetLocation).AccountKey = value ?? null; }

        /// <summary>Resource Id of the storage account copying backups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string TargetLocationStorageAccountResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocationInternal)TargetLocation).StorageAccountResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocationInternal)TargetLocation).StorageAccountResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="BackupConfiguration" /> instance.</summary>
        public BackupConfiguration()
        {

        }
    }
    /// Backup Configuration
    public partial interface IBackupConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.IJsonSerializable
    {
        /// <summary>Storage Account Key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Storage Account Key.",
        SerializedName = @"accountKey",
        PossibleTypes = new [] { typeof(string) })]
        string AzureBlobAccountKey { get; set; }
        /// <summary>Blob container name where backups are stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Blob container name where backups are stored.",
        SerializedName = @"blobContainerName",
        PossibleTypes = new [] { typeof(string) })]
        string AzureBlobContainerName { get; set; }
        /// <summary>Resource Id of the storage account where backups are stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id of the storage account where backups are stored.",
        SerializedName = @"storageAccountResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureBlobStorageAccountResourceId { get; set; }
        /// <summary>Password for username to access file share location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password for username to access file share location.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString FileSharePassword { get; set; }
        /// <summary>Location as SMB share or local drive where backups are placed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location as SMB share or local drive where backups are placed.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string FileSharePath { get; set; }
        /// <summary>Username to access the file share location for backups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Username to access the file share location for backups.",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string FileShareUsername { get; set; }
        /// <summary>Backup storage Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Backup storage Type.",
        SerializedName = @"fileStorageType",
        PossibleTypes = new [] { typeof(string) })]
        string SourceLocationFileStorageType { get;  }
        /// <summary>Storage Account Key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Storage Account Key.",
        SerializedName = @"accountKey",
        PossibleTypes = new [] { typeof(string) })]
        string TargetLocationAccountKey { get; set; }
        /// <summary>Resource Id of the storage account copying backups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id of the storage account copying backups.",
        SerializedName = @"storageAccountResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetLocationStorageAccountResourceId { get; set; }

    }
    /// Backup Configuration
    internal partial interface IBackupConfigurationInternal

    {
        /// <summary>Storage Account Key.</summary>
        string AzureBlobAccountKey { get; set; }
        /// <summary>Blob container name where backups are stored.</summary>
        string AzureBlobContainerName { get; set; }
        /// <summary>Resource Id of the storage account where backups are stored.</summary>
        string AzureBlobStorageAccountResourceId { get; set; }
        /// <summary>Password for username to access file share location.</summary>
        System.Security.SecureString FileSharePassword { get; set; }
        /// <summary>Location as SMB share or local drive where backups are placed.</summary>
        string FileSharePath { get; set; }
        /// <summary>Username to access the file share location for backups.</summary>
        string FileShareUsername { get; set; }
        /// <summary>Source location of backups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation SourceLocation { get; set; }
        /// <summary>Source Azure Blob.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IAzureBlob SourceLocationAzureBlob { get; set; }
        /// <summary>Source File share.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISqlFileShare SourceLocationFileShare { get; set; }
        /// <summary>Backup storage Type.</summary>
        string SourceLocationFileStorageType { get; set; }
        /// <summary>Target location for copying backups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ITargetLocation TargetLocation { get; set; }
        /// <summary>Storage Account Key.</summary>
        string TargetLocationAccountKey { get; set; }
        /// <summary>Resource Id of the storage account copying backups.</summary>
        string TargetLocationStorageAccountResourceId { get; set; }

    }
}