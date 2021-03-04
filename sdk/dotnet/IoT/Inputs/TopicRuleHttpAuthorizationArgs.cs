// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpauthorization.html
    /// </summary>
    public sealed class TopicRuleHttpAuthorizationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpauthorization.html#cfn-iot-topicrule-httpauthorization-sigv4
        /// </summary>
        [Input("Sigv4")]
        public Input<Inputs.TopicRuleSigV4AuthorizationArgs>? Sigv4 { get; set; }

        public TopicRuleHttpAuthorizationArgs()
        {
        }
    }
}
