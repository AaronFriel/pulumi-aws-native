// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.StepFunctions.Outputs
{

    [OutputType]
    public sealed class StateMachineAttributes
    {
        public readonly string Arn;
        public readonly string Name;

        [OutputConstructor]
        private StateMachineAttributes(
            string Arn,

            string Name)
        {
            this.Arn = Arn;
            this.Name = Name;
        }
    }
}
