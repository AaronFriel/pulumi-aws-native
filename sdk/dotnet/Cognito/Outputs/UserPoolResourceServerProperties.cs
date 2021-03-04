// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Outputs
{

    [OutputType]
    public sealed class UserPoolResourceServerProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-identifier
        /// </summary>
        public readonly string Identifier;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-scopes
        /// </summary>
        public readonly ImmutableArray<Outputs.UserPoolResourceServerResourceServerScopeType> Scopes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolresourceserver.html#cfn-cognito-userpoolresourceserver-userpoolid
        /// </summary>
        public readonly string UserPoolId;

        [OutputConstructor]
        private UserPoolResourceServerProperties(
            string Identifier,

            string Name,

            ImmutableArray<Outputs.UserPoolResourceServerResourceServerScopeType> Scopes,

            string UserPoolId)
        {
            this.Identifier = Identifier;
            this.Name = Name;
            this.Scopes = Scopes;
            this.UserPoolId = UserPoolId;
        }
    }
}
