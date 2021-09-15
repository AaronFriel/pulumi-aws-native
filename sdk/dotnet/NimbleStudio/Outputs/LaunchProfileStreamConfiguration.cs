// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NimbleStudio.Outputs
{

    [OutputType]
    public sealed class LaunchProfileStreamConfiguration
    {
        public readonly string ClipboardMode;
        public readonly ImmutableArray<string> Ec2InstanceTypes;
        public readonly double? MaxSessionLengthInMinutes;
        public readonly ImmutableArray<string> StreamingImageIds;

        [OutputConstructor]
        private LaunchProfileStreamConfiguration(
            string clipboardMode,

            ImmutableArray<string> ec2InstanceTypes,

            double? maxSessionLengthInMinutes,

            ImmutableArray<string> streamingImageIds)
        {
            ClipboardMode = clipboardMode;
            Ec2InstanceTypes = ec2InstanceTypes;
            MaxSessionLengthInMinutes = maxSessionLengthInMinutes;
            StreamingImageIds = streamingImageIds;
        }
    }
}
