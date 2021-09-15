// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    /// <summary>
    /// The configuration for a specific audit check.
    /// </summary>
    [OutputType]
    public sealed class AccountAuditConfigurationAuditCheckConfiguration
    {
        /// <summary>
        /// True if the check is enabled.
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private AccountAuditConfigurationAuditCheckConfiguration(bool? enabled)
        {
            Enabled = enabled;
        }
    }
}
