// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation
{
    /// <summary>
    /// A module that has been registered in the CloudFormation registry as the default version
    /// </summary>
    [AwsNativeResourceType("aws-native:cloudformation:ModuleDefaultVersion")]
    public partial class ModuleDefaultVersion : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the module version to set as the default version.
        /// </summary>
        [Output("arn")]
        public Output<string?> Arn { get; private set; } = null!;

        /// <summary>
        /// The name of a module existing in the registry.
        /// </summary>
        [Output("moduleName")]
        public Output<string?> ModuleName { get; private set; } = null!;

        /// <summary>
        /// The ID of an existing version of the named module to set as the default.
        /// </summary>
        [Output("versionId")]
        public Output<string?> VersionId { get; private set; } = null!;


        /// <summary>
        /// Create a ModuleDefaultVersion resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ModuleDefaultVersion(string name, ModuleDefaultVersionArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:cloudformation:ModuleDefaultVersion", name, args ?? new ModuleDefaultVersionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ModuleDefaultVersion(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:cloudformation:ModuleDefaultVersion", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ModuleDefaultVersion resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ModuleDefaultVersion Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ModuleDefaultVersion(name, id, options);
        }
    }

    public sealed class ModuleDefaultVersionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the module version to set as the default version.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The name of a module existing in the registry.
        /// </summary>
        [Input("moduleName")]
        public Input<string>? ModuleName { get; set; }

        /// <summary>
        /// The ID of an existing version of the named module to set as the default.
        /// </summary>
        [Input("versionId")]
        public Input<string>? VersionId { get; set; }

        public ModuleDefaultVersionArgs()
        {
        }
    }
}
