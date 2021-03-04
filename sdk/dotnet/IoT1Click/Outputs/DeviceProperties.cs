// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT1Click.Outputs
{

    [OutputType]
    public sealed class DeviceProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-device.html#cfn-iot1click-device-deviceid
        /// </summary>
        public readonly string DeviceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-device.html#cfn-iot1click-device-enabled
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private DeviceProperties(
            string DeviceId,

            bool Enabled)
        {
            this.DeviceId = DeviceId;
            this.Enabled = Enabled;
        }
    }
}
