// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalyticsV2.Inputs
{

    public sealed class ApplicationZeppelinApplicationConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("catalogConfiguration")]
        public Input<Inputs.ApplicationCatalogConfigurationArgs>? CatalogConfiguration { get; set; }

        [Input("customArtifactsConfiguration")]
        private InputList<Inputs.ApplicationCustomArtifactConfigurationArgs>? _customArtifactsConfiguration;
        public InputList<Inputs.ApplicationCustomArtifactConfigurationArgs> CustomArtifactsConfiguration
        {
            get => _customArtifactsConfiguration ?? (_customArtifactsConfiguration = new InputList<Inputs.ApplicationCustomArtifactConfigurationArgs>());
            set => _customArtifactsConfiguration = value;
        }

        [Input("deployAsApplicationConfiguration")]
        public Input<Inputs.ApplicationDeployAsApplicationConfigurationArgs>? DeployAsApplicationConfiguration { get; set; }

        [Input("monitoringConfiguration")]
        public Input<Inputs.ApplicationZeppelinMonitoringConfigurationArgs>? MonitoringConfiguration { get; set; }

        public ApplicationZeppelinApplicationConfigurationArgs()
        {
        }
    }
}
