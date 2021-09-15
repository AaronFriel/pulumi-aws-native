// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue
{
    /// <summary>
    /// This resource adds Key-Value metadata to a Schema version of Glue Schema Registry.
    /// </summary>
    [AwsNativeResourceType("aws-native:glue:SchemaVersionMetadata")]
    public partial class SchemaVersionMetadata : Pulumi.CustomResource
    {
        /// <summary>
        /// Metadata key
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// Represents the version ID associated with the schema version.
        /// </summary>
        [Output("schemaVersionId")]
        public Output<string> SchemaVersionId { get; private set; } = null!;

        /// <summary>
        /// Metadata value
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a SchemaVersionMetadata resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SchemaVersionMetadata(string name, SchemaVersionMetadataArgs args, CustomResourceOptions? options = null)
            : base("aws-native:glue:SchemaVersionMetadata", name, args ?? new SchemaVersionMetadataArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SchemaVersionMetadata(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:glue:SchemaVersionMetadata", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SchemaVersionMetadata resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SchemaVersionMetadata Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SchemaVersionMetadata(name, id, options);
        }
    }

    public sealed class SchemaVersionMetadataArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Metadata key
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Represents the version ID associated with the schema version.
        /// </summary>
        [Input("schemaVersionId", required: true)]
        public Input<string> SchemaVersionId { get; set; } = null!;

        /// <summary>
        /// Metadata value
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public SchemaVersionMetadataArgs()
        {
        }
    }
}
