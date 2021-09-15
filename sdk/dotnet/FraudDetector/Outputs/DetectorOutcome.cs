// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.FraudDetector.Outputs
{

    [OutputType]
    public sealed class DetectorOutcome
    {
        public readonly string? Arn;
        /// <summary>
        /// The time when the outcome was created.
        /// </summary>
        public readonly string? CreatedTime;
        /// <summary>
        /// The description.
        /// </summary>
        public readonly string? Description;
        public readonly bool? Inline;
        /// <summary>
        /// The time when the outcome was last updated.
        /// </summary>
        public readonly string? LastUpdatedTime;
        public readonly string? Name;
        /// <summary>
        /// Tags associated with this outcome.
        /// </summary>
        public readonly ImmutableArray<Outputs.DetectorTag> Tags;

        [OutputConstructor]
        private DetectorOutcome(
            string? arn,

            string? createdTime,

            string? description,

            bool? inline,

            string? lastUpdatedTime,

            string? name,

            ImmutableArray<Outputs.DetectorTag> tags)
        {
            Arn = arn;
            CreatedTime = createdTime;
            Description = description;
            Inline = inline;
            LastUpdatedTime = lastUpdatedTime;
            Name = name;
            Tags = tags;
        }
    }
}
