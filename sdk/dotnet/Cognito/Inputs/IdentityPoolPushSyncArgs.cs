// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html
    /// </summary>
    public sealed class IdentityPoolPushSyncArgs : Pulumi.ResourceArgs
    {
        [Input("ApplicationArns")]
        private InputList<string>? _ApplicationArns;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html#cfn-cognito-identitypool-pushsync-applicationarns
        /// </summary>
        public InputList<string> ApplicationArns
        {
            get => _ApplicationArns ?? (_ApplicationArns = new InputList<string>());
            set => _ApplicationArns = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html#cfn-cognito-identitypool-pushsync-rolearn
        /// </summary>
        [Input("RoleArn")]
        public Input<string>? RoleArn { get; set; }

        public IdentityPoolPushSyncArgs()
        {
        }
    }
}
