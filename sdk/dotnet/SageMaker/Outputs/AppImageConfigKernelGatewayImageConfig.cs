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
    /// The configuration for the file system and kernels in a SageMaker image running as a KernelGateway app.
    /// </summary>
    [OutputType]
    public sealed class AppImageConfigKernelGatewayImageConfig
    {
        /// <summary>
        /// The Amazon Elastic File System (EFS) storage configuration for a SageMaker image.
        /// </summary>
        public readonly Outputs.AppImageConfigFileSystemConfig? FileSystemConfig;
        /// <summary>
        /// The specification of the Jupyter kernels in the image.
        /// </summary>
        public readonly ImmutableArray<Outputs.AppImageConfigKernelSpec> KernelSpecs;

        [OutputConstructor]
        private AppImageConfigKernelGatewayImageConfig(
            Outputs.AppImageConfigFileSystemConfig? fileSystemConfig,

            ImmutableArray<Outputs.AppImageConfigKernelSpec> kernelSpecs)
        {
            FileSystemConfig = fileSystemConfig;
            KernelSpecs = kernelSpecs;
        }
    }
}
