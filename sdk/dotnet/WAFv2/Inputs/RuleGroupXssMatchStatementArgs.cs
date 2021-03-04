// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html
    /// </summary>
    public sealed class RuleGroupXssMatchStatementArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-fieldtomatch
        /// </summary>
        [Input("FieldToMatch", required: true)]
        public Input<Inputs.RuleGroupFieldToMatchArgs> FieldToMatch { get; set; } = null!;

        [Input("TextTransformations", required: true)]
        private InputList<Inputs.RuleGroupTextTransformationArgs>? _TextTransformations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-xssmatchstatement.html#cfn-wafv2-rulegroup-xssmatchstatement-texttransformations
        /// </summary>
        public InputList<Inputs.RuleGroupTextTransformationArgs> TextTransformations
        {
            get => _TextTransformations ?? (_TextTransformations = new InputList<Inputs.RuleGroupTextTransformationArgs>());
            set => _TextTransformations = value;
        }

        public RuleGroupXssMatchStatementArgs()
        {
        }
    }
}
