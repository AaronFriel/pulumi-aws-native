// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppRunner.Outputs
{

    /// <summary>
    /// Code Configuration
    /// </summary>
    [OutputType]
    public sealed class ServiceCodeConfiguration
    {
        public readonly Outputs.ServiceCodeConfigurationValues? CodeConfigurationValues;
        /// <summary>
        /// Configuration Source
        /// </summary>
        public readonly Pulumi.AwsNative.AppRunner.ServiceCodeConfigurationConfigurationSource ConfigurationSource;

        [OutputConstructor]
        private ServiceCodeConfiguration(
            Outputs.ServiceCodeConfigurationValues? codeConfigurationValues,

            Pulumi.AwsNative.AppRunner.ServiceCodeConfigurationConfigurationSource configurationSource)
        {
            CodeConfigurationValues = codeConfigurationValues;
            ConfigurationSource = configurationSource;
        }
    }
}
