// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html
    /// </summary>
    public sealed class BucketInventoryConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-destination
        /// </summary>
        [Input("Destination", required: true)]
        public Input<Inputs.BucketDestinationArgs> Destination { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-enabled
        /// </summary>
        [Input("Enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-id
        /// </summary>
        [Input("Id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-includedobjectversions
        /// </summary>
        [Input("IncludedObjectVersions", required: true)]
        public Input<string> IncludedObjectVersions { get; set; } = null!;

        [Input("OptionalFields")]
        private InputList<string>? _OptionalFields;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-optionalfields
        /// </summary>
        public InputList<string> OptionalFields
        {
            get => _OptionalFields ?? (_OptionalFields = new InputList<string>());
            set => _OptionalFields = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-prefix
        /// </summary>
        [Input("Prefix")]
        public Input<string>? Prefix { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-inventoryconfiguration.html#cfn-s3-bucket-inventoryconfiguration-schedulefrequency
        /// </summary>
        [Input("ScheduleFrequency", required: true)]
        public Input<string> ScheduleFrequency { get; set; } = null!;

        public BucketInventoryConfigurationArgs()
        {
        }
    }
}
