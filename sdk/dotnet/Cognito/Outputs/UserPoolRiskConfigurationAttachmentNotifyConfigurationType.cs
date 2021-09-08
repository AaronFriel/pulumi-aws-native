// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html
    /// </summary>
    [OutputType]
    public sealed class UserPoolRiskConfigurationAttachmentNotifyConfigurationType
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-blockemail
        /// </summary>
        public readonly Outputs.UserPoolRiskConfigurationAttachmentNotifyEmailType? BlockEmail;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-from
        /// </summary>
        public readonly string? From;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-mfaemail
        /// </summary>
        public readonly Outputs.UserPoolRiskConfigurationAttachmentNotifyEmailType? MfaEmail;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-noactionemail
        /// </summary>
        public readonly Outputs.UserPoolRiskConfigurationAttachmentNotifyEmailType? NoActionEmail;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-replyto
        /// </summary>
        public readonly string? ReplyTo;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype.html#cfn-cognito-userpoolriskconfigurationattachment-notifyconfigurationtype-sourcearn
        /// </summary>
        public readonly string SourceArn;

        [OutputConstructor]
        private UserPoolRiskConfigurationAttachmentNotifyConfigurationType(
            Outputs.UserPoolRiskConfigurationAttachmentNotifyEmailType? blockEmail,

            string? from,

            Outputs.UserPoolRiskConfigurationAttachmentNotifyEmailType? mfaEmail,

            Outputs.UserPoolRiskConfigurationAttachmentNotifyEmailType? noActionEmail,

            string? replyTo,

            string sourceArn)
        {
            BlockEmail = blockEmail;
            From = from;
            MfaEmail = mfaEmail;
            NoActionEmail = noActionEmail;
            ReplyTo = replyTo;
            SourceArn = sourceArn;
        }
    }
}