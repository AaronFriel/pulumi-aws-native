// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Pinpoint.Outputs
{

    [OutputType]
    public sealed class CampaignSchedule
    {
        public readonly string? EndTime;
        public readonly Outputs.CampaignEventFilter? EventFilter;
        public readonly string? Frequency;
        public readonly bool? IsLocalTime;
        public readonly Outputs.CampaignQuietTime? QuietTime;
        public readonly string? StartTime;
        public readonly string? TimeZone;

        [OutputConstructor]
        private CampaignSchedule(
            string? endTime,

            Outputs.CampaignEventFilter? eventFilter,

            string? frequency,

            bool? isLocalTime,

            Outputs.CampaignQuietTime? quietTime,

            string? startTime,

            string? timeZone)
        {
            EndTime = endTime;
            EventFilter = eventFilter;
            Frequency = frequency;
            IsLocalTime = isLocalTime;
            QuietTime = quietTime;
            StartTime = startTime;
            TimeZone = timeZone;
        }
    }
}
