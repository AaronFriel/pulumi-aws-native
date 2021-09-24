// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MSK.Outputs
{

    [OutputType]
    public sealed class ClusterEncryptionInTransit
    {
        public readonly string? ClientBroker;
        public readonly bool? InCluster;

        [OutputConstructor]
        private ClusterEncryptionInTransit(
            string? clientBroker,

            bool? inCluster)
        {
            ClientBroker = clientBroker;
            InCluster = inCluster;
        }
    }
}