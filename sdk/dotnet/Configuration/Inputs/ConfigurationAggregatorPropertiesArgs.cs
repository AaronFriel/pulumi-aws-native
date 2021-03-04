// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Configuration.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html
    /// </summary>
    public sealed class ConfigurationAggregatorPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("AccountAggregationSources")]
        private InputList<Inputs.ConfigurationAggregatorAccountAggregationSourceArgs>? _AccountAggregationSources;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-accountaggregationsources
        /// </summary>
        public InputList<Inputs.ConfigurationAggregatorAccountAggregationSourceArgs> AccountAggregationSources
        {
            get => _AccountAggregationSources ?? (_AccountAggregationSources = new InputList<Inputs.ConfigurationAggregatorAccountAggregationSourceArgs>());
            set => _AccountAggregationSources = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-configurationaggregatorname
        /// </summary>
        [Input("ConfigurationAggregatorName", required: true)]
        public Input<string> ConfigurationAggregatorName { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-organizationaggregationsource
        /// </summary>
        [Input("OrganizationAggregationSource")]
        public Input<Inputs.ConfigurationAggregatorOrganizationAggregationSourceArgs>? OrganizationAggregationSource { get; set; }

        [Input("Tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _Tags = value;
        }

        public ConfigurationAggregatorPropertiesArgs()
        {
        }
    }
}
