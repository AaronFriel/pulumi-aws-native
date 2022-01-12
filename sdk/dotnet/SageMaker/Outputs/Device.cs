// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// Edge device you want to create
    /// </summary>
    [OutputType]
    public sealed class Device
    {
        /// <summary>
        /// Description of the device
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The name of the device
        /// </summary>
        public readonly string DeviceName;
        /// <summary>
        /// AWS Internet of Things (IoT) object name.
        /// </summary>
        public readonly string? IotThingName;

        [OutputConstructor]
        private Device(
            string? description,

            string deviceName,

            string? iotThingName)
        {
            Description = description;
            DeviceName = deviceName;
            IotThingName = iotThingName;
        }
    }
}
