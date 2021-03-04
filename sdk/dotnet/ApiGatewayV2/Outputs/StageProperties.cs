// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGatewayV2.Outputs
{

    [OutputType]
    public sealed class StageProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-accesslogsettings
        /// </summary>
        public readonly Outputs.StageAccessLogSettings? AccessLogSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-apiid
        /// </summary>
        public readonly string ApiId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-autodeploy
        /// </summary>
        public readonly bool? AutoDeploy;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-clientcertificateid
        /// </summary>
        public readonly string? ClientCertificateId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-defaultroutesettings
        /// </summary>
        public readonly Outputs.StageRouteSettings? DefaultRouteSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-deploymentid
        /// </summary>
        public readonly string? DeploymentId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-routesettings
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? RouteSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-stagename
        /// </summary>
        public readonly string StageName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-stagevariables
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? StageVariables;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-stage.html#cfn-apigatewayv2-stage-tags
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Tags;

        [OutputConstructor]
        private StageProperties(
            Outputs.StageAccessLogSettings? AccessLogSettings,

            string ApiId,

            bool? AutoDeploy,

            string? ClientCertificateId,

            Outputs.StageRouteSettings? DefaultRouteSettings,

            string? DeploymentId,

            string? Description,

            Union<System.Text.Json.JsonElement, string>? RouteSettings,

            string StageName,

            Union<System.Text.Json.JsonElement, string>? StageVariables,

            Union<System.Text.Json.JsonElement, string>? Tags)
        {
            this.AccessLogSettings = AccessLogSettings;
            this.ApiId = ApiId;
            this.AutoDeploy = AutoDeploy;
            this.ClientCertificateId = ClientCertificateId;
            this.DefaultRouteSettings = DefaultRouteSettings;
            this.DeploymentId = DeploymentId;
            this.Description = Description;
            this.RouteSettings = RouteSettings;
            this.StageName = StageName;
            this.StageVariables = StageVariables;
            this.Tags = Tags;
        }
    }
}
