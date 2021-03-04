// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Elasticsearch.Inputs
{

    /// <summary>
    /// The UpdatePolicy for a Domain resource.
    /// </summary>
    public sealed class DomainUpdatePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// To upgrade an Amazon ES domain to a new version of Elasticsearch rather than replacing the entire AWS::Elasticsearch::Domain resource, use the EnableVersionUpgrade update policy.
        /// 
        /// If EnableVersionUpgrade is set to true, you can update the ElasticsearchVersion property of the AWS::Elasticsearch::Domain resource, and CloudFormation will update that property without interruption. When EnableVersionUpgrade is set to false, or not specified, updating the ElasticsearchVersion property results in CloudFormation replacing the entire AWS::Elasticsearch::Domain resource.
        /// 
        /// The EnableVersionUpgrade update policy has no properties.
        /// 
        /// For more information about upgrading Amazon ES domains, see UpgradeElasticsearchDomain in the Amazon Elasticsearch Service Developer Guide.
        /// </summary>
        [Input("EnableVersionUpgrade")]
        public Input<bool>? EnableVersionUpgrade { get; set; }

        public DomainUpdatePolicyArgs()
        {
        }
    }
}
