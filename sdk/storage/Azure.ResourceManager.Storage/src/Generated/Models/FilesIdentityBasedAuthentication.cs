// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Settings for Azure Files identity based authentication. </summary>
    public partial class FilesIdentityBasedAuthentication
    {
        /// <summary> Initializes a new instance of FilesIdentityBasedAuthentication. </summary>
        /// <param name="directoryServiceOptions"> Indicates the directory service used. Note that this enum may be extended in the future. </param>
        public FilesIdentityBasedAuthentication(DirectoryServiceOption directoryServiceOptions)
        {
            DirectoryServiceOptions = directoryServiceOptions;
        }

        /// <summary> Initializes a new instance of FilesIdentityBasedAuthentication. </summary>
        /// <param name="directoryServiceOptions"> Indicates the directory service used. Note that this enum may be extended in the future. </param>
        /// <param name="activeDirectoryProperties"> Required if directoryServiceOptions are AD, optional if they are AADKERB. </param>
        /// <param name="defaultSharePermission"> Default share permission for users using Kerberos authentication if RBAC role is not assigned. </param>
        internal FilesIdentityBasedAuthentication(DirectoryServiceOption directoryServiceOptions, StorageActiveDirectoryProperties activeDirectoryProperties, DefaultSharePermission? defaultSharePermission)
        {
            DirectoryServiceOptions = directoryServiceOptions;
            ActiveDirectoryProperties = activeDirectoryProperties;
            DefaultSharePermission = defaultSharePermission;
        }

        /// <summary> Indicates the directory service used. Note that this enum may be extended in the future. </summary>
        public DirectoryServiceOption DirectoryServiceOptions { get; set; }
        /// <summary> Required if directoryServiceOptions are AD, optional if they are AADKERB. </summary>
        public StorageActiveDirectoryProperties ActiveDirectoryProperties { get; set; }
        /// <summary> Default share permission for users using Kerberos authentication if RBAC role is not assigned. </summary>
        public DefaultSharePermission? DefaultSharePermission { get; set; }
    }
}
