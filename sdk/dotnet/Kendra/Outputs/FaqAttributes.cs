// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Outputs
{

    [OutputType]
    public sealed class FaqAttributes
    {
        public readonly string Arn;
        public readonly string Id;

        [OutputConstructor]
        private FaqAttributes(
            string Arn,

            string Id)
        {
            this.Arn = Arn;
            this.Id = Id;
        }
    }
}
