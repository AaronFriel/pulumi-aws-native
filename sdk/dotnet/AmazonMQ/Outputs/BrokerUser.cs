// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AmazonMQ.Outputs
{

    [OutputType]
    public sealed class BrokerUser
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-user.html#cfn-amazonmq-broker-user-consoleaccess
        /// </summary>
        public readonly bool? ConsoleAccess;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-user.html#cfn-amazonmq-broker-user-groups
        /// </summary>
        public readonly ImmutableArray<string> Groups;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-user.html#cfn-amazonmq-broker-user-password
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-user.html#cfn-amazonmq-broker-user-username
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private BrokerUser(
            bool? ConsoleAccess,

            ImmutableArray<string> Groups,

            string Password,

            string Username)
        {
            this.ConsoleAccess = ConsoleAccess;
            this.Groups = Groups;
            this.Password = Password;
            this.Username = Username;
        }
    }
}
