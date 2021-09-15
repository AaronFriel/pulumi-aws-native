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
    /// A collection of settings that apply to users of Amazon SageMaker Studio. These settings are specified when the CreateUserProfile API is called, and as DefaultUserSettings when the CreateDomain API is called.
    /// </summary>
    [OutputType]
    public sealed class DomainUserSettings
    {
        /// <summary>
        /// The user profile Amazon Resource Name (ARN).
        /// </summary>
        public readonly string? ExecutionRole;
        /// <summary>
        /// The Jupyter server's app settings.
        /// </summary>
        public readonly Outputs.DomainJupyterServerAppSettings? JupyterServerAppSettings;
        /// <summary>
        /// The kernel gateway app settings.
        /// </summary>
        public readonly Outputs.DomainKernelGatewayAppSettings? KernelGatewayAppSettings;
        /// <summary>
        /// The security groups for the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroups;
        /// <summary>
        /// The sharing settings.
        /// </summary>
        public readonly Outputs.DomainSharingSettings? SharingSettings;

        [OutputConstructor]
        private DomainUserSettings(
            string? executionRole,

            Outputs.DomainJupyterServerAppSettings? jupyterServerAppSettings,

            Outputs.DomainKernelGatewayAppSettings? kernelGatewayAppSettings,

            ImmutableArray<string> securityGroups,

            Outputs.DomainSharingSettings? sharingSettings)
        {
            ExecutionRole = executionRole;
            JupyterServerAppSettings = jupyterServerAppSettings;
            KernelGatewayAppSettings = kernelGatewayAppSettings;
            SecurityGroups = securityGroups;
            SharingSettings = sharingSettings;
        }
    }
}
