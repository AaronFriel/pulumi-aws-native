// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.FinSpace.Outputs
{

    /// <summary>
    /// Additional parameters to identify Federation mode
    /// </summary>
    [OutputType]
    public sealed class EnvironmentFederationParameters
    {
        /// <summary>
        /// SAML metadata URL to link with the Environment
        /// </summary>
        public readonly string? ApplicationCallBackURL;
        /// <summary>
        /// Attribute map for SAML configuration
        /// </summary>
        public readonly object? AttributeMap;
        /// <summary>
        /// Federation provider name to link with the Environment
        /// </summary>
        public readonly string? FederationProviderName;
        /// <summary>
        /// SAML metadata URL to link with the Environment
        /// </summary>
        public readonly string? FederationURN;
        /// <summary>
        /// SAML metadata document to link the federation provider to the Environment
        /// </summary>
        public readonly string? SamlMetadataDocument;
        /// <summary>
        /// SAML metadata URL to link with the Environment
        /// </summary>
        public readonly string? SamlMetadataURL;

        [OutputConstructor]
        private EnvironmentFederationParameters(
            string? applicationCallBackURL,

            object? attributeMap,

            string? federationProviderName,

            string? federationURN,

            string? samlMetadataDocument,

            string? samlMetadataURL)
        {
            ApplicationCallBackURL = applicationCallBackURL;
            AttributeMap = attributeMap;
            FederationProviderName = federationProviderName;
            FederationURN = federationURN;
            SamlMetadataDocument = samlMetadataDocument;
            SamlMetadataURL = samlMetadataURL;
        }
    }
}
