// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DocDB.Outputs
{

    [OutputType]
    public sealed class DBInstanceAttributes
    {
        public readonly string Endpoint;
        public readonly string Port;

        [OutputConstructor]
        private DBInstanceAttributes(
            string Endpoint,

            string Port)
        {
            this.Endpoint = Endpoint;
            this.Port = Port;
        }
    }
}
