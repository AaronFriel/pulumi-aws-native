// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DevOpsGuru.Outputs
{

    [OutputType]
    public sealed class ResourceCollectionResourceCollectionFilter
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-resourcecollectionfilter.html#cfn-devopsguru-resourcecollection-resourcecollectionfilter-cloudformation
        /// </summary>
        public readonly Outputs.ResourceCollectionCloudFormationCollectionFilter? CloudFormation;

        [OutputConstructor]
        private ResourceCollectionResourceCollectionFilter(Outputs.ResourceCollectionCloudFormationCollectionFilter? CloudFormation)
        {
            this.CloudFormation = CloudFormation;
        }
    }
}
