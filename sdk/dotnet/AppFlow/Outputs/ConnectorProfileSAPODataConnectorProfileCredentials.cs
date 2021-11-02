// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    [OutputType]
    public sealed class ConnectorProfileSAPODataConnectorProfileCredentials
    {
        public readonly Outputs.ConnectorProfileSAPODataConnectorProfileCredentialsBasicAuthCredentialsProperties? BasicAuthCredentials;
        public readonly Outputs.ConnectorProfileSAPODataConnectorProfileCredentialsOAuthCredentialsProperties? OAuthCredentials;

        [OutputConstructor]
        private ConnectorProfileSAPODataConnectorProfileCredentials(
            Outputs.ConnectorProfileSAPODataConnectorProfileCredentialsBasicAuthCredentialsProperties? basicAuthCredentials,

            Outputs.ConnectorProfileSAPODataConnectorProfileCredentialsOAuthCredentialsProperties? oAuthCredentials)
        {
            BasicAuthCredentials = basicAuthCredentials;
            OAuthCredentials = oAuthCredentials;
        }
    }
}