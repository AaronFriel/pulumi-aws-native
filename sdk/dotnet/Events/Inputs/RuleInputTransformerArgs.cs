// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html
    /// </summary>
    public sealed class RuleInputTransformerArgs : Pulumi.ResourceArgs
    {
        [Input("InputPathsMap")]
        private InputMap<string>? _InputPathsMap;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html#cfn-events-rule-inputtransformer-inputpathsmap
        /// </summary>
        public InputMap<string> InputPathsMap
        {
            get => _InputPathsMap ?? (_InputPathsMap = new InputMap<string>());
            set => _InputPathsMap = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html#cfn-events-rule-inputtransformer-inputtemplate
        /// </summary>
        [Input("InputTemplate", required: true)]
        public Input<string> InputTemplate { get; set; } = null!;

        public RuleInputTransformerArgs()
        {
        }
    }
}
