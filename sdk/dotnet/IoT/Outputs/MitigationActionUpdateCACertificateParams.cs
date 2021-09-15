// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    /// <summary>
    /// Parameters to define a mitigation action that changes the state of the CA certificate to inactive.
    /// </summary>
    [OutputType]
    public sealed class MitigationActionUpdateCACertificateParams
    {
        public readonly string Action;

        [OutputConstructor]
        private MitigationActionUpdateCACertificateParams(string action)
        {
            Action = action;
        }
    }
}
