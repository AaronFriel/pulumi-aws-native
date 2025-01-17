// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalyticsV2.Outputs
{

    [OutputType]
    public sealed class ApplicationInput
    {
        public readonly Outputs.ApplicationInputParallelism? InputParallelism;
        public readonly Outputs.ApplicationInputProcessingConfiguration? InputProcessingConfiguration;
        public readonly Outputs.ApplicationInputSchema InputSchema;
        public readonly Outputs.ApplicationKinesisFirehoseInput? KinesisFirehoseInput;
        public readonly Outputs.ApplicationKinesisStreamsInput? KinesisStreamsInput;
        public readonly string NamePrefix;

        [OutputConstructor]
        private ApplicationInput(
            Outputs.ApplicationInputParallelism? inputParallelism,

            Outputs.ApplicationInputProcessingConfiguration? inputProcessingConfiguration,

            Outputs.ApplicationInputSchema inputSchema,

            Outputs.ApplicationKinesisFirehoseInput? kinesisFirehoseInput,

            Outputs.ApplicationKinesisStreamsInput? kinesisStreamsInput,

            string namePrefix)
        {
            InputParallelism = inputParallelism;
            InputProcessingConfiguration = inputProcessingConfiguration;
            InputSchema = inputSchema;
            KinesisFirehoseInput = kinesisFirehoseInput;
            KinesisStreamsInput = kinesisStreamsInput;
            NamePrefix = namePrefix;
        }
    }
}
