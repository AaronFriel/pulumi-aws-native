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
    public sealed class AliasRoutingStrategy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-fleetid
        /// </summary>
        public readonly string? FleetId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-message
        /// </summary>
        public readonly string? Message;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html#cfn-gamelift-alias-routingstrategy-type
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private AliasRoutingStrategy(
            string? FleetId,

            string? Message,

            string? Type)
        {
            this.FleetId = FleetId;
            this.Message = Message;
            this.Type = Type;
        }
    }
}
