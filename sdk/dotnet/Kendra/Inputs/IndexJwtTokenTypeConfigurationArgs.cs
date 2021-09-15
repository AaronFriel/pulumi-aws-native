// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Inputs
{

    public sealed class IndexJwtTokenTypeConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("claimRegex")]
        public Input<string>? ClaimRegex { get; set; }

        [Input("groupAttributeField")]
        public Input<string>? GroupAttributeField { get; set; }

        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        [Input("keyLocation", required: true)]
        public Input<string> KeyLocation { get; set; } = null!;

        [Input("secretManagerArn")]
        public Input<string>? SecretManagerArn { get; set; }

        [Input("uRL")]
        public Input<string>? URL { get; set; }

        [Input("userNameAttributeField")]
        public Input<string>? UserNameAttributeField { get; set; }

        public IndexJwtTokenTypeConfigurationArgs()
        {
        }
    }
}
