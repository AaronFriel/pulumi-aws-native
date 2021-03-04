// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagset.html
    /// </summary>
    public sealed class DeploymentGroupOnPremisesTagSetArgs : Pulumi.ResourceArgs
    {
        [Input("OnPremisesTagSetList")]
        private InputList<Inputs.DeploymentGroupOnPremisesTagSetListObjectArgs>? _OnPremisesTagSetList;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagset.html#cfn-codedeploy-deploymentgroup-onpremisestagset-onpremisestagsetlist
        /// </summary>
        public InputList<Inputs.DeploymentGroupOnPremisesTagSetListObjectArgs> OnPremisesTagSetList
        {
            get => _OnPremisesTagSetList ?? (_OnPremisesTagSetList = new InputList<Inputs.DeploymentGroupOnPremisesTagSetListObjectArgs>());
            set => _OnPremisesTagSetList = value;
        }

        public DeploymentGroupOnPremisesTagSetArgs()
        {
        }
    }
}
