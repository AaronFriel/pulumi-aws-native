// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalytics.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html
    /// </summary>
    [OutputType]
    public sealed class ApplicationReferenceDataSourceReferenceSchema
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalytics-applicationreferencedatasource-referenceschema-recordcolumns
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationReferenceDataSourceRecordColumn> RecordColumns;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalytics-applicationreferencedatasource-referenceschema-recordencoding
        /// </summary>
        public readonly string? RecordEncoding;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-referenceschema.html#cfn-kinesisanalytics-applicationreferencedatasource-referenceschema-recordformat
        /// </summary>
        public readonly Outputs.ApplicationReferenceDataSourceRecordFormat RecordFormat;

        [OutputConstructor]
        private ApplicationReferenceDataSourceReferenceSchema(
            ImmutableArray<Outputs.ApplicationReferenceDataSourceRecordColumn> recordColumns,

            string? recordEncoding,

            Outputs.ApplicationReferenceDataSourceRecordFormat recordFormat)
        {
            RecordColumns = recordColumns;
            RecordEncoding = recordEncoding;
            RecordFormat = recordFormat;
        }
    }
}