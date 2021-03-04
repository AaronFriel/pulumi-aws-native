// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html
    /// </summary>
    public sealed class WebACLManagedRuleGroupStatementArgs : Pulumi.ResourceArgs
    {
        [Input("ExcludedRules")]
        private InputList<Inputs.WebACLExcludedRuleArgs>? _ExcludedRules;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-excludedrules
        /// </summary>
        public InputList<Inputs.WebACLExcludedRuleArgs> ExcludedRules
        {
            get => _ExcludedRules ?? (_ExcludedRules = new InputList<Inputs.WebACLExcludedRuleArgs>());
            set => _ExcludedRules = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-name
        /// </summary>
        [Input("Name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-managedrulegroupstatement.html#cfn-wafv2-webacl-managedrulegroupstatement-vendorname
        /// </summary>
        [Input("VendorName", required: true)]
        public Input<string> VendorName { get; set; } = null!;

        public WebACLManagedRuleGroupStatementArgs()
        {
        }
    }
}
