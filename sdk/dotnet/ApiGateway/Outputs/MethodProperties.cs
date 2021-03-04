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
    public sealed class MethodProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-apikeyrequired
        /// </summary>
        public readonly bool? ApiKeyRequired;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizationscopes
        /// </summary>
        public readonly ImmutableArray<string> AuthorizationScopes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizationtype
        /// </summary>
        public readonly string? AuthorizationType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizerid
        /// </summary>
        public readonly string? AuthorizerId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-httpmethod
        /// </summary>
        public readonly string HttpMethod;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-integration
        /// </summary>
        public readonly Outputs.MethodIntegration? Integration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-methodresponses
        /// </summary>
        public readonly ImmutableArray<Outputs.MethodMethodResponse> MethodResponses;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-operationname
        /// </summary>
        public readonly string? OperationName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestmodels
        /// </summary>
        public readonly ImmutableDictionary<string, string>? RequestModels;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestparameters
        /// </summary>
        public readonly ImmutableDictionary<string, bool>? RequestParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestvalidatorid
        /// </summary>
        public readonly string? RequestValidatorId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-resourceid
        /// </summary>
        public readonly string ResourceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-restapiid
        /// </summary>
        public readonly string RestApiId;

        [OutputConstructor]
        private MethodProperties(
            bool? ApiKeyRequired,

            ImmutableArray<string> AuthorizationScopes,

            string? AuthorizationType,

            string? AuthorizerId,

            string HttpMethod,

            Outputs.MethodIntegration? Integration,

            ImmutableArray<Outputs.MethodMethodResponse> MethodResponses,

            string? OperationName,

            ImmutableDictionary<string, string>? RequestModels,

            ImmutableDictionary<string, bool>? RequestParameters,

            string? RequestValidatorId,

            string ResourceId,

            string RestApiId)
        {
            this.ApiKeyRequired = ApiKeyRequired;
            this.AuthorizationScopes = AuthorizationScopes;
            this.AuthorizationType = AuthorizationType;
            this.AuthorizerId = AuthorizerId;
            this.HttpMethod = HttpMethod;
            this.Integration = Integration;
            this.MethodResponses = MethodResponses;
            this.OperationName = OperationName;
            this.RequestModels = RequestModels;
            this.RequestParameters = RequestParameters;
            this.RequestValidatorId = RequestValidatorId;
            this.ResourceId = ResourceId;
            this.RestApiId = RestApiId;
        }
    }
}
