// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LookoutEquipment.Inputs
{

    /// <summary>
    /// Specifies configuration information for the input data for the inference scheduler, including delimiter, format, and dataset location.
    /// </summary>
    public sealed class DataInputConfigurationPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("inferenceInputNameConfiguration")]
        public Input<Inputs.InferenceSchedulerInputNameConfigurationArgs>? InferenceInputNameConfiguration { get; set; }

        /// <summary>
        /// Indicates the difference between your time zone and Greenwich Mean Time (GMT).
        /// </summary>
        [Input("inputTimeZoneOffset")]
        public Input<string>? InputTimeZoneOffset { get; set; }

        [Input("s3InputConfiguration", required: true)]
        public Input<Inputs.InferenceSchedulerS3InputConfigurationArgs> S3InputConfiguration { get; set; } = null!;

        public DataInputConfigurationPropertiesArgs()
        {
        }
    }
}