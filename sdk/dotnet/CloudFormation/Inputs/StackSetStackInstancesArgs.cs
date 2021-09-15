// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Inputs
{

    /// <summary>
    /// Stack instances in some specific accounts and Regions.
    /// </summary>
    public sealed class StackSetStackInstancesArgs : Pulumi.ResourceArgs
    {
        [Input("deploymentTargets", required: true)]
        public Input<Inputs.StackSetDeploymentTargetsArgs> DeploymentTargets { get; set; } = null!;

        [Input("parameterOverrides")]
        private InputList<Inputs.StackSetParameterArgs>? _parameterOverrides;

        /// <summary>
        /// A list of stack set parameters whose values you want to override in the selected stack instances.
        /// </summary>
        public InputList<Inputs.StackSetParameterArgs> ParameterOverrides
        {
            get => _parameterOverrides ?? (_parameterOverrides = new InputList<Inputs.StackSetParameterArgs>());
            set => _parameterOverrides = value;
        }

        [Input("regions", required: true)]
        private InputList<string>? _regions;

        /// <summary>
        /// The names of one or more Regions where you want to create stack instances using the specified AWS account(s).
        /// </summary>
        public InputList<string> Regions
        {
            get => _regions ?? (_regions = new InputList<string>());
            set => _regions = value;
        }

        public StackSetStackInstancesArgs()
        {
        }
    }
}
