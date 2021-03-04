// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGatewayV2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html
    /// </summary>
    public sealed class AuthorizerJWTConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("Audience")]
        private InputList<string>? _Audience;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html#cfn-apigatewayv2-authorizer-jwtconfiguration-audience
        /// </summary>
        public InputList<string> Audience
        {
            get => _Audience ?? (_Audience = new InputList<string>());
            set => _Audience = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html#cfn-apigatewayv2-authorizer-jwtconfiguration-issuer
        /// </summary>
        [Input("Issuer")]
        public Input<string>? Issuer { get; set; }

        public AuthorizerJWTConfigurationArgs()
        {
        }
    }
}
