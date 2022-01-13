// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaConvert.Outputs
{

    [OutputType]
    public sealed class JobTemplateHopDestination
    {
        public readonly int? Priority;
        public readonly string? Queue;
        public readonly int? WaitMinutes;

        [OutputConstructor]
        private JobTemplateHopDestination(
            int? priority,

            string? queue,

            int? waitMinutes)
        {
            Priority = priority;
            Queue = queue;
            WaitMinutes = waitMinutes;
        }
    }
}
