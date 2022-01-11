// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Budgets.Inputs
{

    public sealed class BudgetsActionSsmActionDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("instanceIds", required: true)]
        private InputList<string>? _instanceIds;
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("subtype", required: true)]
        public Input<Pulumi.AwsNative.Budgets.BudgetsActionSsmActionDefinitionSubtype> Subtype { get; set; } = null!;

        public BudgetsActionSsmActionDefinitionArgs()
        {
        }
    }
}
