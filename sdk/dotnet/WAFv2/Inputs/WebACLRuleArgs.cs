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
    /// Rule of WebACL that contains condition and action.
    /// </summary>
    public sealed class WebACLRuleArgs : Pulumi.ResourceArgs
    {
        [Input("action")]
        public Input<Inputs.WebACLRuleActionArgs>? Action { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("overrideAction")]
        public Input<Inputs.WebACLOverrideActionArgs>? OverrideAction { get; set; }

        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        [Input("ruleLabels")]
        private InputList<Inputs.WebACLLabelArgs>? _ruleLabels;

        /// <summary>
        /// Collection of Rule Labels.
        /// </summary>
        public InputList<Inputs.WebACLLabelArgs> RuleLabels
        {
            get => _ruleLabels ?? (_ruleLabels = new InputList<Inputs.WebACLLabelArgs>());
            set => _ruleLabels = value;
        }

        [Input("statement", required: true)]
        public Input<Inputs.WebACLStatementArgs> Statement { get; set; } = null!;

        [Input("visibilityConfig", required: true)]
        public Input<Inputs.WebACLVisibilityConfigArgs> VisibilityConfig { get; set; } = null!;

        public WebACLRuleArgs()
        {
        }
    }
}
