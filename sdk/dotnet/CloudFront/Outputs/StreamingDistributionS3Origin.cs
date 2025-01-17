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
    public sealed class StreamingDistributionS3Origin
    {
        public readonly string DomainName;
        public readonly string OriginAccessIdentity;

        [OutputConstructor]
        private StreamingDistributionS3Origin(
            string domainName,

            string originAccessIdentity)
        {
            DomainName = domainName;
            OriginAccessIdentity = originAccessIdentity;
        }
    }
}
