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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagsetlistobject.html
    /// </summary>
    public sealed class DeploymentGroupOnPremisesTagSetListObjectArgs : Pulumi.ResourceArgs
    {
        [Input("onPremisesTagGroup")]
        private InputList<Inputs.DeploymentGroupTagFilterArgs>? _onPremisesTagGroup;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-onpremisestagsetlistobject.html#cfn-codedeploy-deploymentgroup-onpremisestagsetlistobject-onpremisestaggroup
        /// </summary>
        public InputList<Inputs.DeploymentGroupTagFilterArgs> OnPremisesTagGroup
        {
            get => _onPremisesTagGroup ?? (_onPremisesTagGroup = new InputList<Inputs.DeploymentGroupTagFilterArgs>());
            set => _onPremisesTagGroup = value;
        }

        public DeploymentGroupOnPremisesTagSetListObjectArgs()
        {
        }
    }
}