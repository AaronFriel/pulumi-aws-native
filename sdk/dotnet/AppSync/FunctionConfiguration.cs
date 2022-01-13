// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync
{
    /// <summary>
    /// Resource Type definition for AWS::AppSync::FunctionConfiguration
    /// </summary>
    [Obsolete(@"FunctionConfiguration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:appsync:FunctionConfiguration")]
    public partial class FunctionConfiguration : Pulumi.CustomResource
    {
        [Output("apiId")]
        public Output<string> ApiId { get; private set; } = null!;

        [Output("dataSourceName")]
        public Output<string> DataSourceName { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("functionArn")]
        public Output<string> FunctionArn { get; private set; } = null!;

        [Output("functionId")]
        public Output<string> FunctionId { get; private set; } = null!;

        [Output("functionVersion")]
        public Output<string> FunctionVersion { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("requestMappingTemplate")]
        public Output<string?> RequestMappingTemplate { get; private set; } = null!;

        [Output("requestMappingTemplateS3Location")]
        public Output<string?> RequestMappingTemplateS3Location { get; private set; } = null!;

        [Output("responseMappingTemplate")]
        public Output<string?> ResponseMappingTemplate { get; private set; } = null!;

        [Output("responseMappingTemplateS3Location")]
        public Output<string?> ResponseMappingTemplateS3Location { get; private set; } = null!;

        [Output("syncConfig")]
        public Output<Outputs.FunctionConfigurationSyncConfig?> SyncConfig { get; private set; } = null!;


        /// <summary>
        /// Create a FunctionConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FunctionConfiguration(string name, FunctionConfigurationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:appsync:FunctionConfiguration", name, args ?? new FunctionConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FunctionConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:appsync:FunctionConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FunctionConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FunctionConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new FunctionConfiguration(name, id, options);
        }
    }

    public sealed class FunctionConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        [Input("dataSourceName", required: true)]
        public Input<string> DataSourceName { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("functionVersion", required: true)]
        public Input<string> FunctionVersion { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("requestMappingTemplate")]
        public Input<string>? RequestMappingTemplate { get; set; }

        [Input("requestMappingTemplateS3Location")]
        public Input<string>? RequestMappingTemplateS3Location { get; set; }

        [Input("responseMappingTemplate")]
        public Input<string>? ResponseMappingTemplate { get; set; }

        [Input("responseMappingTemplateS3Location")]
        public Input<string>? ResponseMappingTemplateS3Location { get; set; }

        [Input("syncConfig")]
        public Input<Inputs.FunctionConfigurationSyncConfigArgs>? SyncConfig { get; set; }

        public FunctionConfigurationArgs()
        {
        }
    }
}
