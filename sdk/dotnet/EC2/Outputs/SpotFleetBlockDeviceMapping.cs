// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    [OutputType]
    public sealed class SpotFleetBlockDeviceMapping
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-devicename
        /// </summary>
        public readonly string DeviceName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-ebs
        /// </summary>
        public readonly Outputs.SpotFleetEbsBlockDevice? Ebs;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-nodevice
        /// </summary>
        public readonly string? NoDevice;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-virtualname
        /// </summary>
        public readonly string? VirtualName;

        [OutputConstructor]
        private SpotFleetBlockDeviceMapping(
            string DeviceName,

            Outputs.SpotFleetEbsBlockDevice? Ebs,

            string? NoDevice,

            string? VirtualName)
        {
            this.DeviceName = DeviceName;
            this.Ebs = Ebs;
            this.NoDevice = NoDevice;
            this.VirtualName = VirtualName;
        }
    }
}
