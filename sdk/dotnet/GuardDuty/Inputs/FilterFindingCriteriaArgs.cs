// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GuardDuty.Inputs
{

    public sealed class FilterFindingCriteriaArgs : Pulumi.ResourceArgs
    {
        [Input("criterion")]
        public Input<object>? Criterion { get; set; }

        [Input("itemType")]
        public Input<Inputs.FilterConditionArgs>? ItemType { get; set; }

        public FilterFindingCriteriaArgs()
        {
        }
    }
}