// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    [OutputType]
    public sealed class ConnectorProfileAttributes
    {
        public readonly string ConnectorProfileArn;
        public readonly string CredentialsArn;

        [OutputConstructor]
        private ConnectorProfileAttributes(
            string ConnectorProfileArn,

            string CredentialsArn)
        {
            this.ConnectorProfileArn = ConnectorProfileArn;
            this.CredentialsArn = CredentialsArn;
        }
    }
}
