// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    [OutputType]
    public sealed class BucketWebsiteConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-errordocument
        /// </summary>
        public readonly string? ErrorDocument;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-indexdocument
        /// </summary>
        public readonly string? IndexDocument;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-redirectallrequeststo
        /// </summary>
        public readonly Outputs.BucketRedirectAllRequestsTo? RedirectAllRequestsTo;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-routingrules
        /// </summary>
        public readonly ImmutableArray<Outputs.BucketRoutingRule> RoutingRules;

        [OutputConstructor]
        private BucketWebsiteConfiguration(
            string? ErrorDocument,

            string? IndexDocument,

            Outputs.BucketRedirectAllRequestsTo? RedirectAllRequestsTo,

            ImmutableArray<Outputs.BucketRoutingRule> RoutingRules)
        {
            this.ErrorDocument = ErrorDocument;
            this.IndexDocument = IndexDocument;
            this.RedirectAllRequestsTo = RedirectAllRequestsTo;
            this.RoutingRules = RoutingRules;
        }
    }
}
