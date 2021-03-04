// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcprouteaction.html
    /// </summary>
    public sealed class RouteTcpRouteActionArgs : Pulumi.ResourceArgs
    {
        [Input("WeightedTargets", required: true)]
        private InputList<Inputs.RouteWeightedTargetArgs>? _WeightedTargets;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcprouteaction.html#cfn-appmesh-route-tcprouteaction-weightedtargets
        /// </summary>
        public InputList<Inputs.RouteWeightedTargetArgs> WeightedTargets
        {
            get => _WeightedTargets ?? (_WeightedTargets = new InputList<Inputs.RouteWeightedTargetArgs>());
            set => _WeightedTargets = value;
        }

        public RouteTcpRouteActionArgs()
        {
        }
    }
}
