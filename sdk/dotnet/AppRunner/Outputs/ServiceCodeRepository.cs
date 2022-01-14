// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppRunner.Outputs
{

    /// <summary>
    /// Source Code Repository
    /// </summary>
    [OutputType]
    public sealed class ServiceCodeRepository
    {
        public readonly Outputs.ServiceCodeConfiguration? CodeConfiguration;
        /// <summary>
        /// Repository Url
        /// </summary>
        public readonly string RepositoryUrl;
        public readonly Outputs.ServiceSourceCodeVersion SourceCodeVersion;

        [OutputConstructor]
        private ServiceCodeRepository(
            Outputs.ServiceCodeConfiguration? codeConfiguration,

            string repositoryUrl,

            Outputs.ServiceSourceCodeVersion sourceCodeVersion)
        {
            CodeConfiguration = codeConfiguration;
            RepositoryUrl = repositoryUrl;
            SourceCodeVersion = sourceCodeVersion;
        }
    }
}
