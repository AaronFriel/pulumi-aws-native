// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkManager.Outputs
{

    /// <summary>
    /// The site location.
    /// </summary>
    [OutputType]
    public sealed class DeviceLocation
    {
        /// <summary>
        /// The physical address.
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// The latitude.
        /// </summary>
        public readonly string? Latitude;
        /// <summary>
        /// The longitude.
        /// </summary>
        public readonly string? Longitude;

        [OutputConstructor]
        private DeviceLocation(
            string? address,

            string? latitude,

            string? longitude)
        {
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
