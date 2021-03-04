// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative
{
    public static class GetSsmParameterString
    {
        public static Task<GetSsmParameterStringResult> InvokeAsync(GetSsmParameterStringArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSsmParameterStringResult>("aws-native:index:getSsmParameterString", args ?? new GetSsmParameterStringArgs(), options.WithVersion());
    }


    public sealed class GetSsmParameterStringArgs : Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetSsmParameterStringArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSsmParameterStringResult
    {
        public readonly string Value;

        [OutputConstructor]
        private GetSsmParameterStringResult(string value)
        {
            Value = value;
        }
    }
}
