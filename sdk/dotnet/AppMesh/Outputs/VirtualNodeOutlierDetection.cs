// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualNodeOutlierDetection
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-baseejectionduration
        /// </summary>
        public readonly Outputs.VirtualNodeDuration BaseEjectionDuration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-interval
        /// </summary>
        public readonly Outputs.VirtualNodeDuration Interval;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-maxejectionpercent
        /// </summary>
        public readonly int MaxEjectionPercent;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-maxservererrors
        /// </summary>
        public readonly int MaxServerErrors;

        [OutputConstructor]
        private VirtualNodeOutlierDetection(
            Outputs.VirtualNodeDuration BaseEjectionDuration,

            Outputs.VirtualNodeDuration Interval,

            int MaxEjectionPercent,

            int MaxServerErrors)
        {
            this.BaseEjectionDuration = BaseEjectionDuration;
            this.Interval = Interval;
            this.MaxEjectionPercent = MaxEjectionPercent;
            this.MaxServerErrors = MaxServerErrors;
        }
    }
}
