// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    public sealed class WebACLManagedRuleGroupStatementArgs : Pulumi.ResourceArgs
    {
        [Input("excludedRules")]
        private InputList<Inputs.WebACLExcludedRuleArgs>? _excludedRules;
        public InputList<Inputs.WebACLExcludedRuleArgs> ExcludedRules
        {
            get => _excludedRules ?? (_excludedRules = new InputList<Inputs.WebACLExcludedRuleArgs>());
            set => _excludedRules = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("scopeDownStatement")]
        public Input<Inputs.WebACLStatementArgs>? ScopeDownStatement { get; set; }

        [Input("vendorName", required: true)]
        public Input<string> VendorName { get; set; } = null!;

        [Input("version")]
        public Input<string>? Version { get; set; }

        public WebACLManagedRuleGroupStatementArgs()
        {
        }
    }
}
