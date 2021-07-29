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
    public sealed class DetectorModelResetTimer
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-resettimer.html#cfn-iotevents-detectormodel-resettimer-timername
        /// </summary>
        public readonly string? TimerName;

        [OutputConstructor]
        private DetectorModelResetTimer(string? timerName)
        {
            TimerName = timerName;
        }
    }
}