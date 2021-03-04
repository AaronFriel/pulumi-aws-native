// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Outputs
{

    [OutputType]
    public sealed class DetectorModelSqs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html#cfn-iotevents-detectormodel-sqs-payload
        /// </summary>
        public readonly Outputs.DetectorModelPayload? Payload;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html#cfn-iotevents-detectormodel-sqs-queueurl
        /// </summary>
        public readonly string? QueueUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html#cfn-iotevents-detectormodel-sqs-usebase64
        /// </summary>
        public readonly bool? UseBase64;

        [OutputConstructor]
        private DetectorModelSqs(
            Outputs.DetectorModelPayload? Payload,

            string? QueueUrl,

            bool? UseBase64)
        {
            this.Payload = Payload;
            this.QueueUrl = QueueUrl;
            this.UseBase64 = UseBase64;
        }
    }
}
