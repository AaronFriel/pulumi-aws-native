// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGateway.Inputs
{

    public sealed class DeploymentStageDescriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies settings for logging access in this stage.
        /// </summary>
        [Input("accessLogSetting")]
        public Input<Inputs.DeploymentAccessLogSettingArgs>? AccessLogSetting { get; set; }

        /// <summary>
        /// Indicates whether cache clustering is enabled for the stage.
        /// </summary>
        [Input("cacheClusterEnabled")]
        public Input<bool>? CacheClusterEnabled { get; set; }

        /// <summary>
        /// The size of the stage's cache cluster.
        /// </summary>
        [Input("cacheClusterSize")]
        public Input<string>? CacheClusterSize { get; set; }

        /// <summary>
        /// The time-to-live (TTL) period, in seconds, that specifies how long API Gateway caches responses. 
        /// </summary>
        [Input("cacheDataEncrypted")]
        public Input<bool>? CacheDataEncrypted { get; set; }

        /// <summary>
        /// The time-to-live (TTL) period, in seconds, that specifies how long API Gateway caches responses. 
        /// </summary>
        [Input("cacheTtlInSeconds")]
        public Input<int>? CacheTtlInSeconds { get; set; }

        /// <summary>
        /// Indicates whether responses are cached and returned for requests. You must enable a cache cluster on the stage to cache responses.
        /// </summary>
        [Input("cachingEnabled")]
        public Input<bool>? CachingEnabled { get; set; }

        /// <summary>
        /// Specifies settings for the canary deployment in this stage.
        /// </summary>
        [Input("canarySetting")]
        public Input<Inputs.DeploymentCanarySettingArgs>? CanarySetting { get; set; }

        /// <summary>
        /// The identifier of the client certificate that API Gateway uses to call your integration endpoints in the stage. 
        /// </summary>
        [Input("clientCertificateId")]
        public Input<string>? ClientCertificateId { get; set; }

        /// <summary>
        /// Indicates whether data trace logging is enabled for methods in the stage. API Gateway pushes these logs to Amazon CloudWatch Logs. 
        /// </summary>
        [Input("dataTraceEnabled")]
        public Input<bool>? DataTraceEnabled { get; set; }

        /// <summary>
        /// A description of the purpose of the stage.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The version identifier of the API documentation snapshot.
        /// </summary>
        [Input("documentationVersion")]
        public Input<string>? DocumentationVersion { get; set; }

        /// <summary>
        /// The logging level for this method. For valid values, see the loggingLevel property of the Stage resource in the Amazon API Gateway API Reference. 
        /// </summary>
        [Input("loggingLevel")]
        public Input<string>? LoggingLevel { get; set; }

        [Input("methodSettings")]
        private InputList<Inputs.DeploymentMethodSettingArgs>? _methodSettings;

        /// <summary>
        /// Configures settings for all of the stage's methods.
        /// </summary>
        public InputList<Inputs.DeploymentMethodSettingArgs> MethodSettings
        {
            get => _methodSettings ?? (_methodSettings = new InputList<Inputs.DeploymentMethodSettingArgs>());
            set => _methodSettings = value;
        }

        /// <summary>
        /// Indicates whether Amazon CloudWatch metrics are enabled for methods in the stage.
        /// </summary>
        [Input("metricsEnabled")]
        public Input<bool>? MetricsEnabled { get; set; }

        [Input("tags")]
        private InputList<Inputs.DeploymentTagArgs>? _tags;

        /// <summary>
        /// An array of arbitrary tags (key-value pairs) to associate with the stage.
        /// </summary>
        public InputList<Inputs.DeploymentTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.DeploymentTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The number of burst requests per second that API Gateway permits across all APIs, stages, and methods in your AWS account.
        /// </summary>
        [Input("throttlingBurstLimit")]
        public Input<int>? ThrottlingBurstLimit { get; set; }

        /// <summary>
        /// The number of steady-state requests per second that API Gateway permits across all APIs, stages, and methods in your AWS account.
        /// </summary>
        [Input("throttlingRateLimit")]
        public Input<double>? ThrottlingRateLimit { get; set; }

        /// <summary>
        /// Specifies whether active tracing with X-ray is enabled for this stage.
        /// </summary>
        [Input("tracingEnabled")]
        public Input<bool>? TracingEnabled { get; set; }

        /// <summary>
        /// A map that defines the stage variables. Variable names must consist of alphanumeric characters, and the values must match the following regular expression: [A-Za-z0-9-._~:/?#&amp;=,]+. 
        /// </summary>
        [Input("variables")]
        public Input<object>? Variables { get; set; }

        public DeploymentStageDescriptionArgs()
        {
        }
    }
}
