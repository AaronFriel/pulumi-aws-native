// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IVS.Outputs
{

    [OutputType]
    public sealed class StreamKeyAttributes
    {
        public readonly string Arn;
        public readonly string Value;

        [OutputConstructor]
        private StreamKeyAttributes(
            string Arn,

            string Value)
        {
            this.Arn = Arn;
            this.Value = Value;
        }
    }
}
