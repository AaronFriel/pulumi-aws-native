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
    public sealed class DistributionLegacyS3Origin
    {
        public readonly string DNSName;
        public readonly string? OriginAccessIdentity;

        [OutputConstructor]
        private DistributionLegacyS3Origin(
            string dNSName,

            string? originAccessIdentity)
        {
            DNSName = dNSName;
            OriginAccessIdentity = originAccessIdentity;
        }
    }
}
