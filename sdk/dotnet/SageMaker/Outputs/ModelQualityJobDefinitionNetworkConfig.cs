// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// Networking options for a job, such as network traffic encryption between containers, whether to allow inbound and outbound network calls to and from containers, and the VPC subnets and security groups to use for VPC-enabled jobs.
    /// </summary>
    [OutputType]
    public sealed class ModelQualityJobDefinitionNetworkConfig
    {
        /// <summary>
        /// Whether to encrypt all communications between distributed processing jobs. Choose True to encrypt communications. Encryption provides greater security for distributed processing jobs, but the processing might take longer.
        /// </summary>
        public readonly bool? EnableInterContainerTrafficEncryption;
        /// <summary>
        /// Whether to allow inbound and outbound network calls to and from the containers used for the processing job.
        /// </summary>
        public readonly bool? EnableNetworkIsolation;
        public readonly Outputs.ModelQualityJobDefinitionVpcConfig? VpcConfig;

        [OutputConstructor]
        private ModelQualityJobDefinitionNetworkConfig(
            bool? enableInterContainerTrafficEncryption,

            bool? enableNetworkIsolation,

            Outputs.ModelQualityJobDefinitionVpcConfig? vpcConfig)
        {
            EnableInterContainerTrafficEncryption = enableInterContainerTrafficEncryption;
            EnableNetworkIsolation = enableNetworkIsolation;
            VpcConfig = vpcConfig;
        }
    }
}
