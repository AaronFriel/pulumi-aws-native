// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.PinpointEmail.Inputs
{

    public sealed class ConfigurationSetEventDestinationCloudWatchDestinationArgs : Pulumi.ResourceArgs
    {
        [Input("dimensionConfigurations")]
        private InputList<Inputs.ConfigurationSetEventDestinationDimensionConfigurationArgs>? _dimensionConfigurations;
        public InputList<Inputs.ConfigurationSetEventDestinationDimensionConfigurationArgs> DimensionConfigurations
        {
            get => _dimensionConfigurations ?? (_dimensionConfigurations = new InputList<Inputs.ConfigurationSetEventDestinationDimensionConfigurationArgs>());
            set => _dimensionConfigurations = value;
        }

        public ConfigurationSetEventDestinationCloudWatchDestinationArgs()
        {
        }
    }
}
