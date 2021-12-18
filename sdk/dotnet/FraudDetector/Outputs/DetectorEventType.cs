// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.FraudDetector.Outputs
{

    [OutputType]
    public sealed class DetectorEventType
    {
        /// <summary>
        /// The ARN of the event type.
        /// </summary>
        public readonly string? Arn;
        /// <summary>
        /// The time when the event type was created.
        /// </summary>
        public readonly string? CreatedTime;
        /// <summary>
        /// The description of the event type.
        /// </summary>
        public readonly string? Description;
        public readonly ImmutableArray<Outputs.DetectorEntityType> EntityTypes;
        public readonly ImmutableArray<Outputs.DetectorEventVariable> EventVariables;
        public readonly bool? Inline;
        public readonly ImmutableArray<Outputs.DetectorLabel> Labels;
        /// <summary>
        /// The time when the event type was last updated.
        /// </summary>
        public readonly string? LastUpdatedTime;
        /// <summary>
        /// The name for the event type
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Tags associated with this event type.
        /// </summary>
        public readonly ImmutableArray<Outputs.DetectorTag> Tags;

        [OutputConstructor]
        private DetectorEventType(
            string? arn,

            string? createdTime,

            string? description,

            ImmutableArray<Outputs.DetectorEntityType> entityTypes,

            ImmutableArray<Outputs.DetectorEventVariable> eventVariables,

            bool? inline,

            ImmutableArray<Outputs.DetectorLabel> labels,

            string? lastUpdatedTime,

            string? name,

            ImmutableArray<Outputs.DetectorTag> tags)
        {
            Arn = arn;
            CreatedTime = createdTime;
            Description = description;
            EntityTypes = entityTypes;
            EventVariables = eventVariables;
            Inline = inline;
            Labels = labels;
            LastUpdatedTime = lastUpdatedTime;
            Name = name;
            Tags = tags;
        }
    }
}
