// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda.Inputs
{

    /// <summary>
    /// When the CodeSigningConfig is later on attached to a function, the function code will be expected to be signed by profiles from this list
    /// </summary>
    public sealed class CodeSigningConfigAllowedPublishersArgs : Pulumi.ResourceArgs
    {
        [Input("signingProfileVersionArns", required: true)]
        private InputList<string>? _signingProfileVersionArns;

        /// <summary>
        /// List of Signing profile version Arns
        /// </summary>
        public InputList<string> SigningProfileVersionArns
        {
            get => _signingProfileVersionArns ?? (_signingProfileVersionArns = new InputList<string>());
            set => _signingProfileVersionArns = value;
        }

        public CodeSigningConfigAllowedPublishersArgs()
        {
        }
    }
}
