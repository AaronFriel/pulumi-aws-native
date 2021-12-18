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
    public sealed class ConnectorProfileConnectorOAuthRequest
    {
        /// <summary>
        /// The code provided by the connector when it has been authenticated via the connected app.
        /// </summary>
        public readonly string? AuthCode;
        /// <summary>
        /// The URL to which the authentication server redirects the browser after authorization has been
        /// granted.
        /// </summary>
        public readonly string? RedirectUri;

        [OutputConstructor]
        private ConnectorProfileConnectorOAuthRequest(
            string? authCode,

            string? redirectUri)
        {
            AuthCode = authCode;
            RedirectUri = redirectUri;
        }
    }
}
