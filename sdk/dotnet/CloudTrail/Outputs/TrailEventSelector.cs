// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudTrail.Outputs
{

    [OutputType]
    public sealed class TrailEventSelector
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-dataresources
        /// </summary>
        public readonly ImmutableArray<Outputs.TrailDataResource> DataResources;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-includemanagementevents
        /// </summary>
        public readonly bool? IncludeManagementEvents;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail-eventselector.html#cfn-cloudtrail-trail-eventselector-readwritetype
        /// </summary>
        public readonly string? ReadWriteType;

        [OutputConstructor]
        private TrailEventSelector(
            ImmutableArray<Outputs.TrailDataResource> DataResources,

            bool? IncludeManagementEvents,

            string? ReadWriteType)
        {
            this.DataResources = DataResources;
            this.IncludeManagementEvents = IncludeManagementEvents;
            this.ReadWriteType = ReadWriteType;
        }
    }
}
