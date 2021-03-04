// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalytics.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-csvmappingparameters.html
    /// </summary>
    public sealed class ApplicationCSVMappingParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-csvmappingparameters.html#cfn-kinesisanalytics-application-csvmappingparameters-recordcolumndelimiter
        /// </summary>
        [Input("RecordColumnDelimiter", required: true)]
        public Input<string> RecordColumnDelimiter { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-csvmappingparameters.html#cfn-kinesisanalytics-application-csvmappingparameters-recordrowdelimiter
        /// </summary>
        [Input("RecordRowDelimiter", required: true)]
        public Input<string> RecordRowDelimiter { get; set; } = null!;

        public ApplicationCSVMappingParametersArgs()
        {
        }
    }
}
