// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy.Inputs
{

    public sealed class DeploymentGroupEC2TagSetListObjectArgs : Pulumi.ResourceArgs
    {
        [Input("ec2TagGroup")]
        private InputList<Inputs.DeploymentGroupEC2TagFilterArgs>? _ec2TagGroup;
        public InputList<Inputs.DeploymentGroupEC2TagFilterArgs> Ec2TagGroup
        {
            get => _ec2TagGroup ?? (_ec2TagGroup = new InputList<Inputs.DeploymentGroupEC2TagFilterArgs>());
            set => _ec2TagGroup = value;
        }

        public DeploymentGroupEC2TagSetListObjectArgs()
        {
        }
    }
}
