// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Outputs
{

    /// <summary>
    /// Information required to publish the MQTT message through the AWS IoT message broker.
    /// </summary>
    [OutputType]
    public sealed class DetectorModelIotTopicPublish
    {
        /// <summary>
        /// The MQTT topic of the message. You can use a string expression that includes variables (`$variable.&lt;variable-name&gt;`) and input values (`$input.&lt;input-name&gt;.&lt;path-to-datum&gt;`) as the topic string.
        /// </summary>
        public readonly string MqttTopic;
        public readonly Outputs.DetectorModelPayload? Payload;

        [OutputConstructor]
        private DetectorModelIotTopicPublish(
            string mqttTopic,

            Outputs.DetectorModelPayload? payload)
        {
            MqttTopic = mqttTopic;
            Payload = payload;
        }
    }
}
