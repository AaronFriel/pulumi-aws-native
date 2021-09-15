// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Inputs
{

    public sealed class RuleGroupStatelessRulesAndCustomActionsArgs : Pulumi.ResourceArgs
    {
        [Input("customActions")]
        private InputList<Inputs.RuleGroupCustomActionArgs>? _customActions;
        public InputList<Inputs.RuleGroupCustomActionArgs> CustomActions
        {
            get => _customActions ?? (_customActions = new InputList<Inputs.RuleGroupCustomActionArgs>());
            set => _customActions = value;
        }

        [Input("statelessRules", required: true)]
        private InputList<Inputs.RuleGroupStatelessRuleArgs>? _statelessRules;
        public InputList<Inputs.RuleGroupStatelessRuleArgs> StatelessRules
        {
            get => _statelessRules ?? (_statelessRules = new InputList<Inputs.RuleGroupStatelessRuleArgs>());
            set => _statelessRules = value;
        }

        public RuleGroupStatelessRulesAndCustomActionsArgs()
        {
        }
    }
}
