// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Inputs
{

    /// <summary>
    /// Identifies the resources to deploy for a monitoring job.
    /// </summary>
    public sealed class ModelQualityJobDefinitionMonitoringResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("clusterConfig", required: true)]
        public Input<Inputs.ModelQualityJobDefinitionClusterConfigArgs> ClusterConfig { get; set; } = null!;

        public ModelQualityJobDefinitionMonitoringResourcesArgs()
        {
        }
    }
}
