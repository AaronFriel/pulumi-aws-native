// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EKS.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-remoteaccess.html
    /// </summary>
    public sealed class NodegroupRemoteAccessArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-remoteaccess.html#cfn-eks-nodegroup-remoteaccess-ec2sshkey
        /// </summary>
        [Input("Ec2SshKey", required: true)]
        public Input<string> Ec2SshKey { get; set; } = null!;

        [Input("SourceSecurityGroups")]
        private InputList<string>? _SourceSecurityGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-remoteaccess.html#cfn-eks-nodegroup-remoteaccess-sourcesecuritygroups
        /// </summary>
        public InputList<string> SourceSecurityGroups
        {
            get => _SourceSecurityGroups ?? (_SourceSecurityGroups = new InputList<string>());
            set => _SourceSecurityGroups = value;
        }

        public NodegroupRemoteAccessArgs()
        {
        }
    }
}
