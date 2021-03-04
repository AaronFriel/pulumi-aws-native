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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html
    /// </summary>
    public sealed class ConfigurationAggregatorOrganizationAggregationSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-allawsregions
        /// </summary>
        [Input("AllAwsRegions")]
        public Input<bool>? AllAwsRegions { get; set; }

        [Input("AwsRegions")]
        private InputList<string>? _AwsRegions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-awsregions
        /// </summary>
        public InputList<string> AwsRegions
        {
            get => _AwsRegions ?? (_AwsRegions = new InputList<string>());
            set => _AwsRegions = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-rolearn
        /// </summary>
        [Input("RoleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public ConfigurationAggregatorOrganizationAggregationSourceArgs()
        {
        }
    }
}
