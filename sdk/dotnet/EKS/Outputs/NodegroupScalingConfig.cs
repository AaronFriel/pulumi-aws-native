// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EKS.Outputs
{

    [OutputType]
    public sealed class NodegroupScalingConfig
    {
        public readonly double? DesiredSize;
        public readonly double? MaxSize;
        public readonly double? MinSize;

        [OutputConstructor]
        private NodegroupScalingConfig(
            double? desiredSize,

            double? maxSize,

            double? minSize)
        {
            DesiredSize = desiredSize;
            MaxSize = maxSize;
            MinSize = minSize;
        }
    }
}
