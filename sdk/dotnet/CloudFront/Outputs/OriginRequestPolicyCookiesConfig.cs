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
    public sealed class OriginRequestPolicyCookiesConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-cookiesconfig.html#cfn-cloudfront-originrequestpolicy-cookiesconfig-cookiebehavior
        /// </summary>
        public readonly string CookieBehavior;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-originrequestpolicy-cookiesconfig.html#cfn-cloudfront-originrequestpolicy-cookiesconfig-cookies
        /// </summary>
        public readonly ImmutableArray<string> Cookies;

        [OutputConstructor]
        private OriginRequestPolicyCookiesConfig(
            string CookieBehavior,

            ImmutableArray<string> Cookies)
        {
            this.CookieBehavior = CookieBehavior;
            this.Cookies = Cookies;
        }
    }
}
