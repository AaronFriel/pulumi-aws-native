// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Outputs
{

    /// <summary>
    /// Stack instances in some specific accounts and Regions.
    /// </summary>
    [OutputType]
    public sealed class StackSetStackInstances
    {
        public readonly Outputs.StackSetDeploymentTargets DeploymentTargets;
        /// <summary>
        /// A list of stack set parameters whose values you want to override in the selected stack instances.
        /// </summary>
        public readonly ImmutableArray<Outputs.StackSetParameter> ParameterOverrides;
        /// <summary>
        /// The names of one or more Regions where you want to create stack instances using the specified AWS account(s).
        /// </summary>
        public readonly ImmutableArray<string> Regions;

        [OutputConstructor]
        private StackSetStackInstances(
            Outputs.StackSetDeploymentTargets deploymentTargets,

            ImmutableArray<Outputs.StackSetParameter> parameterOverrides,

            ImmutableArray<string> regions)
        {
            DeploymentTargets = deploymentTargets;
            ParameterOverrides = parameterOverrides;
            Regions = regions;
        }
    }
}
