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
    public sealed class DocumentationPartProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-location
        /// </summary>
        public readonly Outputs.DocumentationPartLocation Location;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-properties
        /// </summary>
        public readonly string Properties;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationpart.html#cfn-apigateway-documentationpart-restapiid
        /// </summary>
        public readonly string RestApiId;

        [OutputConstructor]
        private DocumentationPartProperties(
            Outputs.DocumentationPartLocation Location,

            string Properties,

            string RestApiId)
        {
            this.Location = Location;
            this.Properties = Properties;
            this.RestApiId = RestApiId;
        }
    }
}
