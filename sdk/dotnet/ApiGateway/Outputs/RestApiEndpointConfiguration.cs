// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGateway.Outputs
{

    [OutputType]
    public sealed class RestApiEndpointConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-restapi-endpointconfiguration.html#cfn-apigateway-restapi-endpointconfiguration-types
        /// </summary>
        public readonly ImmutableArray<string> Types;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-restapi-endpointconfiguration.html#cfn-apigateway-restapi-endpointconfiguration-vpcendpointids
        /// </summary>
        public readonly ImmutableArray<string> VpcEndpointIds;

        [OutputConstructor]
        private RestApiEndpointConfiguration(
            ImmutableArray<string> Types,

            ImmutableArray<string> VpcEndpointIds)
        {
            this.Types = Types;
            this.VpcEndpointIds = VpcEndpointIds;
        }
    }
}
