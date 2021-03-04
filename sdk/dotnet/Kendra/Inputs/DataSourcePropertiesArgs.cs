// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html
    /// </summary>
    public sealed class DataSourcePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-datasourceconfiguration
        /// </summary>
        [Input("DataSourceConfiguration")]
        public Input<Inputs.DataSourceDataSourceConfigurationArgs>? DataSourceConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-description
        /// </summary>
        [Input("Description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-indexid
        /// </summary>
        [Input("IndexId", required: true)]
        public Input<string> IndexId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-name
        /// </summary>
        [Input("Name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-rolearn
        /// </summary>
        [Input("RoleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-schedule
        /// </summary>
        [Input("Schedule")]
        public Input<string>? Schedule { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-tags
        /// </summary>
        [Input("Tags")]
        public Input<Inputs.DataSourceTagListArgs>? Tags { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kendra-datasource.html#cfn-kendra-datasource-type
        /// </summary>
        [Input("Type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DataSourcePropertiesArgs()
        {
        }
    }
}
