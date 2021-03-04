// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portranges.html
    /// </summary>
    public sealed class RuleGroupPortRangesArgs : Pulumi.ResourceArgs
    {
        [Input("PortRanges")]
        private InputList<Inputs.RuleGroupPortRangeArgs>? _PortRanges;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portranges.html#cfn-networkfirewall-rulegroup-portranges-portranges
        /// </summary>
        public InputList<Inputs.RuleGroupPortRangeArgs> PortRanges
        {
            get => _PortRanges ?? (_PortRanges = new InputList<Inputs.RuleGroupPortRangeArgs>());
            set => _PortRanges = value;
        }

        public RuleGroupPortRangesArgs()
        {
        }
    }
}
