// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Outputs
{

    [OutputType]
    public sealed class OriginRequestPolicyHeadersConfig
    {
        public readonly string HeaderBehavior;
        public readonly ImmutableArray<string> Headers;

        [OutputConstructor]
        private OriginRequestPolicyHeadersConfig(
            string headerBehavior,

            ImmutableArray<string> headers)
        {
            HeaderBehavior = headerBehavior;
            Headers = headers;
        }
    }
}
