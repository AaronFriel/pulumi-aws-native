// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    public sealed class PartitionSerdeInfoArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        [Input("serializationLibrary")]
        public Input<string>? SerializationLibrary { get; set; }

        public PartitionSerdeInfoArgs()
        {
        }
    }
}