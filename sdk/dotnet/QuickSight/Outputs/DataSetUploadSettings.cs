// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html
    /// </summary>
    [OutputType]
    public sealed class DataSetUploadSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-containsheader
        /// </summary>
        public readonly bool? ContainsHeader;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-delimiter
        /// </summary>
        public readonly string? Delimiter;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-format
        /// </summary>
        public readonly string? Format;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-startfromrow
        /// </summary>
        public readonly double? StartFromRow;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dataset-uploadsettings.html#cfn-quicksight-dataset-uploadsettings-textqualifier
        /// </summary>
        public readonly string? TextQualifier;

        [OutputConstructor]
        private DataSetUploadSettings(
            bool? containsHeader,

            string? delimiter,

            string? format,

            double? startFromRow,

            string? textQualifier)
        {
            ContainsHeader = containsHeader;
            Delimiter = delimiter;
            Format = format;
            StartFromRow = startFromRow;
            TextQualifier = textQualifier;
        }
    }
}