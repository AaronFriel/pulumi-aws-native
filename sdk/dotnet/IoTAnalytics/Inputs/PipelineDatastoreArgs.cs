// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTAnalytics.Inputs
{

    public sealed class PipelineDatastoreArgs : Pulumi.ResourceArgs
    {
        [Input("datastoreName", required: true)]
        public Input<string> DatastoreName { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public PipelineDatastoreArgs()
        {
        }
    }
}
