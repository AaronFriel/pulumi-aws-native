// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Inputs
{

    public sealed class TopicRuleTopicRulePayloadArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<Inputs.TopicRuleActionArgs>? _actions;
        public InputList<Inputs.TopicRuleActionArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.TopicRuleActionArgs>());
            set => _actions = value;
        }

        [Input("awsIotSqlVersion")]
        public Input<string>? AwsIotSqlVersion { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("errorAction")]
        public Input<Inputs.TopicRuleActionArgs>? ErrorAction { get; set; }

        [Input("ruleDisabled")]
        public Input<bool>? RuleDisabled { get; set; }

        [Input("sql", required: true)]
        public Input<string> Sql { get; set; } = null!;

        public TopicRuleTopicRulePayloadArgs()
        {
        }
    }
}
