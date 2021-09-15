// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    /// <summary>
    /// Xss Match Statement.
    /// </summary>
    [OutputType]
    public sealed class WebACLXssMatchStatement
    {
        public readonly Outputs.WebACLFieldToMatch FieldToMatch;
        public readonly ImmutableArray<Outputs.WebACLTextTransformation> TextTransformations;

        [OutputConstructor]
        private WebACLXssMatchStatement(
            Outputs.WebACLFieldToMatch fieldToMatch,

            ImmutableArray<Outputs.WebACLTextTransformation> textTransformations)
        {
            FieldToMatch = fieldToMatch;
            TextTransformations = textTransformations;
        }
    }
}
