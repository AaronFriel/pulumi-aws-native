// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppRunner.Inputs
{

    /// <summary>
    /// Code Configuration
    /// </summary>
    public sealed class ServiceCodeConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("codeConfigurationValues")]
        public Input<Inputs.ServiceCodeConfigurationValuesArgs>? CodeConfigurationValues { get; set; }

        /// <summary>
        /// Configuration Source
        /// </summary>
        [Input("configurationSource", required: true)]
        public Input<string> ConfigurationSource { get; set; } = null!;

        public ServiceCodeConfigurationArgs()
        {
        }
    }
}
