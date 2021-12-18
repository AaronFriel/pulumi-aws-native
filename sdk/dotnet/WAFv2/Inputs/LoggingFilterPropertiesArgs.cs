// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// Filtering that specifies which web requests are kept in the logs and which are dropped. You can filter on the rule action and on the web request labels that were applied by matching rules during web ACL evaluation.
    /// </summary>
    public sealed class LoggingFilterPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Default handling for logs that don't match any of the specified filtering conditions.
        /// </summary>
        [Input("defaultBehavior", required: true)]
        public Input<Pulumi.AwsNative.WAFv2.LoggingConfigurationLoggingFilterPropertiesDefaultBehavior> DefaultBehavior { get; set; } = null!;

        [Input("filters", required: true)]
        private InputList<Inputs.LoggingConfigurationFilterArgs>? _filters;

        /// <summary>
        /// The filters that you want to apply to the logs.
        /// </summary>
        public InputList<Inputs.LoggingConfigurationFilterArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.LoggingConfigurationFilterArgs>());
            set => _filters = value;
        }

        public LoggingFilterPropertiesArgs()
        {
        }
    }
}
