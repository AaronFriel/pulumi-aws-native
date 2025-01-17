// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Outputs
{

    /// <summary>
    /// S3 data source configuration
    /// </summary>
    [OutputType]
    public sealed class DataSourceS3DataSourceConfiguration
    {
        public readonly Outputs.DataSourceAccessControlListConfiguration? AccessControlListConfiguration;
        public readonly string BucketName;
        public readonly Outputs.DataSourceDocumentsMetadataConfiguration? DocumentsMetadataConfiguration;
        public readonly ImmutableArray<string> ExclusionPatterns;
        public readonly ImmutableArray<string> InclusionPatterns;
        public readonly ImmutableArray<string> InclusionPrefixes;

        [OutputConstructor]
        private DataSourceS3DataSourceConfiguration(
            Outputs.DataSourceAccessControlListConfiguration? accessControlListConfiguration,

            string bucketName,

            Outputs.DataSourceDocumentsMetadataConfiguration? documentsMetadataConfiguration,

            ImmutableArray<string> exclusionPatterns,

            ImmutableArray<string> inclusionPatterns,

            ImmutableArray<string> inclusionPrefixes)
        {
            AccessControlListConfiguration = accessControlListConfiguration;
            BucketName = bucketName;
            DocumentsMetadataConfiguration = documentsMetadataConfiguration;
            ExclusionPatterns = exclusionPatterns;
            InclusionPatterns = inclusionPatterns;
            InclusionPrefixes = inclusionPrefixes;
        }
    }
}
