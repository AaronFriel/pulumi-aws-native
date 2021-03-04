// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MWAA.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html
    /// </summary>
    public sealed class EnvironmentPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-airflowconfigurationoptions
        /// </summary>
        [Input("AirflowConfigurationOptions")]
        public Input<Inputs.EnvironmentAirflowConfigurationOptionsArgs>? AirflowConfigurationOptions { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-airflowversion
        /// </summary>
        [Input("AirflowVersion")]
        public Input<string>? AirflowVersion { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-dags3path
        /// </summary>
        [Input("DagS3Path")]
        public Input<string>? DagS3Path { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-environmentclass
        /// </summary>
        [Input("EnvironmentClass")]
        public Input<string>? EnvironmentClass { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-executionrolearn
        /// </summary>
        [Input("ExecutionRoleArn")]
        public Input<string>? ExecutionRoleArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-kmskey
        /// </summary>
        [Input("KmsKey")]
        public Input<string>? KmsKey { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-loggingconfiguration
        /// </summary>
        [Input("LoggingConfiguration")]
        public Input<Inputs.EnvironmentLoggingConfigurationArgs>? LoggingConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-maxworkers
        /// </summary>
        [Input("MaxWorkers")]
        public Input<int>? MaxWorkers { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-networkconfiguration
        /// </summary>
        [Input("NetworkConfiguration")]
        public Input<Inputs.EnvironmentNetworkConfigurationArgs>? NetworkConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-pluginss3objectversion
        /// </summary>
        [Input("PluginsS3ObjectVersion")]
        public Input<string>? PluginsS3ObjectVersion { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-pluginss3path
        /// </summary>
        [Input("PluginsS3Path")]
        public Input<string>? PluginsS3Path { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-requirementss3objectversion
        /// </summary>
        [Input("RequirementsS3ObjectVersion")]
        public Input<string>? RequirementsS3ObjectVersion { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-requirementss3path
        /// </summary>
        [Input("RequirementsS3Path")]
        public Input<string>? RequirementsS3Path { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-sourcebucketarn
        /// </summary>
        [Input("SourceBucketArn")]
        public Input<string>? SourceBucketArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-tags
        /// </summary>
        [Input("Tags")]
        public Input<Inputs.EnvironmentTagMapArgs>? Tags { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-webserveraccessmode
        /// </summary>
        [Input("WebserverAccessMode")]
        public Input<string>? WebserverAccessMode { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-webserverurl
        /// </summary>
        [Input("WebserverUrl")]
        public Input<string>? WebserverUrl { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mwaa-environment.html#cfn-mwaa-environment-weeklymaintenancewindowstart
        /// </summary>
        [Input("WeeklyMaintenanceWindowStart")]
        public Input<string>? WeeklyMaintenanceWindowStart { get; set; }

        public EnvironmentPropertiesArgs()
        {
        }
    }
}
