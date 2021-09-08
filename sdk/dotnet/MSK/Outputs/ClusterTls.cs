// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MSK.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-tls.html
    /// </summary>
    [OutputType]
    public sealed class ClusterTls
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-tls.html#cfn-msk-cluster-tls-certificateauthorityarnlist
        /// </summary>
        public readonly ImmutableArray<string> CertificateAuthorityArnList;

        [OutputConstructor]
        private ClusterTls(ImmutableArray<string> certificateAuthorityArnList)
        {
            CertificateAuthorityArnList = certificateAuthorityArnList;
        }
    }
}