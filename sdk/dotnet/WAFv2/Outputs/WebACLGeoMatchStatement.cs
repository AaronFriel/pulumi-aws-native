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
    public sealed class WebACLGeoMatchStatement
    {
        public readonly ImmutableArray<string> CountryCodes;
        public readonly Outputs.WebACLForwardedIPConfiguration? ForwardedIPConfig;

        [OutputConstructor]
        private WebACLGeoMatchStatement(
            ImmutableArray<string> countryCodes,

            Outputs.WebACLForwardedIPConfiguration? forwardedIPConfig)
        {
            CountryCodes = countryCodes;
            ForwardedIPConfig = forwardedIPConfig;
        }
    }
}
