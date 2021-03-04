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
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html#cfn-cloudfront-originrequestpolicy-headersconfig-headerbehavior
        /// </summary>
        public readonly string HeaderBehavior;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-headersconfig.html#cfn-cloudfront-originrequestpolicy-headersconfig-headers
        /// </summary>
        public readonly ImmutableArray<string> Headers;

        [OutputConstructor]
        private OriginRequestPolicyHeadersConfig(
            string HeaderBehavior,

            ImmutableArray<string> Headers)
        {
            this.HeaderBehavior = HeaderBehavior;
            this.Headers = Headers;
        }
    }
}
