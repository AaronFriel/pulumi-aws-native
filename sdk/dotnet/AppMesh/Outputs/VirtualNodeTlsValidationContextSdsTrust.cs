// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualNodeTlsValidationContextSdsTrust
    {
        public readonly string SecretName;

        [OutputConstructor]
        private VirtualNodeTlsValidationContextSdsTrust(string secretName)
        {
            SecretName = secretName;
        }
    }
}
