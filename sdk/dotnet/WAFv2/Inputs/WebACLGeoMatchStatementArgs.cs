// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html
    /// </summary>
    public sealed class WebACLGeoMatchStatementArgs : Pulumi.ResourceArgs
    {
        [Input("CountryCodes")]
        private InputList<string>? _CountryCodes;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html#cfn-wafv2-webacl-geomatchstatement-countrycodes
        /// </summary>
        public InputList<string> CountryCodes
        {
            get => _CountryCodes ?? (_CountryCodes = new InputList<string>());
            set => _CountryCodes = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-webacl-geomatchstatement.html#cfn-wafv2-webacl-geomatchstatement-forwardedipconfig
        /// </summary>
        [Input("ForwardedIPConfig")]
        public Input<Inputs.WebACLForwardedIPConfigurationArgs>? ForwardedIPConfig { get; set; }

        public WebACLGeoMatchStatementArgs()
        {
        }
    }
}
