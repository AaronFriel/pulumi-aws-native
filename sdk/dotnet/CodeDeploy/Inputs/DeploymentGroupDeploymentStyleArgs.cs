// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy.Inputs
{

    public sealed class DeploymentGroupDeploymentStyleArgs : Pulumi.ResourceArgs
    {
        [Input("deploymentOption")]
        public Input<string>? DeploymentOption { get; set; }

        [Input("deploymentType")]
        public Input<string>? DeploymentType { get; set; }

        public DeploymentGroupDeploymentStyleArgs()
        {
        }
    }
}