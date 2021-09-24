// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MSK.Inputs
{

    public sealed class ClusterS3Args : Pulumi.ResourceArgs
    {
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        public ClusterS3Args()
        {
        }
    }
}