// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Elasticsearch.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html
    /// </summary>
    [OutputType]
    public sealed class DomainDomainEndpointOptions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-customendpoint
        /// </summary>
        public readonly string? CustomEndpoint;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-customendpointcertificatearn
        /// </summary>
        public readonly string? CustomEndpointCertificateArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-customendpointenabled
        /// </summary>
        public readonly bool? CustomEndpointEnabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-enforcehttps
        /// </summary>
        public readonly bool? EnforceHTTPS;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticsearch-domain-domainendpointoptions.html#cfn-elasticsearch-domain-domainendpointoptions-tlssecuritypolicy
        /// </summary>
        public readonly string? TLSSecurityPolicy;

        [OutputConstructor]
        private DomainDomainEndpointOptions(
            string? customEndpoint,

            string? customEndpointCertificateArn,

            bool? customEndpointEnabled,

            bool? enforceHTTPS,

            string? tLSSecurityPolicy)
        {
            CustomEndpoint = customEndpoint;
            CustomEndpointCertificateArn = customEndpointCertificateArn;
            CustomEndpointEnabled = customEndpointEnabled;
            EnforceHTTPS = enforceHTTPS;
            TLSSecurityPolicy = tLSSecurityPolicy;
        }
    }
}