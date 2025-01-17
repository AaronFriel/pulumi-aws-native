// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ResilienceHub.Inputs
{

    /// <summary>
    /// Resource mapping is used to map logical resources from template to physical resource
    /// </summary>
    public sealed class AppResourceMappingArgs : Pulumi.ResourceArgs
    {
        [Input("logicalStackName")]
        public Input<string>? LogicalStackName { get; set; }

        [Input("mappingType", required: true)]
        public Input<string> MappingType { get; set; } = null!;

        [Input("physicalResourceId", required: true)]
        public Input<Inputs.AppPhysicalResourceIdArgs> PhysicalResourceId { get; set; } = null!;

        [Input("resourceName")]
        public Input<string>? ResourceName { get; set; }

        public AppResourceMappingArgs()
        {
        }
    }
}
