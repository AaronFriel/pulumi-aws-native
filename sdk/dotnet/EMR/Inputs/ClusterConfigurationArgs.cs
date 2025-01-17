// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMR.Inputs
{

    public sealed class ClusterConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("classification")]
        public Input<string>? Classification { get; set; }

        [Input("configurationProperties")]
        public Input<object>? ConfigurationProperties { get; set; }

        [Input("configurations")]
        private InputList<Inputs.ClusterConfigurationArgs>? _configurations;
        public InputList<Inputs.ClusterConfigurationArgs> Configurations
        {
            get => _configurations ?? (_configurations = new InputList<Inputs.ClusterConfigurationArgs>());
            set => _configurations = value;
        }

        public ClusterConfigurationArgs()
        {
        }
    }
}
