// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Outputs
{

    [OutputType]
    public sealed class TableAttributes
    {
        public readonly string Arn;
        public readonly string StreamArn;

        [OutputConstructor]
        private TableAttributes(
            string Arn,

            string StreamArn)
        {
            this.Arn = Arn;
            this.StreamArn = StreamArn;
        }
    }
}
