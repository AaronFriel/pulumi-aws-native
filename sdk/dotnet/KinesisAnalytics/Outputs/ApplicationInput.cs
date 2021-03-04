// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalytics.Outputs
{

    [OutputType]
    public sealed class ApplicationInput
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputparallelism
        /// </summary>
        public readonly Outputs.ApplicationInputParallelism? InputParallelism;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputprocessingconfiguration
        /// </summary>
        public readonly Outputs.ApplicationInputProcessingConfiguration? InputProcessingConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputschema
        /// </summary>
        public readonly Outputs.ApplicationInputSchema InputSchema;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-kinesisfirehoseinput
        /// </summary>
        public readonly Outputs.ApplicationKinesisFirehoseInput? KinesisFirehoseInput;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-kinesisstreamsinput
        /// </summary>
        public readonly Outputs.ApplicationKinesisStreamsInput? KinesisStreamsInput;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-nameprefix
        /// </summary>
        public readonly string NamePrefix;

        [OutputConstructor]
        private ApplicationInput(
            Outputs.ApplicationInputParallelism? InputParallelism,

            Outputs.ApplicationInputProcessingConfiguration? InputProcessingConfiguration,

            Outputs.ApplicationInputSchema InputSchema,

            Outputs.ApplicationKinesisFirehoseInput? KinesisFirehoseInput,

            Outputs.ApplicationKinesisStreamsInput? KinesisStreamsInput,

            string NamePrefix)
        {
            this.InputParallelism = InputParallelism;
            this.InputProcessingConfiguration = InputProcessingConfiguration;
            this.InputSchema = InputSchema;
            this.KinesisFirehoseInput = KinesisFirehoseInput;
            this.KinesisStreamsInput = KinesisStreamsInput;
            this.NamePrefix = NamePrefix;
        }
    }
}
