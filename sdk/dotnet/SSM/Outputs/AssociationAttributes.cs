// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Outputs
{

    [OutputType]
    public sealed class AssociationAttributes
    {
        public readonly string AssociationId;

        [OutputConstructor]
        private AssociationAttributes(string AssociationId)
        {
            this.AssociationId = AssociationId;
        }
    }
}
