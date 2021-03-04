// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Outputs
{

    [OutputType]
    public sealed class RuleGroupDimensions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-dimensions.html#cfn-networkfirewall-rulegroup-dimensions-dimensions
        /// </summary>
        public readonly ImmutableArray<Outputs.RuleGroupDimension> Dimensions;

        [OutputConstructor]
        private RuleGroupDimensions(ImmutableArray<Outputs.RuleGroupDimension> Dimensions)
        {
            this.Dimensions = Dimensions;
        }
    }
}
