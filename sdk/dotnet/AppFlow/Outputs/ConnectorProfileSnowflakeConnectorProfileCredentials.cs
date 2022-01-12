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
    public sealed class ConnectorProfileSnowflakeConnectorProfileCredentials
    {
        /// <summary>
        /// The password that corresponds to the username.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// The name of the user.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private ConnectorProfileSnowflakeConnectorProfileCredentials(
            string password,

            string username)
        {
            Password = password;
            Username = username;
        }
    }
}
