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
    public sealed class DetectorModelEvent
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html#cfn-iotevents-detectormodel-event-actions
        /// </summary>
        public readonly ImmutableArray<Outputs.DetectorModelAction> Actions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html#cfn-iotevents-detectormodel-event-condition
        /// </summary>
        public readonly string? Condition;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html#cfn-iotevents-detectormodel-event-eventname
        /// </summary>
        public readonly string? EventName;

        [OutputConstructor]
        private DetectorModelEvent(
            ImmutableArray<Outputs.DetectorModelAction> actions,

            string? condition,

            string? eventName)
        {
            Actions = actions;
            Condition = condition;
            EventName = eventName;
        }
    }
}