// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApplicationInsights.Outputs
{

    /// <summary>
    /// The configuration settings of the component.
    /// </summary>
    [OutputType]
    public sealed class ApplicationComponentConfiguration
    {
        /// <summary>
        /// The configuration settings
        /// </summary>
        public readonly Outputs.ApplicationConfigurationDetails? ConfigurationDetails;
        /// <summary>
        /// Sub component configurations of the component.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationSubComponentTypeConfiguration> SubComponentTypeConfigurations;

        [OutputConstructor]
        private ApplicationComponentConfiguration(
            Outputs.ApplicationConfigurationDetails? configurationDetails,

            ImmutableArray<Outputs.ApplicationSubComponentTypeConfiguration> subComponentTypeConfigurations)
        {
            ConfigurationDetails = configurationDetails;
            SubComponentTypeConfigurations = subComponentTypeConfigurations;
        }
    }
}
