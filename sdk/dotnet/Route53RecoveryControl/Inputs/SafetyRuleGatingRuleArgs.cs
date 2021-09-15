// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryControl.Inputs
{

    /// <summary>
    /// A gating rule verifies that a set of gating controls evaluates as true, based on a rule configuration that you specify. If the gating rule evaluates to true, Amazon Route 53 Application Recovery Controller allows a set of routing control state changes to run and complete against the set of target controls.
    /// </summary>
    public sealed class SafetyRuleGatingRuleArgs : Pulumi.ResourceArgs
    {
        [Input("gatingControls", required: true)]
        private InputList<string>? _gatingControls;

        /// <summary>
        /// The gating controls for the gating rule. That is, routing controls that are evaluated by the rule configuration that you specify.
        /// </summary>
        public InputList<string> GatingControls
        {
            get => _gatingControls ?? (_gatingControls = new InputList<string>());
            set => _gatingControls = value;
        }

        [Input("targetControls", required: true)]
        private InputList<string>? _targetControls;

        /// <summary>
        /// Routing controls that can only be set or unset if the specified RuleConfig evaluates to true for the specified GatingControls. For example, say you have three gating controls, one for each of three AWS Regions. Now you specify AtLeast 2 as your RuleConfig. With these settings, you can only change (set or unset) the routing controls that you have specified as TargetControls if that rule evaluates to true. 
        /// In other words, your ability to change the routing controls that you have specified as TargetControls is gated by the rule that you set for the routing controls in GatingControls.
        /// </summary>
        public InputList<string> TargetControls
        {
            get => _targetControls ?? (_targetControls = new InputList<string>());
            set => _targetControls = value;
        }

        /// <summary>
        /// An evaluation period, in milliseconds (ms), during which any request against the target routing controls will fail. This helps prevent "flapping" of state. The wait period is 5000 ms by default, but you can choose a custom value.
        /// </summary>
        [Input("waitPeriodMs", required: true)]
        public Input<int> WaitPeriodMs { get; set; } = null!;

        public SafetyRuleGatingRuleArgs()
        {
        }
    }
}
