// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfigs.html
    /// </summary>
    public sealed class LoggingConfigurationLogDestinationConfigsArgs : Pulumi.ResourceArgs
    {
        [Input("LogDestinationConfigs")]
        private InputList<Inputs.LoggingConfigurationLogDestinationConfigArgs>? _LogDestinationConfigs;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-logdestinationconfigs.html#cfn-networkfirewall-loggingconfiguration-logdestinationconfigs-logdestinationconfigs
        /// </summary>
        public InputList<Inputs.LoggingConfigurationLogDestinationConfigArgs> LogDestinationConfigs
        {
            get => _LogDestinationConfigs ?? (_LogDestinationConfigs = new InputList<Inputs.LoggingConfigurationLogDestinationConfigArgs>());
            set => _LogDestinationConfigs = value;
        }

        public LoggingConfigurationLogDestinationConfigsArgs()
        {
        }
    }
}
