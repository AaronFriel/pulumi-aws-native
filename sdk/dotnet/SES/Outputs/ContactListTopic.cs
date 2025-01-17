// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SES.Outputs
{

    [OutputType]
    public sealed class ContactListTopic
    {
        public readonly string DefaultSubscriptionStatus;
        /// <summary>
        /// The description of the topic.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The display name of the topic.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The name of the topic.
        /// </summary>
        public readonly string TopicName;

        [OutputConstructor]
        private ContactListTopic(
            string defaultSubscriptionStatus,

            string? description,

            string displayName,

            string topicName)
        {
            DefaultSubscriptionStatus = defaultSubscriptionStatus;
            Description = description;
            DisplayName = displayName;
            TopicName = topicName;
        }
    }
}
