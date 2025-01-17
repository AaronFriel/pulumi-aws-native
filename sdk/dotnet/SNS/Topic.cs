// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SNS
{
    /// <summary>
    /// Resource Type definition for AWS::SNS::Topic
    /// </summary>
    [Obsolete(@"Topic is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:sns:Topic")]
    public partial class Topic : Pulumi.CustomResource
    {
        [Output("contentBasedDeduplication")]
        public Output<bool?> ContentBasedDeduplication { get; private set; } = null!;

        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        [Output("fifoTopic")]
        public Output<bool?> FifoTopic { get; private set; } = null!;

        [Output("kmsMasterKeyId")]
        public Output<string?> KmsMasterKeyId { get; private set; } = null!;

        [Output("subscription")]
        public Output<ImmutableArray<Outputs.TopicSubscription>> Subscription { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.TopicTag>> Tags { get; private set; } = null!;

        [Output("topicName")]
        public Output<string?> TopicName { get; private set; } = null!;


        /// <summary>
        /// Create a Topic resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Topic(string name, TopicArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:sns:Topic", name, args ?? new TopicArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Topic(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:sns:Topic", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Topic resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Topic Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Topic(name, id, options);
        }
    }

    public sealed class TopicArgs : Pulumi.ResourceArgs
    {
        [Input("contentBasedDeduplication")]
        public Input<bool>? ContentBasedDeduplication { get; set; }

        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("fifoTopic")]
        public Input<bool>? FifoTopic { get; set; }

        [Input("kmsMasterKeyId")]
        public Input<string>? KmsMasterKeyId { get; set; }

        [Input("subscription")]
        private InputList<Inputs.TopicSubscriptionArgs>? _subscription;
        public InputList<Inputs.TopicSubscriptionArgs> Subscription
        {
            get => _subscription ?? (_subscription = new InputList<Inputs.TopicSubscriptionArgs>());
            set => _subscription = value;
        }

        [Input("tags")]
        private InputList<Inputs.TopicTagArgs>? _tags;
        public InputList<Inputs.TopicTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.TopicTagArgs>());
            set => _tags = value;
        }

        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        public TopicArgs()
        {
        }
    }
}
