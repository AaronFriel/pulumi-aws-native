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
    public sealed class NetworkInsightsAnalysisPortRange
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html#cfn-ec2-networkinsightsanalysis-portrange-from
        /// </summary>
        public readonly int? From;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightsanalysis-portrange.html#cfn-ec2-networkinsightsanalysis-portrange-to
        /// </summary>
        public readonly int? To;

        [OutputConstructor]
        private NetworkInsightsAnalysisPortRange(
            int? From,

            int? To)
        {
            this.From = From;
            this.To = To;
        }
    }
}
