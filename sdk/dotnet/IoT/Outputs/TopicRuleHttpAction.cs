// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class TopicRuleHttpAction
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-auth
        /// </summary>
        public readonly Outputs.TopicRuleHttpAuthorization? Auth;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-confirmationurl
        /// </summary>
        public readonly string? ConfirmationUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-headers
        /// </summary>
        public readonly ImmutableArray<Outputs.TopicRuleHttpActionHeader> Headers;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-url
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private TopicRuleHttpAction(
            Outputs.TopicRuleHttpAuthorization? Auth,

            string? ConfirmationUrl,

            ImmutableArray<Outputs.TopicRuleHttpActionHeader> Headers,

            string Url)
        {
            this.Auth = Auth;
            this.ConfirmationUrl = ConfirmationUrl;
            this.Headers = Headers;
            this.Url = Url;
        }
    }
}
