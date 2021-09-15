// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// Container image configuration object for the monitoring job.
    /// </summary>
    [OutputType]
    public sealed class MonitoringScheduleMonitoringAppSpecification
    {
        /// <summary>
        /// An array of arguments for the container used to run the monitoring job.
        /// </summary>
        public readonly ImmutableArray<string> ContainerArguments;
        /// <summary>
        /// Specifies the entrypoint for a container used to run the monitoring job.
        /// </summary>
        public readonly ImmutableArray<string> ContainerEntrypoint;
        /// <summary>
        /// The container image to be run by the monitoring job.
        /// </summary>
        public readonly string ImageUri;
        /// <summary>
        /// An Amazon S3 URI to a script that is called after analysis has been performed. Applicable only for the built-in (first party) containers.
        /// </summary>
        public readonly string? PostAnalyticsProcessorSourceUri;
        /// <summary>
        /// An Amazon S3 URI to a script that is called per row prior to running analysis. It can base64 decode the payload and convert it into a flatted json so that the built-in container can use the converted data. Applicable only for the built-in (first party) containers
        /// </summary>
        public readonly string? RecordPreprocessorSourceUri;

        [OutputConstructor]
        private MonitoringScheduleMonitoringAppSpecification(
            ImmutableArray<string> containerArguments,

            ImmutableArray<string> containerEntrypoint,

            string imageUri,

            string? postAnalyticsProcessorSourceUri,

            string? recordPreprocessorSourceUri)
        {
            ContainerArguments = containerArguments;
            ContainerEntrypoint = containerEntrypoint;
            ImageUri = imageUri;
            PostAnalyticsProcessorSourceUri = postAnalyticsProcessorSourceUri;
            RecordPreprocessorSourceUri = recordPreprocessorSourceUri;
        }
    }
}
