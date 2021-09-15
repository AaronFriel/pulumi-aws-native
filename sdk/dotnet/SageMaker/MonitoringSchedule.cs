// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker
{
    /// <summary>
    /// Resource Type definition for AWS::SageMaker::MonitoringSchedule
    /// </summary>
    [AwsNativeResourceType("aws-native:sagemaker:MonitoringSchedule")]
    public partial class MonitoringSchedule : Pulumi.CustomResource
    {
        /// <summary>
        /// The time at which the schedule was created.
        /// </summary>
        [Output("creationTime")]
        public Output<string> CreationTime { get; private set; } = null!;

        [Output("endpointName")]
        public Output<string?> EndpointName { get; private set; } = null!;

        /// <summary>
        /// Contains the reason a monitoring job failed, if it failed.
        /// </summary>
        [Output("failureReason")]
        public Output<string?> FailureReason { get; private set; } = null!;

        /// <summary>
        /// A timestamp that indicates the last time the monitoring job was modified.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<string> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// Describes metadata on the last execution to run, if there was one.
        /// </summary>
        [Output("lastMonitoringExecutionSummary")]
        public Output<Outputs.MonitoringScheduleMonitoringExecutionSummary?> LastMonitoringExecutionSummary { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the monitoring schedule.
        /// </summary>
        [Output("monitoringScheduleArn")]
        public Output<string> MonitoringScheduleArn { get; private set; } = null!;

        [Output("monitoringScheduleConfig")]
        public Output<Outputs.MonitoringScheduleMonitoringScheduleConfig> MonitoringScheduleConfig { get; private set; } = null!;

        [Output("monitoringScheduleName")]
        public Output<string> MonitoringScheduleName { get; private set; } = null!;

        /// <summary>
        /// The status of a schedule job.
        /// </summary>
        [Output("monitoringScheduleStatus")]
        public Output<string?> MonitoringScheduleStatus { get; private set; } = null!;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.MonitoringScheduleTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a MonitoringSchedule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MonitoringSchedule(string name, MonitoringScheduleArgs args, CustomResourceOptions? options = null)
            : base("aws-native:sagemaker:MonitoringSchedule", name, args ?? new MonitoringScheduleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MonitoringSchedule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:sagemaker:MonitoringSchedule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MonitoringSchedule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MonitoringSchedule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MonitoringSchedule(name, id, options);
        }
    }

    public sealed class MonitoringScheduleArgs : Pulumi.ResourceArgs
    {
        [Input("endpointName")]
        public Input<string>? EndpointName { get; set; }

        /// <summary>
        /// Contains the reason a monitoring job failed, if it failed.
        /// </summary>
        [Input("failureReason")]
        public Input<string>? FailureReason { get; set; }

        /// <summary>
        /// Describes metadata on the last execution to run, if there was one.
        /// </summary>
        [Input("lastMonitoringExecutionSummary")]
        public Input<Inputs.MonitoringScheduleMonitoringExecutionSummaryArgs>? LastMonitoringExecutionSummary { get; set; }

        [Input("monitoringScheduleConfig", required: true)]
        public Input<Inputs.MonitoringScheduleMonitoringScheduleConfigArgs> MonitoringScheduleConfig { get; set; } = null!;

        [Input("monitoringScheduleName", required: true)]
        public Input<string> MonitoringScheduleName { get; set; } = null!;

        /// <summary>
        /// The status of a schedule job.
        /// </summary>
        [Input("monitoringScheduleStatus")]
        public Input<string>? MonitoringScheduleStatus { get; set; }

        [Input("tags")]
        private InputList<Inputs.MonitoringScheduleTagArgs>? _tags;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        public InputList<Inputs.MonitoringScheduleTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.MonitoringScheduleTagArgs>());
            set => _tags = value;
        }

        public MonitoringScheduleArgs()
        {
        }
    }
}
