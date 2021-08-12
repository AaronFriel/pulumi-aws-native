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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html
    /// </summary>
    public sealed class DistributionForwardedValuesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-cookies
        /// </summary>
        [Input("cookies")]
        public Input<Inputs.DistributionCookiesArgs>? Cookies { get; set; }

        [Input("headers")]
        private InputList<string>? _headers;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-headers
        /// </summary>
        public InputList<string> Headers
        {
            get => _headers ?? (_headers = new InputList<string>());
            set => _headers = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-querystring
        /// </summary>
        [Input("queryString", required: true)]
        public Input<bool> QueryString { get; set; } = null!;

        [Input("queryStringCacheKeys")]
        private InputList<string>? _queryStringCacheKeys;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html#cfn-cloudfront-distribution-forwardedvalues-querystringcachekeys
        /// </summary>
        public InputList<string> QueryStringCacheKeys
        {
            get => _queryStringCacheKeys ?? (_queryStringCacheKeys = new InputList<string>());
            set => _queryStringCacheKeys = value;
        }

        public DistributionForwardedValuesArgs()
        {
        }
    }
}