// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Inputs
{

    public sealed class DomainConfigurationAuthorizerConfigArgs : Pulumi.ResourceArgs
    {
        [Input("allowAuthorizerOverride")]
        public Input<bool>? AllowAuthorizerOverride { get; set; }

        [Input("defaultAuthorizerName")]
        public Input<string>? DefaultAuthorizerName { get; set; }

        public DomainConfigurationAuthorizerConfigArgs()
        {
        }
    }
}
