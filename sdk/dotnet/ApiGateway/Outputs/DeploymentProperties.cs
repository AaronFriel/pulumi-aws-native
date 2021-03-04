// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGateway.Outputs
{

    [OutputType]
    public sealed class DeploymentProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-deploymentcanarysettings
        /// </summary>
        public readonly Outputs.DeploymentDeploymentCanarySettings? DeploymentCanarySettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-restapiid
        /// </summary>
        public readonly string RestApiId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-stagedescription
        /// </summary>
        public readonly Outputs.DeploymentStageDescription? StageDescription;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-deployment.html#cfn-apigateway-deployment-stagename
        /// </summary>
        public readonly string? StageName;

        [OutputConstructor]
        private DeploymentProperties(
            Outputs.DeploymentDeploymentCanarySettings? DeploymentCanarySettings,

            string? Description,

            string RestApiId,

            Outputs.DeploymentStageDescription? StageDescription,

            string? StageName)
        {
            this.DeploymentCanarySettings = DeploymentCanarySettings;
            this.Description = Description;
            this.RestApiId = RestApiId;
            this.StageDescription = StageDescription;
            this.StageName = StageName;
        }
    }
}
