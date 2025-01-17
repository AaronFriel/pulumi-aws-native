// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Outputs
{

    [OutputType]
    public sealed class DataSourceConfiguration
    {
        public readonly Outputs.DataSourceConfluenceConfiguration? ConfluenceConfiguration;
        public readonly Outputs.DataSourceDatabaseConfiguration? DatabaseConfiguration;
        public readonly Outputs.DataSourceGoogleDriveConfiguration? GoogleDriveConfiguration;
        public readonly Outputs.DataSourceOneDriveConfiguration? OneDriveConfiguration;
        public readonly Outputs.DataSourceS3DataSourceConfiguration? S3Configuration;
        public readonly Outputs.DataSourceSalesforceConfiguration? SalesforceConfiguration;
        public readonly Outputs.DataSourceServiceNowConfiguration? ServiceNowConfiguration;
        public readonly Outputs.DataSourceSharePointConfiguration? SharePointConfiguration;
        public readonly Outputs.DataSourceWebCrawlerConfiguration? WebCrawlerConfiguration;
        public readonly Outputs.DataSourceWorkDocsConfiguration? WorkDocsConfiguration;

        [OutputConstructor]
        private DataSourceConfiguration(
            Outputs.DataSourceConfluenceConfiguration? confluenceConfiguration,

            Outputs.DataSourceDatabaseConfiguration? databaseConfiguration,

            Outputs.DataSourceGoogleDriveConfiguration? googleDriveConfiguration,

            Outputs.DataSourceOneDriveConfiguration? oneDriveConfiguration,

            Outputs.DataSourceS3DataSourceConfiguration? s3Configuration,

            Outputs.DataSourceSalesforceConfiguration? salesforceConfiguration,

            Outputs.DataSourceServiceNowConfiguration? serviceNowConfiguration,

            Outputs.DataSourceSharePointConfiguration? sharePointConfiguration,

            Outputs.DataSourceWebCrawlerConfiguration? webCrawlerConfiguration,

            Outputs.DataSourceWorkDocsConfiguration? workDocsConfiguration)
        {
            ConfluenceConfiguration = confluenceConfiguration;
            DatabaseConfiguration = databaseConfiguration;
            GoogleDriveConfiguration = googleDriveConfiguration;
            OneDriveConfiguration = oneDriveConfiguration;
            S3Configuration = s3Configuration;
            SalesforceConfiguration = salesforceConfiguration;
            ServiceNowConfiguration = serviceNowConfiguration;
            SharePointConfiguration = sharePointConfiguration;
            WebCrawlerConfiguration = webCrawlerConfiguration;
            WorkDocsConfiguration = workDocsConfiguration;
        }
    }
}
