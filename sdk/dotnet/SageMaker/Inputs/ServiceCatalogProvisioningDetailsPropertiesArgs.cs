// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Inputs
{

    /// <summary>
    /// Input ServiceCatalog Provisioning Details
    /// </summary>
    public sealed class ServiceCatalogProvisioningDetailsPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("pathId")]
        public Input<string>? PathId { get; set; }

        [Input("productId", required: true)]
        public Input<string> ProductId { get; set; } = null!;

        [Input("provisioningArtifactId", required: true)]
        public Input<string> ProvisioningArtifactId { get; set; } = null!;

        [Input("provisioningParameters")]
        private InputList<Inputs.ProjectProvisioningParameterArgs>? _provisioningParameters;

        /// <summary>
        /// Parameters specified by the administrator that are required for provisioning the product.
        /// </summary>
        public InputList<Inputs.ProjectProvisioningParameterArgs> ProvisioningParameters
        {
            get => _provisioningParameters ?? (_provisioningParameters = new InputList<Inputs.ProjectProvisioningParameterArgs>());
            set => _provisioningParameters = value;
        }

        public ServiceCatalogProvisioningDetailsPropertiesArgs()
        {
        }
    }
}