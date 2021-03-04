// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EventSchemas.Outputs
{

    [OutputType]
    public sealed class SchemaTagsEntry
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventschemas-schema-tagsentry.html#cfn-eventschemas-schema-tagsentry-key
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventschemas-schema-tagsentry.html#cfn-eventschemas-schema-tagsentry-value
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private SchemaTagsEntry(
            string Key,

            string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
