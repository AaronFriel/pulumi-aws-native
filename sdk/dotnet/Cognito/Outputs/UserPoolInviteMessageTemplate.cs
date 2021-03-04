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
    public sealed class UserPoolInviteMessageTemplate
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-emailmessage
        /// </summary>
        public readonly string? EmailMessage;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-emailsubject
        /// </summary>
        public readonly string? EmailSubject;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-invitemessagetemplate.html#cfn-cognito-userpool-invitemessagetemplate-smsmessage
        /// </summary>
        public readonly string? SMSMessage;

        [OutputConstructor]
        private UserPoolInviteMessageTemplate(
            string? EmailMessage,

            string? EmailSubject,

            string? SMSMessage)
        {
            this.EmailMessage = EmailMessage;
            this.EmailSubject = EmailSubject;
            this.SMSMessage = SMSMessage;
        }
    }
}
