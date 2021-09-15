// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LicenseManager
{
    /// <summary>
    /// Resource Type definition for AWS::LicenseManager::License
    /// </summary>
    [AwsNativeResourceType("aws-native:licensemanager:License")]
    public partial class License : Pulumi.CustomResource
    {
        /// <summary>
        /// Beneficiary of the license.
        /// </summary>
        [Output("beneficiary")]
        public Output<string?> Beneficiary { get; private set; } = null!;

        [Output("consumptionConfiguration")]
        public Output<Outputs.LicenseConsumptionConfiguration> ConsumptionConfiguration { get; private set; } = null!;

        [Output("entitlements")]
        public Output<ImmutableArray<Outputs.LicenseEntitlement>> Entitlements { get; private set; } = null!;

        /// <summary>
        /// Home region for the created license.
        /// </summary>
        [Output("homeRegion")]
        public Output<string> HomeRegion { get; private set; } = null!;

        [Output("issuer")]
        public Output<Outputs.LicenseIssuerData> Issuer { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name is a unique name for each resource.
        /// </summary>
        [Output("licenseArn")]
        public Output<string> LicenseArn { get; private set; } = null!;

        [Output("licenseMetadata")]
        public Output<ImmutableArray<Outputs.LicenseMetadata>> LicenseMetadata { get; private set; } = null!;

        /// <summary>
        /// Name for the created license.
        /// </summary>
        [Output("licenseName")]
        public Output<string> LicenseName { get; private set; } = null!;

        /// <summary>
        /// Product name for the created license.
        /// </summary>
        [Output("productName")]
        public Output<string> ProductName { get; private set; } = null!;

        /// <summary>
        /// ProductSKU of the license.
        /// </summary>
        [Output("productSKU")]
        public Output<string?> ProductSKU { get; private set; } = null!;

        [Output("status")]
        public Output<string?> Status { get; private set; } = null!;

        [Output("validity")]
        public Output<Outputs.LicenseValidityDateFormat> Validity { get; private set; } = null!;

        /// <summary>
        /// The version of the license.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a License resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public License(string name, LicenseArgs args, CustomResourceOptions? options = null)
            : base("aws-native:licensemanager:License", name, args ?? new LicenseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private License(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:licensemanager:License", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing License resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static License Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new License(name, id, options);
        }
    }

    public sealed class LicenseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Beneficiary of the license.
        /// </summary>
        [Input("beneficiary")]
        public Input<string>? Beneficiary { get; set; }

        [Input("consumptionConfiguration", required: true)]
        public Input<Inputs.LicenseConsumptionConfigurationArgs> ConsumptionConfiguration { get; set; } = null!;

        [Input("entitlements", required: true)]
        private InputList<Inputs.LicenseEntitlementArgs>? _entitlements;
        public InputList<Inputs.LicenseEntitlementArgs> Entitlements
        {
            get => _entitlements ?? (_entitlements = new InputList<Inputs.LicenseEntitlementArgs>());
            set => _entitlements = value;
        }

        /// <summary>
        /// Home region for the created license.
        /// </summary>
        [Input("homeRegion", required: true)]
        public Input<string> HomeRegion { get; set; } = null!;

        [Input("issuer", required: true)]
        public Input<Inputs.LicenseIssuerDataArgs> Issuer { get; set; } = null!;

        [Input("licenseMetadata")]
        private InputList<Inputs.LicenseMetadataArgs>? _licenseMetadata;
        public InputList<Inputs.LicenseMetadataArgs> LicenseMetadata
        {
            get => _licenseMetadata ?? (_licenseMetadata = new InputList<Inputs.LicenseMetadataArgs>());
            set => _licenseMetadata = value;
        }

        /// <summary>
        /// Name for the created license.
        /// </summary>
        [Input("licenseName", required: true)]
        public Input<string> LicenseName { get; set; } = null!;

        /// <summary>
        /// Product name for the created license.
        /// </summary>
        [Input("productName", required: true)]
        public Input<string> ProductName { get; set; } = null!;

        /// <summary>
        /// ProductSKU of the license.
        /// </summary>
        [Input("productSKU")]
        public Input<string>? ProductSKU { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("validity", required: true)]
        public Input<Inputs.LicenseValidityDateFormatArgs> Validity { get; set; } = null!;

        public LicenseArgs()
        {
        }
    }
}
