// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAF.Inputs
{

    public sealed class XssMatchSetXssMatchTupleArgs : Pulumi.ResourceArgs
    {
        [Input("fieldToMatch", required: true)]
        public Input<Inputs.XssMatchSetFieldToMatchArgs> FieldToMatch { get; set; } = null!;

        [Input("textTransformation", required: true)]
        public Input<string> TextTransformation { get; set; } = null!;

        public XssMatchSetXssMatchTupleArgs()
        {
        }
    }
}
