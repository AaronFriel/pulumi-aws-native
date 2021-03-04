// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html
    /// </summary>
    public sealed class DistributionCacheBehaviorArgs : Pulumi.ResourceArgs
    {
        [Input("AllowedMethods")]
        private InputList<string>? _AllowedMethods;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-allowedmethods
        /// </summary>
        public InputList<string> AllowedMethods
        {
            get => _AllowedMethods ?? (_AllowedMethods = new InputList<string>());
            set => _AllowedMethods = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-cachepolicyid
        /// </summary>
        [Input("CachePolicyId")]
        public Input<string>? CachePolicyId { get; set; }

        [Input("CachedMethods")]
        private InputList<string>? _CachedMethods;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-cachedmethods
        /// </summary>
        public InputList<string> CachedMethods
        {
            get => _CachedMethods ?? (_CachedMethods = new InputList<string>());
            set => _CachedMethods = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-compress
        /// </summary>
        [Input("Compress")]
        public Input<bool>? Compress { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-defaultttl
        /// </summary>
        [Input("DefaultTTL")]
        public Input<double>? DefaultTTL { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-fieldlevelencryptionid
        /// </summary>
        [Input("FieldLevelEncryptionId")]
        public Input<string>? FieldLevelEncryptionId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-forwardedvalues
        /// </summary>
        [Input("ForwardedValues")]
        public Input<Inputs.DistributionForwardedValuesArgs>? ForwardedValues { get; set; }

        [Input("LambdaFunctionAssociations")]
        private InputList<Inputs.DistributionLambdaFunctionAssociationArgs>? _LambdaFunctionAssociations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-lambdafunctionassociations
        /// </summary>
        public InputList<Inputs.DistributionLambdaFunctionAssociationArgs> LambdaFunctionAssociations
        {
            get => _LambdaFunctionAssociations ?? (_LambdaFunctionAssociations = new InputList<Inputs.DistributionLambdaFunctionAssociationArgs>());
            set => _LambdaFunctionAssociations = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-maxttl
        /// </summary>
        [Input("MaxTTL")]
        public Input<double>? MaxTTL { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-minttl
        /// </summary>
        [Input("MinTTL")]
        public Input<double>? MinTTL { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-originrequestpolicyid
        /// </summary>
        [Input("OriginRequestPolicyId")]
        public Input<string>? OriginRequestPolicyId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-pathpattern
        /// </summary>
        [Input("PathPattern", required: true)]
        public Input<string> PathPattern { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-realtimelogconfigarn
        /// </summary>
        [Input("RealtimeLogConfigArn")]
        public Input<string>? RealtimeLogConfigArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-smoothstreaming
        /// </summary>
        [Input("SmoothStreaming")]
        public Input<bool>? SmoothStreaming { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-targetoriginid
        /// </summary>
        [Input("TargetOriginId", required: true)]
        public Input<string> TargetOriginId { get; set; } = null!;

        [Input("TrustedKeyGroups")]
        private InputList<string>? _TrustedKeyGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-trustedkeygroups
        /// </summary>
        public InputList<string> TrustedKeyGroups
        {
            get => _TrustedKeyGroups ?? (_TrustedKeyGroups = new InputList<string>());
            set => _TrustedKeyGroups = value;
        }

        [Input("TrustedSigners")]
        private InputList<string>? _TrustedSigners;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-trustedsigners
        /// </summary>
        public InputList<string> TrustedSigners
        {
            get => _TrustedSigners ?? (_TrustedSigners = new InputList<string>());
            set => _TrustedSigners = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-viewerprotocolpolicy
        /// </summary>
        [Input("ViewerProtocolPolicy", required: true)]
        public Input<string> ViewerProtocolPolicy { get; set; } = null!;

        public DistributionCacheBehaviorArgs()
        {
        }
    }
}
