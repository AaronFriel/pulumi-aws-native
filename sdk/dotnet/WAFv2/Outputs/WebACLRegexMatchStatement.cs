// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    [OutputType]
    public sealed class WebACLRegexMatchStatement
    {
        public readonly Outputs.WebACLFieldToMatch FieldToMatch;
        public readonly string RegexString;
        public readonly ImmutableArray<Outputs.WebACLTextTransformation> TextTransformations;

        [OutputConstructor]
        private WebACLRegexMatchStatement(
            Outputs.WebACLFieldToMatch fieldToMatch,

            string regexString,

            ImmutableArray<Outputs.WebACLTextTransformation> textTransformations)
        {
            FieldToMatch = fieldToMatch;
            RegexString = regexString;
            TextTransformations = textTransformations;
        }
    }
}