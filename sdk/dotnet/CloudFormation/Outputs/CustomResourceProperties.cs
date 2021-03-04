// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Outputs
{

    [OutputType]
    public sealed class CustomResourceProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cfn-customresource.html#cfn-customresource-servicetoken
        /// </summary>
        public readonly string ServiceToken;

        [OutputConstructor]
        private CustomResourceProperties(string ServiceToken)
        {
            this.ServiceToken = ServiceToken;
        }
    }
}
