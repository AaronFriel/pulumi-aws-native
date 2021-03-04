// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Outputs
{

    [OutputType]
    public sealed class ResourceDefinitionVersionProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinitionversion.html#cfn-greengrass-resourcedefinitionversion-resourcedefinitionid
        /// </summary>
        public readonly string ResourceDefinitionId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinitionversion.html#cfn-greengrass-resourcedefinitionversion-resources
        /// </summary>
        public readonly ImmutableArray<Outputs.ResourceDefinitionVersionResourceInstance> Resources;

        [OutputConstructor]
        private ResourceDefinitionVersionProperties(
            string ResourceDefinitionId,

            ImmutableArray<Outputs.ResourceDefinitionVersionResourceInstance> Resources)
        {
            this.ResourceDefinitionId = ResourceDefinitionId;
            this.Resources = Resources;
        }
    }
}
