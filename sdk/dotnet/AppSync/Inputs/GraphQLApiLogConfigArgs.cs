// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html
    /// </summary>
    public sealed class GraphQLApiLogConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-cloudwatchlogsrolearn
        /// </summary>
        [Input("CloudWatchLogsRoleArn")]
        public Input<string>? CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-excludeverbosecontent
        /// </summary>
        [Input("ExcludeVerboseContent")]
        public Input<bool>? ExcludeVerboseContent { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-fieldloglevel
        /// </summary>
        [Input("FieldLogLevel")]
        public Input<string>? FieldLogLevel { get; set; }

        public GraphQLApiLogConfigArgs()
        {
        }
    }
}
