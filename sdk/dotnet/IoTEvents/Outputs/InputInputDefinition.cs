// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Outputs
{

    [OutputType]
    public sealed class InputInputDefinition
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-inputdefinition.html#cfn-iotevents-input-inputdefinition-attributes
        /// </summary>
        public readonly ImmutableArray<Outputs.InputAttribute> Attributes;

        [OutputConstructor]
        private InputInputDefinition(ImmutableArray<Outputs.InputAttribute> Attributes)
        {
            this.Attributes = Attributes;
        }
    }
}
