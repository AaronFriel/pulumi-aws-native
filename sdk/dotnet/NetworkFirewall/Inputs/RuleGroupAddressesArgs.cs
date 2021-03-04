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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-addresses.html
    /// </summary>
    public sealed class RuleGroupAddressesArgs : Pulumi.ResourceArgs
    {
        [Input("Addresses")]
        private InputList<Inputs.RuleGroupAddressArgs>? _Addresses;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-addresses.html#cfn-networkfirewall-rulegroup-addresses-addresses
        /// </summary>
        public InputList<Inputs.RuleGroupAddressArgs> Addresses
        {
            get => _Addresses ?? (_Addresses = new InputList<Inputs.RuleGroupAddressArgs>());
            set => _Addresses = value;
        }

        public RuleGroupAddressesArgs()
        {
        }
    }
}
