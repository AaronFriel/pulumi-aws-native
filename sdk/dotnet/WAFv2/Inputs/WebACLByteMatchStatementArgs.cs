// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// Byte Match statement.
    /// </summary>
    public sealed class WebACLByteMatchStatementArgs : Pulumi.ResourceArgs
    {
        [Input("fieldToMatch", required: true)]
        public Input<Inputs.WebACLFieldToMatchArgs> FieldToMatch { get; set; } = null!;

        [Input("positionalConstraint", required: true)]
        public Input<Pulumi.AwsNative.WAFv2.WebACLPositionalConstraint> PositionalConstraint { get; set; } = null!;

        [Input("searchString")]
        public Input<string>? SearchString { get; set; }

        [Input("searchStringBase64")]
        public Input<string>? SearchStringBase64 { get; set; }

        [Input("textTransformations", required: true)]
        private InputList<Inputs.WebACLTextTransformationArgs>? _textTransformations;
        public InputList<Inputs.WebACLTextTransformationArgs> TextTransformations
        {
            get => _textTransformations ?? (_textTransformations = new InputList<Inputs.WebACLTextTransformationArgs>());
            set => _textTransformations = value;
        }

        public WebACLByteMatchStatementArgs()
        {
        }
    }
}
