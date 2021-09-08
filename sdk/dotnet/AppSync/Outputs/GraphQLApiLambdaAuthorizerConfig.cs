// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html
    /// </summary>
    [OutputType]
    public sealed class GraphQLApiLambdaAuthorizerConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-authorizerresultttlinseconds
        /// </summary>
        public readonly double? AuthorizerResultTtlInSeconds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-authorizeruri
        /// </summary>
        public readonly string? AuthorizerUri;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-identityvalidationexpression
        /// </summary>
        public readonly string? IdentityValidationExpression;

        [OutputConstructor]
        private GraphQLApiLambdaAuthorizerConfig(
            double? authorizerResultTtlInSeconds,

            string? authorizerUri,

            string? identityValidationExpression)
        {
            AuthorizerResultTtlInSeconds = authorizerResultTtlInSeconds;
            AuthorizerUri = authorizerUri;
            IdentityValidationExpression = identityValidationExpression;
        }
    }
}