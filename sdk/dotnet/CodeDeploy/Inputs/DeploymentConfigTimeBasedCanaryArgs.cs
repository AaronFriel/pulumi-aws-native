// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy.Inputs
{

    public sealed class DeploymentConfigTimeBasedCanaryArgs : Pulumi.ResourceArgs
    {
        [Input("canaryInterval", required: true)]
        public Input<int> CanaryInterval { get; set; } = null!;

        [Input("canaryPercentage", required: true)]
        public Input<int> CanaryPercentage { get; set; } = null!;

        public DeploymentConfigTimeBasedCanaryArgs()
        {
        }
    }
}
