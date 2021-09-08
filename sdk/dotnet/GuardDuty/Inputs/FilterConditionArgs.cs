// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GuardDuty.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html
    /// </summary>
    public sealed class FilterConditionArgs : Pulumi.ResourceArgs
    {
        [Input("eq")]
        private InputList<string>? _eq;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-eq
        /// </summary>
        public InputList<string> Eq
        {
            get => _eq ?? (_eq = new InputList<string>());
            set => _eq = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-gte
        /// </summary>
        [Input("gte")]
        public Input<int>? Gte { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-lt
        /// </summary>
        [Input("lt")]
        public Input<int>? Lt { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-lte
        /// </summary>
        [Input("lte")]
        public Input<int>? Lte { get; set; }

        [Input("neq")]
        private InputList<string>? _neq;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-neq
        /// </summary>
        public InputList<string> Neq
        {
            get => _neq ?? (_neq = new InputList<string>());
            set => _neq = value;
        }

        public FilterConditionArgs()
        {
        }
    }
}