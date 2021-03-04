// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFRegional.Outputs
{

    [OutputType]
    public sealed class XssMatchSetXssMatchTuple
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-fieldtomatch
        /// </summary>
        public readonly Outputs.XssMatchSetFieldToMatch FieldToMatch;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-texttransformation
        /// </summary>
        public readonly string TextTransformation;

        [OutputConstructor]
        private XssMatchSetXssMatchTuple(
            Outputs.XssMatchSetFieldToMatch FieldToMatch,

            string TextTransformation)
        {
            this.FieldToMatch = FieldToMatch;
            this.TextTransformation = TextTransformation;
        }
    }
}
