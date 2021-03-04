// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html
    /// </summary>
    public sealed class StackSetOperationPreferencesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-failuretolerancecount
        /// </summary>
        [Input("FailureToleranceCount")]
        public Input<int>? FailureToleranceCount { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-failuretolerancepercentage
        /// </summary>
        [Input("FailureTolerancePercentage")]
        public Input<int>? FailureTolerancePercentage { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-maxconcurrentcount
        /// </summary>
        [Input("MaxConcurrentCount")]
        public Input<int>? MaxConcurrentCount { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-maxconcurrentpercentage
        /// </summary>
        [Input("MaxConcurrentPercentage")]
        public Input<int>? MaxConcurrentPercentage { get; set; }

        [Input("RegionOrder")]
        private InputList<string>? _RegionOrder;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-stackset-operationpreferences.html#cfn-cloudformation-stackset-operationpreferences-regionorder
        /// </summary>
        public InputList<string> RegionOrder
        {
            get => _RegionOrder ?? (_RegionOrder = new InputList<string>());
            set => _RegionOrder = value;
        }

        public StackSetOperationPreferencesArgs()
        {
        }
    }
}
