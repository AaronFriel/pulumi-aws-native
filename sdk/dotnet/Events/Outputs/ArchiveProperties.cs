// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Outputs
{

    [OutputType]
    public sealed class ArchiveProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-archive.html#cfn-events-archive-archivename
        /// </summary>
        public readonly string? ArchiveName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-archive.html#cfn-events-archive-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-archive.html#cfn-events-archive-eventpattern
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? EventPattern;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-archive.html#cfn-events-archive-retentiondays
        /// </summary>
        public readonly int? RetentionDays;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-archive.html#cfn-events-archive-sourcearn
        /// </summary>
        public readonly string SourceArn;

        [OutputConstructor]
        private ArchiveProperties(
            string? ArchiveName,

            string? Description,

            Union<System.Text.Json.JsonElement, string>? EventPattern,

            int? RetentionDays,

            string SourceArn)
        {
            this.ArchiveName = ArchiveName;
            this.Description = Description;
            this.EventPattern = EventPattern;
            this.RetentionDays = RetentionDays;
            this.SourceArn = SourceArn;
        }
    }
}
