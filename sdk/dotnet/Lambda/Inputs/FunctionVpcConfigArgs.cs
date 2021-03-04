// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html
    /// </summary>
    public sealed class FunctionVpcConfigArgs : Pulumi.ResourceArgs
    {
        [Input("SecurityGroupIds", required: true)]
        private InputList<string>? _SecurityGroupIds;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-securitygroupids
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _SecurityGroupIds ?? (_SecurityGroupIds = new InputList<string>());
            set => _SecurityGroupIds = value;
        }

        [Input("SubnetIds", required: true)]
        private InputList<string>? _SubnetIds;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-subnetids
        /// </summary>
        public InputList<string> SubnetIds
        {
            get => _SubnetIds ?? (_SubnetIds = new InputList<string>());
            set => _SubnetIds = value;
        }

        public FunctionVpcConfigArgs()
        {
        }
    }
}
