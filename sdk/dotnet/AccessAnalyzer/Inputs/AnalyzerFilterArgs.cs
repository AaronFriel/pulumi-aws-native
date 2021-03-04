// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AccessAnalyzer.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html
    /// </summary>
    public sealed class AnalyzerFilterArgs : Pulumi.ResourceArgs
    {
        [Input("Contains")]
        private InputList<string>? _Contains;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-contains
        /// </summary>
        public InputList<string> Contains
        {
            get => _Contains ?? (_Contains = new InputList<string>());
            set => _Contains = value;
        }

        [Input("Eq")]
        private InputList<string>? _Eq;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-eq
        /// </summary>
        public InputList<string> Eq
        {
            get => _Eq ?? (_Eq = new InputList<string>());
            set => _Eq = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-exists
        /// </summary>
        [Input("Exists")]
        public Input<bool>? Exists { get; set; }

        [Input("Neq")]
        private InputList<string>? _Neq;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-neq
        /// </summary>
        public InputList<string> Neq
        {
            get => _Neq ?? (_Neq = new InputList<string>());
            set => _Neq = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-property
        /// </summary>
        [Input("Property", required: true)]
        public Input<string> Property { get; set; } = null!;

        public AnalyzerFilterArgs()
        {
        }
    }
}
