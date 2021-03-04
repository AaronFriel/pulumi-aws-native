// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class AuthorizerProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-authorizerfunctionarn
        /// </summary>
        public readonly string AuthorizerFunctionArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-authorizername
        /// </summary>
        public readonly string? AuthorizerName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-signingdisabled
        /// </summary>
        public readonly bool? SigningDisabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-status
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-tags
        /// </summary>
        public readonly Outputs.AuthorizerTags? Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-tokenkeyname
        /// </summary>
        public readonly string? TokenKeyName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-authorizer.html#cfn-iot-authorizer-tokensigningpublickeys
        /// </summary>
        public readonly Outputs.AuthorizerTokenSigningPublicKeys? TokenSigningPublicKeys;

        [OutputConstructor]
        private AuthorizerProperties(
            string AuthorizerFunctionArn,

            string? AuthorizerName,

            bool? SigningDisabled,

            string? Status,

            Outputs.AuthorizerTags? Tags,

            string? TokenKeyName,

            Outputs.AuthorizerTokenSigningPublicKeys? TokenSigningPublicKeys)
        {
            this.AuthorizerFunctionArn = AuthorizerFunctionArn;
            this.AuthorizerName = AuthorizerName;
            this.SigningDisabled = SigningDisabled;
            this.Status = Status;
            this.Tags = Tags;
            this.TokenKeyName = TokenKeyName;
            this.TokenSigningPublicKeys = TokenSigningPublicKeys;
        }
    }
}
