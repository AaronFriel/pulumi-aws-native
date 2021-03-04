// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GameLift.Outputs
{

    [OutputType]
    public sealed class GameServerGroupInstanceDefinitions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gameservergroup-instancedefinitions.html#cfn-gamelift-gameservergroup-instancedefinitions-instancedefinitions
        /// </summary>
        public readonly ImmutableArray<Outputs.GameServerGroupInstanceDefinition> InstanceDefinitions;

        [OutputConstructor]
        private GameServerGroupInstanceDefinitions(ImmutableArray<Outputs.GameServerGroupInstanceDefinition> InstanceDefinitions)
        {
            this.InstanceDefinitions = InstanceDefinitions;
        }
    }
}
