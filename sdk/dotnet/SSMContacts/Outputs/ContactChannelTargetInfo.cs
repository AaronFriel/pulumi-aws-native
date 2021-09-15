// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSMContacts.Outputs
{

    /// <summary>
    /// Information about the contact channel that SSM Incident Manager uses to engage the contact.
    /// </summary>
    [OutputType]
    public sealed class ContactChannelTargetInfo
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the contact channel.
        /// </summary>
        public readonly string ChannelId;
        /// <summary>
        /// The number of minutes to wait to retry sending engagement in the case the engagement initially fails.
        /// </summary>
        public readonly int RetryIntervalInMinutes;

        [OutputConstructor]
        private ContactChannelTargetInfo(
            string channelId,

            int retryIntervalInMinutes)
        {
            ChannelId = channelId;
            RetryIntervalInMinutes = retryIntervalInMinutes;
        }
    }
}
