// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTAnalytics
{
    /// <summary>
    /// Resource Type definition for AWS::IoTAnalytics::Datastore
    /// </summary>
    [Obsolete(@"Datastore is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:iotanalytics:Datastore")]
    public partial class Datastore : Pulumi.CustomResource
    {
        [Output("datastoreName")]
        public Output<string?> DatastoreName { get; private set; } = null!;

        [Output("datastorePartitions")]
        public Output<Outputs.DatastoreDatastorePartitions?> DatastorePartitions { get; private set; } = null!;

        [Output("datastoreStorage")]
        public Output<Outputs.DatastoreDatastoreStorage?> DatastoreStorage { get; private set; } = null!;

        [Output("fileFormatConfiguration")]
        public Output<Outputs.DatastoreFileFormatConfiguration?> FileFormatConfiguration { get; private set; } = null!;

        [Output("retentionPeriod")]
        public Output<Outputs.DatastoreRetentionPeriod?> RetentionPeriod { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.DatastoreTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Datastore resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Datastore(string name, DatastoreArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:iotanalytics:Datastore", name, args ?? new DatastoreArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Datastore(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iotanalytics:Datastore", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Datastore resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Datastore Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Datastore(name, id, options);
        }
    }

    public sealed class DatastoreArgs : Pulumi.ResourceArgs
    {
        [Input("datastoreName")]
        public Input<string>? DatastoreName { get; set; }

        [Input("datastorePartitions")]
        public Input<Inputs.DatastoreDatastorePartitionsArgs>? DatastorePartitions { get; set; }

        [Input("datastoreStorage")]
        public Input<Inputs.DatastoreDatastoreStorageArgs>? DatastoreStorage { get; set; }

        [Input("fileFormatConfiguration")]
        public Input<Inputs.DatastoreFileFormatConfigurationArgs>? FileFormatConfiguration { get; set; }

        [Input("retentionPeriod")]
        public Input<Inputs.DatastoreRetentionPeriodArgs>? RetentionPeriod { get; set; }

        [Input("tags")]
        private InputList<Inputs.DatastoreTagArgs>? _tags;
        public InputList<Inputs.DatastoreTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.DatastoreTagArgs>());
            set => _tags = value;
        }

        public DatastoreArgs()
        {
        }
    }
}
