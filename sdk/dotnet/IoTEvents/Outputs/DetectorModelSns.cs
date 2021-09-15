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
    /// Information required to publish the Amazon SNS message.
    /// </summary>
    [OutputType]
    public sealed class DetectorModelSns
    {
        public readonly Outputs.DetectorModelPayload? Payload;
        /// <summary>
        /// The ARN of the Amazon SNS target where the message is sent.
        /// </summary>
        public readonly string TargetArn;

        [OutputConstructor]
        private DetectorModelSns(
            Outputs.DetectorModelPayload? payload,

            string targetArn)
        {
            Payload = payload;
            TargetArn = targetArn;
        }
    }
}
