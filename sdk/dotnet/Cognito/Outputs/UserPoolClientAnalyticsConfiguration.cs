// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Outputs
{

    [OutputType]
    public sealed class UserPoolClientAnalyticsConfiguration
    {
        public readonly string? ApplicationArn;
        public readonly string? ApplicationId;
        public readonly string? ExternalId;
        public readonly string? RoleArn;
        public readonly bool? UserDataShared;

        [OutputConstructor]
        private UserPoolClientAnalyticsConfiguration(
            string? applicationArn,

            string? applicationId,

            string? externalId,

            string? roleArn,

            bool? userDataShared)
        {
            ApplicationArn = applicationArn;
            ApplicationId = applicationId;
            ExternalId = externalId;
            RoleArn = roleArn;
            UserDataShared = userDataShared;
        }
    }
}