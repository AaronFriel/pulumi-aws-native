// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Outputs
{

    [OutputType]
    public sealed class DataSourceSalesforceConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-chatterfeedconfiguration
        /// </summary>
        public readonly Outputs.DataSourceSalesforceChatterFeedConfiguration? ChatterFeedConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-crawlattachments
        /// </summary>
        public readonly bool? CrawlAttachments;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-excludeattachmentfilepatterns
        /// </summary>
        public readonly Outputs.DataSourceDataSourceInclusionsExclusionsStrings? ExcludeAttachmentFilePatterns;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-includeattachmentfilepatterns
        /// </summary>
        public readonly Outputs.DataSourceDataSourceInclusionsExclusionsStrings? IncludeAttachmentFilePatterns;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-knowledgearticleconfiguration
        /// </summary>
        public readonly Outputs.DataSourceSalesforceKnowledgeArticleConfiguration? KnowledgeArticleConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-secretarn
        /// </summary>
        public readonly string SecretArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-serverurl
        /// </summary>
        public readonly string ServerUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-standardobjectattachmentconfiguration
        /// </summary>
        public readonly Outputs.DataSourceSalesforceStandardObjectAttachmentConfiguration? StandardObjectAttachmentConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-salesforceconfiguration.html#cfn-kendra-datasource-salesforceconfiguration-standardobjectconfigurations
        /// </summary>
        public readonly Outputs.DataSourceSalesforceStandardObjectConfigurationList? StandardObjectConfigurations;

        [OutputConstructor]
        private DataSourceSalesforceConfiguration(
            Outputs.DataSourceSalesforceChatterFeedConfiguration? ChatterFeedConfiguration,

            bool? CrawlAttachments,

            Outputs.DataSourceDataSourceInclusionsExclusionsStrings? ExcludeAttachmentFilePatterns,

            Outputs.DataSourceDataSourceInclusionsExclusionsStrings? IncludeAttachmentFilePatterns,

            Outputs.DataSourceSalesforceKnowledgeArticleConfiguration? KnowledgeArticleConfiguration,

            string SecretArn,

            string ServerUrl,

            Outputs.DataSourceSalesforceStandardObjectAttachmentConfiguration? StandardObjectAttachmentConfiguration,

            Outputs.DataSourceSalesforceStandardObjectConfigurationList? StandardObjectConfigurations)
        {
            this.ChatterFeedConfiguration = ChatterFeedConfiguration;
            this.CrawlAttachments = CrawlAttachments;
            this.ExcludeAttachmentFilePatterns = ExcludeAttachmentFilePatterns;
            this.IncludeAttachmentFilePatterns = IncludeAttachmentFilePatterns;
            this.KnowledgeArticleConfiguration = KnowledgeArticleConfiguration;
            this.SecretArn = SecretArn;
            this.ServerUrl = ServerUrl;
            this.StandardObjectAttachmentConfiguration = StandardObjectAttachmentConfiguration;
            this.StandardObjectConfigurations = StandardObjectConfigurations;
        }
    }
}
