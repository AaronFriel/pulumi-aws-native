// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Inputs
{

    public sealed class RulesetThresholdArgs : Pulumi.ResourceArgs
    {
        [Input("type")]
        public Input<Pulumi.AwsNative.DataBrew.RulesetThresholdType>? Type { get; set; }

        [Input("unit")]
        public Input<Pulumi.AwsNative.DataBrew.RulesetThresholdUnit>? Unit { get; set; }

        [Input("value", required: true)]
        public Input<double> Value { get; set; } = null!;

        public RulesetThresholdArgs()
        {
        }
    }
}
