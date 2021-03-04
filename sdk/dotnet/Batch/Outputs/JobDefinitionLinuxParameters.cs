// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Batch.Outputs
{

    [OutputType]
    public sealed class JobDefinitionLinuxParameters
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-devices
        /// </summary>
        public readonly ImmutableArray<Outputs.JobDefinitionDevice> Devices;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-initprocessenabled
        /// </summary>
        public readonly bool? InitProcessEnabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-maxswap
        /// </summary>
        public readonly int? MaxSwap;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-sharedmemorysize
        /// </summary>
        public readonly int? SharedMemorySize;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-swappiness
        /// </summary>
        public readonly int? Swappiness;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-tmpfs
        /// </summary>
        public readonly ImmutableArray<Outputs.JobDefinitionTmpfs> Tmpfs;

        [OutputConstructor]
        private JobDefinitionLinuxParameters(
            ImmutableArray<Outputs.JobDefinitionDevice> Devices,

            bool? InitProcessEnabled,

            int? MaxSwap,

            int? SharedMemorySize,

            int? Swappiness,

            ImmutableArray<Outputs.JobDefinitionTmpfs> Tmpfs)
        {
            this.Devices = Devices;
            this.InitProcessEnabled = InitProcessEnabled;
            this.MaxSwap = MaxSwap;
            this.SharedMemorySize = SharedMemorySize;
            this.Swappiness = Swappiness;
            this.Tmpfs = Tmpfs;
        }
    }
}
