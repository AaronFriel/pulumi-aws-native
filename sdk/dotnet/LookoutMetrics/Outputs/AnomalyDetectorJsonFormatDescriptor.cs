// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LookoutMetrics.Outputs
{

    [OutputType]
    public sealed class AnomalyDetectorJsonFormatDescriptor
    {
        public readonly string? Charset;
        public readonly Pulumi.AwsNative.LookoutMetrics.AnomalyDetectorJsonFormatDescriptorFileCompression? FileCompression;

        [OutputConstructor]
        private AnomalyDetectorJsonFormatDescriptor(
            string? charset,

            Pulumi.AwsNative.LookoutMetrics.AnomalyDetectorJsonFormatDescriptorFileCompression? fileCompression)
        {
            Charset = charset;
            FileCompression = fileCompression;
        }
    }
}
