// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.FinSpace
{
    /// <summary>
    /// An example resource schema demonstrating some basic constructs and validation rules.
    /// </summary>
    [AwsNativeResourceType("aws-native:finspace:Environment")]
    public partial class Environment : Pulumi.CustomResource
    {
        /// <summary>
        /// AWS account ID associated with the Environment
        /// </summary>
        [Output("awsAccountId")]
        public Output<string> AwsAccountId { get; private set; } = null!;

        /// <summary>
        /// ARNs of FinSpace Data Bundles to install
        /// </summary>
        [Output("dataBundles")]
        public Output<ImmutableArray<string>> DataBundles { get; private set; } = null!;

        /// <summary>
        /// ID for FinSpace created account used to store Environment artifacts
        /// </summary>
        [Output("dedicatedServiceAccountId")]
        public Output<string> DedicatedServiceAccountId { get; private set; } = null!;

        /// <summary>
        /// Description of the Environment
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// ARN of the Environment
        /// </summary>
        [Output("environmentArn")]
        public Output<string> EnvironmentArn { get; private set; } = null!;

        /// <summary>
        /// Unique identifier for representing FinSpace Environment
        /// </summary>
        [Output("environmentId")]
        public Output<string> EnvironmentId { get; private set; } = null!;

        /// <summary>
        /// URL used to login to the Environment
        /// </summary>
        [Output("environmentUrl")]
        public Output<string> EnvironmentUrl { get; private set; } = null!;

        /// <summary>
        /// Federation mode used with the Environment
        /// </summary>
        [Output("federationMode")]
        public Output<Pulumi.AwsNative.FinSpace.EnvironmentFederationMode?> FederationMode { get; private set; } = null!;

        [Output("federationParameters")]
        public Output<Outputs.EnvironmentFederationParameters?> FederationParameters { get; private set; } = null!;

        /// <summary>
        /// KMS key used to encrypt customer data within FinSpace Environment infrastructure
        /// </summary>
        [Output("kmsKeyId")]
        public Output<string?> KmsKeyId { get; private set; } = null!;

        /// <summary>
        /// Name of the Environment
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// SageMaker Studio Domain URL associated with the Environment
        /// </summary>
        [Output("sageMakerStudioDomainUrl")]
        public Output<string> SageMakerStudioDomainUrl { get; private set; } = null!;

        /// <summary>
        /// State of the Environment
        /// </summary>
        [Output("status")]
        public Output<Pulumi.AwsNative.FinSpace.EnvironmentStatus> Status { get; private set; } = null!;

        [Output("superuserParameters")]
        public Output<Outputs.EnvironmentSuperuserParameters?> SuperuserParameters { get; private set; } = null!;


        /// <summary>
        /// Create a Environment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Environment(string name, EnvironmentArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:finspace:Environment", name, args ?? new EnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Environment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:finspace:Environment", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Environment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Environment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Environment(name, id, options);
        }
    }

    public sealed class EnvironmentArgs : Pulumi.ResourceArgs
    {
        [Input("dataBundles")]
        private InputList<string>? _dataBundles;

        /// <summary>
        /// ARNs of FinSpace Data Bundles to install
        /// </summary>
        public InputList<string> DataBundles
        {
            get => _dataBundles ?? (_dataBundles = new InputList<string>());
            set => _dataBundles = value;
        }

        /// <summary>
        /// Description of the Environment
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Federation mode used with the Environment
        /// </summary>
        [Input("federationMode")]
        public Input<Pulumi.AwsNative.FinSpace.EnvironmentFederationMode>? FederationMode { get; set; }

        [Input("federationParameters")]
        public Input<Inputs.EnvironmentFederationParametersArgs>? FederationParameters { get; set; }

        /// <summary>
        /// KMS key used to encrypt customer data within FinSpace Environment infrastructure
        /// </summary>
        [Input("kmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        /// <summary>
        /// Name of the Environment
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("superuserParameters")]
        public Input<Inputs.EnvironmentSuperuserParametersArgs>? SuperuserParameters { get; set; }

        public EnvironmentArgs()
        {
        }
    }
}
