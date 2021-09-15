// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// The kernel gateway app settings.
    /// </summary>
    [OutputType]
    public sealed class DomainKernelGatewayAppSettings
    {
        /// <summary>
        /// A list of custom SageMaker images that are configured to run as a KernelGateway app.
        /// </summary>
        public readonly ImmutableArray<Outputs.DomainCustomImage> CustomImages;
        /// <summary>
        /// The default instance type and the Amazon Resource Name (ARN) of the default SageMaker image used by the KernelGateway app.
        /// </summary>
        public readonly Outputs.DomainResourceSpec? DefaultResourceSpec;

        [OutputConstructor]
        private DomainKernelGatewayAppSettings(
            ImmutableArray<Outputs.DomainCustomImage> customImages,

            Outputs.DomainResourceSpec? defaultResourceSpec)
        {
            CustomImages = customImages;
            DefaultResourceSpec = defaultResourceSpec;
        }
    }
}
