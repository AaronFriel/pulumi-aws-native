// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    public sealed class WebACLRegexMatchStatementArgs : Pulumi.ResourceArgs
    {
        [Input("fieldToMatch", required: true)]
        public Input<Inputs.WebACLFieldToMatchArgs> FieldToMatch { get; set; } = null!;

        [Input("regexString", required: true)]
        public Input<string> RegexString { get; set; } = null!;

        [Input("textTransformations", required: true)]
        private InputList<Inputs.WebACLTextTransformationArgs>? _textTransformations;
        public InputList<Inputs.WebACLTextTransformationArgs> TextTransformations
        {
            get => _textTransformations ?? (_textTransformations = new InputList<Inputs.WebACLTextTransformationArgs>());
            set => _textTransformations = value;
        }

        public WebACLRegexMatchStatementArgs()
        {
        }
    }
}
