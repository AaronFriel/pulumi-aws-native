// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Inputs
{

    public sealed class GlobalTableSSESpecificationArgs : Pulumi.ResourceArgs
    {
        [Input("sSEEnabled", required: true)]
        public Input<bool> SSEEnabled { get; set; } = null!;

        [Input("sSEType")]
        public Input<string>? SSEType { get; set; }

        public GlobalTableSSESpecificationArgs()
        {
        }
    }
}
