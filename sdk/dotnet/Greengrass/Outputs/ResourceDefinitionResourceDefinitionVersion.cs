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
    public sealed class ResourceDefinitionResourceDefinitionVersion
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedefinitionversion.html#cfn-greengrass-resourcedefinition-resourcedefinitionversion-resources
        /// </summary>
        public readonly ImmutableArray<Outputs.ResourceDefinitionResourceInstance> Resources;

        [OutputConstructor]
        private ResourceDefinitionResourceDefinitionVersion(ImmutableArray<Outputs.ResourceDefinitionResourceInstance> Resources)
        {
            this.Resources = Resources;
        }
    }
}
