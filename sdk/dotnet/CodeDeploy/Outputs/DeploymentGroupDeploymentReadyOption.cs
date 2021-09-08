// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeDeploy.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentreadyoption.html
    /// </summary>
    [OutputType]
    public sealed class DeploymentGroupDeploymentReadyOption
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentreadyoption.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration-deploymentreadyoption-actionontimeout
        /// </summary>
        public readonly string? ActionOnTimeout;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentreadyoption.html#cfn-codedeploy-deploymentgroup-bluegreendeploymentconfiguration-deploymentreadyoption-waittimeinminutes
        /// </summary>
        public readonly int? WaitTimeInMinutes;

        [OutputConstructor]
        private DeploymentGroupDeploymentReadyOption(
            string? actionOnTimeout,

            int? waitTimeInMinutes)
        {
            ActionOnTimeout = actionOnTimeout;
            WaitTimeInMinutes = waitTimeInMinutes;
        }
    }
}