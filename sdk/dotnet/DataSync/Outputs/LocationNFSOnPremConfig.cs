// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataSync.Outputs
{

    /// <summary>
    /// Contains a list of Amazon Resource Names (ARNs) of agents that are used to connect an NFS server.
    /// </summary>
    [OutputType]
    public sealed class LocationNFSOnPremConfig
    {
        /// <summary>
        /// ARN(s) of the agent(s) to use for an NFS location.
        /// </summary>
        public readonly ImmutableArray<string> AgentArns;

        [OutputConstructor]
        private LocationNFSOnPremConfig(ImmutableArray<string> agentArns)
        {
            AgentArns = agentArns;
        }
    }
}
