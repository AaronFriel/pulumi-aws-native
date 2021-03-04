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
    public sealed class UserPoolLambdaConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-createauthchallenge
        /// </summary>
        public readonly string? CreateAuthChallenge;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-customemailsender
        /// </summary>
        public readonly Outputs.UserPoolCustomEmailSender? CustomEmailSender;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-custommessage
        /// </summary>
        public readonly string? CustomMessage;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-customsmssender
        /// </summary>
        public readonly Outputs.UserPoolCustomSMSSender? CustomSMSSender;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-defineauthchallenge
        /// </summary>
        public readonly string? DefineAuthChallenge;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-kmskeyid
        /// </summary>
        public readonly string? KMSKeyID;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postauthentication
        /// </summary>
        public readonly string? PostAuthentication;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-postconfirmation
        /// </summary>
        public readonly string? PostConfirmation;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-preauthentication
        /// </summary>
        public readonly string? PreAuthentication;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-presignup
        /// </summary>
        public readonly string? PreSignUp;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-pretokengeneration
        /// </summary>
        public readonly string? PreTokenGeneration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-usermigration
        /// </summary>
        public readonly string? UserMigration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-lambdaconfig.html#cfn-cognito-userpool-lambdaconfig-verifyauthchallengeresponse
        /// </summary>
        public readonly string? VerifyAuthChallengeResponse;

        [OutputConstructor]
        private UserPoolLambdaConfig(
            string? CreateAuthChallenge,

            Outputs.UserPoolCustomEmailSender? CustomEmailSender,

            string? CustomMessage,

            Outputs.UserPoolCustomSMSSender? CustomSMSSender,

            string? DefineAuthChallenge,

            string? KMSKeyID,

            string? PostAuthentication,

            string? PostConfirmation,

            string? PreAuthentication,

            string? PreSignUp,

            string? PreTokenGeneration,

            string? UserMigration,

            string? VerifyAuthChallengeResponse)
        {
            this.CreateAuthChallenge = CreateAuthChallenge;
            this.CustomEmailSender = CustomEmailSender;
            this.CustomMessage = CustomMessage;
            this.CustomSMSSender = CustomSMSSender;
            this.DefineAuthChallenge = DefineAuthChallenge;
            this.KMSKeyID = KMSKeyID;
            this.PostAuthentication = PostAuthentication;
            this.PostConfirmation = PostConfirmation;
            this.PreAuthentication = PreAuthentication;
            this.PreSignUp = PreSignUp;
            this.PreTokenGeneration = PreTokenGeneration;
            this.UserMigration = UserMigration;
            this.VerifyAuthChallengeResponse = VerifyAuthChallengeResponse;
        }
    }
}
