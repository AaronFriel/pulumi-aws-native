// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    public sealed class WebACLIPSetReferenceStatementArgs : Pulumi.ResourceArgs
    {
        [Input("arn", required: true)]
        public Input<string> Arn { get; set; } = null!;

        [Input("iPSetForwardedIPConfig")]
        public Input<Inputs.WebACLIPSetForwardedIPConfigurationArgs>? IPSetForwardedIPConfig { get; set; }

        public WebACLIPSetReferenceStatementArgs()
        {
        }
    }
}
