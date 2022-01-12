// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Outputs
{

    [OutputType]
    public sealed class DistributionLogging
    {
        public readonly string Bucket;
        public readonly bool? IncludeCookies;
        public readonly string? Prefix;

        [OutputConstructor]
        private DistributionLogging(
            string bucket,

            bool? includeCookies,

            string? prefix)
        {
            Bucket = bucket;
            IncludeCookies = includeCookies;
            Prefix = prefix;
        }
    }
}
