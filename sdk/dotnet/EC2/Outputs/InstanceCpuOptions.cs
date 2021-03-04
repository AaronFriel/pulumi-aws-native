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
    public sealed class InstanceCpuOptions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-cpuoptions.html#cfn-ec2-instance-cpuoptions-corecount
        /// </summary>
        public readonly int? CoreCount;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-cpuoptions.html#cfn-ec2-instance-cpuoptions-threadspercore
        /// </summary>
        public readonly int? ThreadsPerCore;

        [OutputConstructor]
        private InstanceCpuOptions(
            int? CoreCount,

            int? ThreadsPerCore)
        {
            this.CoreCount = CoreCount;
            this.ThreadsPerCore = ThreadsPerCore;
        }
    }
}
