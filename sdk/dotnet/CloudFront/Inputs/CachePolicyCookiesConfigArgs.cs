// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cookiesconfig.html
    /// </summary>
    public sealed class CachePolicyCookiesConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cookiesconfig.html#cfn-cloudfront-cachepolicy-cookiesconfig-cookiebehavior
        /// </summary>
        [Input("CookieBehavior", required: true)]
        public Input<string> CookieBehavior { get; set; } = null!;

        [Input("Cookies")]
        private InputList<string>? _Cookies;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-cookiesconfig.html#cfn-cloudfront-cachepolicy-cookiesconfig-cookies
        /// </summary>
        public InputList<string> Cookies
        {
            get => _Cookies ?? (_Cookies = new InputList<string>());
            set => _Cookies = value;
        }

        public CachePolicyCookiesConfigArgs()
        {
        }
    }
}
