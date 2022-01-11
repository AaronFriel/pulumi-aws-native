// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT
{
    /// <summary>
    /// Job templates enable you to preconfigure jobs so that you can deploy them to multiple sets of target devices.
    /// </summary>
    [AwsNativeResourceType("aws-native:iot:JobTemplate")]
    public partial class JobTemplate : Pulumi.CustomResource
    {
        /// <summary>
        /// The criteria that determine when and how a job abort takes place.
        /// </summary>
        [Output("abortConfig")]
        public Output<Outputs.AbortConfigProperties?> AbortConfig { get; private set; } = null!;

        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// A description of the Job Template.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The job document. Required if you don't specify a value for documentSource.
        /// </summary>
        [Output("document")]
        public Output<string?> Document { get; private set; } = null!;

        /// <summary>
        /// An S3 link to the job document to use in the template. Required if you don't specify a value for document.
        /// </summary>
        [Output("documentSource")]
        public Output<string?> DocumentSource { get; private set; } = null!;

        /// <summary>
        /// Optional for copying a JobTemplate from a pre-existing Job configuration.
        /// </summary>
        [Output("jobArn")]
        public Output<string?> JobArn { get; private set; } = null!;

        [Output("jobExecutionsRetryConfig")]
        public Output<Outputs.JobExecutionsRetryConfigProperties?> JobExecutionsRetryConfig { get; private set; } = null!;

        /// <summary>
        /// Allows you to create a staged rollout of a job.
        /// </summary>
        [Output("jobExecutionsRolloutConfig")]
        public Output<Outputs.JobExecutionsRolloutConfigProperties?> JobExecutionsRolloutConfig { get; private set; } = null!;

        [Output("jobTemplateId")]
        public Output<string> JobTemplateId { get; private set; } = null!;

        /// <summary>
        /// Configuration for pre-signed S3 URLs.
        /// </summary>
        [Output("presignedUrlConfig")]
        public Output<Outputs.PresignedUrlConfigProperties?> PresignedUrlConfig { get; private set; } = null!;

        /// <summary>
        /// Metadata that can be used to manage the JobTemplate.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.JobTemplateTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies the amount of time each device has to finish its execution of the job.
        /// </summary>
        [Output("timeoutConfig")]
        public Output<Outputs.TimeoutConfigProperties?> TimeoutConfig { get; private set; } = null!;


        /// <summary>
        /// Create a JobTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public JobTemplate(string name, JobTemplateArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iot:JobTemplate", name, args ?? new JobTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private JobTemplate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iot:JobTemplate", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing JobTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static JobTemplate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new JobTemplate(name, id, options);
        }
    }

    public sealed class JobTemplateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The criteria that determine when and how a job abort takes place.
        /// </summary>
        [Input("abortConfig")]
        public Input<Inputs.AbortConfigPropertiesArgs>? AbortConfig { get; set; }

        /// <summary>
        /// A description of the Job Template.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// The job document. Required if you don't specify a value for documentSource.
        /// </summary>
        [Input("document")]
        public Input<string>? Document { get; set; }

        /// <summary>
        /// An S3 link to the job document to use in the template. Required if you don't specify a value for document.
        /// </summary>
        [Input("documentSource")]
        public Input<string>? DocumentSource { get; set; }

        /// <summary>
        /// Optional for copying a JobTemplate from a pre-existing Job configuration.
        /// </summary>
        [Input("jobArn")]
        public Input<string>? JobArn { get; set; }

        [Input("jobExecutionsRetryConfig")]
        public Input<Inputs.JobExecutionsRetryConfigPropertiesArgs>? JobExecutionsRetryConfig { get; set; }

        /// <summary>
        /// Allows you to create a staged rollout of a job.
        /// </summary>
        [Input("jobExecutionsRolloutConfig")]
        public Input<Inputs.JobExecutionsRolloutConfigPropertiesArgs>? JobExecutionsRolloutConfig { get; set; }

        [Input("jobTemplateId", required: true)]
        public Input<string> JobTemplateId { get; set; } = null!;

        /// <summary>
        /// Configuration for pre-signed S3 URLs.
        /// </summary>
        [Input("presignedUrlConfig")]
        public Input<Inputs.PresignedUrlConfigPropertiesArgs>? PresignedUrlConfig { get; set; }

        [Input("tags")]
        private InputList<Inputs.JobTemplateTagArgs>? _tags;

        /// <summary>
        /// Metadata that can be used to manage the JobTemplate.
        /// </summary>
        public InputList<Inputs.JobTemplateTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.JobTemplateTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the amount of time each device has to finish its execution of the job.
        /// </summary>
        [Input("timeoutConfig")]
        public Input<Inputs.TimeoutConfigPropertiesArgs>? TimeoutConfig { get; set; }

        public JobTemplateArgs()
        {
        }
    }
}
