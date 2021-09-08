// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html
    /// </summary>
    [OutputType]
    public sealed class WorkteamCognitoMemberDefinition
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitoclientid
        /// </summary>
        public readonly string CognitoClientId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitousergroup
        /// </summary>
        public readonly string CognitoUserGroup;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-workteam-cognitomemberdefinition.html#cfn-sagemaker-workteam-cognitomemberdefinition-cognitouserpool
        /// </summary>
        public readonly string CognitoUserPool;

        [OutputConstructor]
        private WorkteamCognitoMemberDefinition(
            string cognitoClientId,

            string cognitoUserGroup,

            string cognitoUserPool)
        {
            CognitoClientId = cognitoClientId;
            CognitoUserGroup = cognitoUserGroup;
            CognitoUserPool = cognitoUserPool;
        }
    }
}