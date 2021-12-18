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
    public sealed class DistributionOrigin
    {
        public readonly int? ConnectionAttempts;
        public readonly int? ConnectionTimeout;
        public readonly Outputs.DistributionCustomOriginConfig? CustomOriginConfig;
        public readonly string DomainName;
        public readonly string Id;
        public readonly ImmutableArray<Outputs.DistributionOriginCustomHeader> OriginCustomHeaders;
        public readonly string? OriginPath;
        public readonly Outputs.DistributionOriginShield? OriginShield;
        public readonly Outputs.DistributionS3OriginConfig? S3OriginConfig;

        [OutputConstructor]
        private DistributionOrigin(
            int? connectionAttempts,

            int? connectionTimeout,

            Outputs.DistributionCustomOriginConfig? customOriginConfig,

            string domainName,

            string id,

            ImmutableArray<Outputs.DistributionOriginCustomHeader> originCustomHeaders,

            string? originPath,

            Outputs.DistributionOriginShield? originShield,

            Outputs.DistributionS3OriginConfig? s3OriginConfig)
        {
            ConnectionAttempts = connectionAttempts;
            ConnectionTimeout = connectionTimeout;
            CustomOriginConfig = customOriginConfig;
            DomainName = domainName;
            Id = id;
            OriginCustomHeaders = originCustomHeaders;
            OriginPath = originPath;
            OriginShield = originShield;
            S3OriginConfig = s3OriginConfig;
        }
    }
}
