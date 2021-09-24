// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SQS
{
    /// <summary>
    /// Resource Type definition for AWS::SQS::Queue
    /// </summary>
    [Obsolete(@"Queue is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:sqs:Queue")]
    public partial class Queue : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("contentBasedDeduplication")]
        public Output<bool?> ContentBasedDeduplication { get; private set; } = null!;

        [Output("deduplicationScope")]
        public Output<string?> DeduplicationScope { get; private set; } = null!;

        [Output("delaySeconds")]
        public Output<int?> DelaySeconds { get; private set; } = null!;

        [Output("fifoQueue")]
        public Output<bool?> FifoQueue { get; private set; } = null!;

        [Output("fifoThroughputLimit")]
        public Output<string?> FifoThroughputLimit { get; private set; } = null!;

        [Output("kmsDataKeyReusePeriodSeconds")]
        public Output<int?> KmsDataKeyReusePeriodSeconds { get; private set; } = null!;

        [Output("kmsMasterKeyId")]
        public Output<string?> KmsMasterKeyId { get; private set; } = null!;

        [Output("maximumMessageSize")]
        public Output<int?> MaximumMessageSize { get; private set; } = null!;

        [Output("messageRetentionPeriod")]
        public Output<int?> MessageRetentionPeriod { get; private set; } = null!;

        [Output("queueName")]
        public Output<string?> QueueName { get; private set; } = null!;

        [Output("receiveMessageWaitTimeSeconds")]
        public Output<int?> ReceiveMessageWaitTimeSeconds { get; private set; } = null!;

        [Output("redrivePolicy")]
        public Output<object?> RedrivePolicy { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.QueueTag>> Tags { get; private set; } = null!;

        [Output("visibilityTimeout")]
        public Output<int?> VisibilityTimeout { get; private set; } = null!;


        /// <summary>
        /// Create a Queue resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Queue(string name, QueueArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:sqs:Queue", name, args ?? new QueueArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Queue(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:sqs:Queue", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Queue resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Queue Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Queue(name, id, options);
        }
    }

    public sealed class QueueArgs : Pulumi.ResourceArgs
    {
        [Input("contentBasedDeduplication")]
        public Input<bool>? ContentBasedDeduplication { get; set; }

        [Input("deduplicationScope")]
        public Input<string>? DeduplicationScope { get; set; }

        [Input("delaySeconds")]
        public Input<int>? DelaySeconds { get; set; }

        [Input("fifoQueue")]
        public Input<bool>? FifoQueue { get; set; }

        [Input("fifoThroughputLimit")]
        public Input<string>? FifoThroughputLimit { get; set; }

        [Input("kmsDataKeyReusePeriodSeconds")]
        public Input<int>? KmsDataKeyReusePeriodSeconds { get; set; }

        [Input("kmsMasterKeyId")]
        public Input<string>? KmsMasterKeyId { get; set; }

        [Input("maximumMessageSize")]
        public Input<int>? MaximumMessageSize { get; set; }

        [Input("messageRetentionPeriod")]
        public Input<int>? MessageRetentionPeriod { get; set; }

        [Input("queueName")]
        public Input<string>? QueueName { get; set; }

        [Input("receiveMessageWaitTimeSeconds")]
        public Input<int>? ReceiveMessageWaitTimeSeconds { get; set; }

        [Input("redrivePolicy")]
        public Input<object>? RedrivePolicy { get; set; }

        [Input("tags")]
        private InputList<Inputs.QueueTagArgs>? _tags;
        public InputList<Inputs.QueueTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.QueueTagArgs>());
            set => _tags = value;
        }

        [Input("visibilityTimeout")]
        public Input<int>? VisibilityTimeout { get; set; }

        public QueueArgs()
        {
        }
    }
}
