// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    public sealed class TableInputArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("owner")]
        public Input<string>? Owner { get; set; }

        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        [Input("partitionKeys")]
        private InputList<Inputs.TableColumnArgs>? _partitionKeys;
        public InputList<Inputs.TableColumnArgs> PartitionKeys
        {
            get => _partitionKeys ?? (_partitionKeys = new InputList<Inputs.TableColumnArgs>());
            set => _partitionKeys = value;
        }

        [Input("retention")]
        public Input<int>? Retention { get; set; }

        [Input("storageDescriptor")]
        public Input<Inputs.TableStorageDescriptorArgs>? StorageDescriptor { get; set; }

        [Input("tableType")]
        public Input<string>? TableType { get; set; }

        [Input("targetTable")]
        public Input<Inputs.TableIdentifierArgs>? TargetTable { get; set; }

        [Input("viewExpandedText")]
        public Input<string>? ViewExpandedText { get; set; }

        [Input("viewOriginalText")]
        public Input<string>? ViewOriginalText { get; set; }

        public TableInputArgs()
        {
        }
    }
}
