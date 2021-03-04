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
    public sealed class AuthorizerProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-apiid
        /// </summary>
        public readonly string ApiId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizercredentialsarn
        /// </summary>
        public readonly string? AuthorizerCredentialsArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizerpayloadformatversion
        /// </summary>
        public readonly string? AuthorizerPayloadFormatVersion;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizerresultttlinseconds
        /// </summary>
        public readonly int? AuthorizerResultTtlInSeconds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizertype
        /// </summary>
        public readonly string AuthorizerType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizeruri
        /// </summary>
        public readonly string? AuthorizerUri;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-enablesimpleresponses
        /// </summary>
        public readonly bool? EnableSimpleResponses;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-identitysource
        /// </summary>
        public readonly ImmutableArray<string> IdentitySource;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-identityvalidationexpression
        /// </summary>
        public readonly string? IdentityValidationExpression;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-jwtconfiguration
        /// </summary>
        public readonly Outputs.AuthorizerJWTConfiguration? JwtConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-name
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private AuthorizerProperties(
            string ApiId,

            string? AuthorizerCredentialsArn,

            string? AuthorizerPayloadFormatVersion,

            int? AuthorizerResultTtlInSeconds,

            string AuthorizerType,

            string? AuthorizerUri,

            bool? EnableSimpleResponses,

            ImmutableArray<string> IdentitySource,

            string? IdentityValidationExpression,

            Outputs.AuthorizerJWTConfiguration? JwtConfiguration,

            string Name)
        {
            this.ApiId = ApiId;
            this.AuthorizerCredentialsArn = AuthorizerCredentialsArn;
            this.AuthorizerPayloadFormatVersion = AuthorizerPayloadFormatVersion;
            this.AuthorizerResultTtlInSeconds = AuthorizerResultTtlInSeconds;
            this.AuthorizerType = AuthorizerType;
            this.AuthorizerUri = AuthorizerUri;
            this.EnableSimpleResponses = EnableSimpleResponses;
            this.IdentitySource = IdentitySource;
            this.IdentityValidationExpression = IdentityValidationExpression;
            this.JwtConfiguration = JwtConfiguration;
            this.Name = Name;
        }
    }
}
