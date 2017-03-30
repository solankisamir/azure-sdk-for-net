// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A reference to an OS disk image.
    /// </summary>
    public partial class OSDisk
    {
        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        public OSDisk() { }

        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        /// <param name="imageUris">The collection of Virtual Hard Disk (VHD)
        /// URIs.</param>
        /// <param name="caching">The type of caching to enable for the OS
        /// disk.</param>
        public OSDisk(System.Collections.Generic.IList<string> imageUris, CachingType? caching = default(CachingType?))
        {
            ImageUris = imageUris;
            Caching = caching;
        }

        /// <summary>
        /// Gets or sets the collection of Virtual Hard Disk (VHD) URIs.
        /// </summary>
        /// <remarks>
        /// All the VHDs must be identical and must reside in an Azure Storage
        /// account within the same subscription and same region as the Batch
        /// account. For best performance, it is recommended that each VHD
        /// resides in a separate Azure Storage account. Each VHD can serve
        /// upto 20 Windows compute nodes or 40 Linux compute nodes. You must
        /// supply enough VHD URIs to satisfy the 'targetDedicated' property of
        /// the pool. If you do not supply enough VHD URIs, the pool will
        /// partially allocate compute nodes, and a resize error will occur.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "imageUris")]
        public System.Collections.Generic.IList<string> ImageUris { get; set; }

        /// <summary>
        /// Gets or sets the type of caching to enable for the OS disk.
        /// </summary>
        /// <remarks>
        /// none - The caching mode for the disk is not enabled. readOnly - The
        /// caching mode for the disk is read only. readWrite - The caching
        /// mode for the disk is read and write. The default value for caching
        /// is none. For information about the caching options see:
        /// https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.
        /// Possible values include: 'none', 'readOnly', 'readWrite'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "caching")]
        public CachingType? Caching { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ImageUris == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ImageUris");
            }
        }
    }
}
