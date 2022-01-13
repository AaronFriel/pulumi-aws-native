// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RDS.Inputs
{

    public sealed class DBProxyAuthFormatArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of authentication that the proxy uses for connections from the proxy to the underlying database. 
        /// </summary>
        [Input("authScheme")]
        public Input<Pulumi.AwsNative.RDS.DBProxyAuthFormatAuthScheme>? AuthScheme { get; set; }

        /// <summary>
        /// A user-specified description about the authentication used by a proxy to log in as a specific database user. 
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to require or disallow AWS Identity and Access Management (IAM) authentication for connections to the proxy. 
        /// </summary>
        [Input("iAMAuth")]
        public Input<Pulumi.AwsNative.RDS.DBProxyAuthFormatIAMAuth>? IAMAuth { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) representing the secret that the proxy uses to authenticate to the RDS DB instance or Aurora DB cluster. These secrets are stored within Amazon Secrets Manager. 
        /// </summary>
        [Input("secretArn")]
        public Input<string>? SecretArn { get; set; }

        /// <summary>
        /// The name of the database user to which the proxy connects.
        /// </summary>
        [Input("userName")]
        public Input<string>? UserName { get; set; }

        public DBProxyAuthFormatArgs()
        {
        }
    }
}
