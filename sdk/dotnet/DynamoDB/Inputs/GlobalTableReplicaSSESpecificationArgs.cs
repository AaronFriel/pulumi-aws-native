// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Inputs
{

    public sealed class GlobalTableReplicaSSESpecificationArgs : Pulumi.ResourceArgs
    {
        [Input("kMSMasterKeyId", required: true)]
        public Input<string> KMSMasterKeyId { get; set; } = null!;

        public GlobalTableReplicaSSESpecificationArgs()
        {
        }
    }
}
