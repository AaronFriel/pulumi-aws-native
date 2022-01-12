// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AwsNative.Lambda
{
    /// <summary>
    /// Indicates how Lambda operations involve updating the code artifact will operate. Default to Warn if not provided
    /// </summary>
    [EnumType]
    public readonly struct CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment : IEquatable<CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment>
    {
        private readonly string _value;

        private CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment Warn { get; } = new CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment("Warn");
        public static CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment Enforce { get; } = new CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment("Enforce");

        public static bool operator ==(CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment left, CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment right) => left.Equals(right);
        public static bool operator !=(CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment left, CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment right) => !left.Equals(right);

        public static explicit operator string(CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment other && Equals(other);
        public bool Equals(CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct EventSourceMappingFunctionResponseTypesItem : IEquatable<EventSourceMappingFunctionResponseTypesItem>
    {
        private readonly string _value;

        private EventSourceMappingFunctionResponseTypesItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static EventSourceMappingFunctionResponseTypesItem ReportBatchItemFailures { get; } = new EventSourceMappingFunctionResponseTypesItem("ReportBatchItemFailures");

        public static bool operator ==(EventSourceMappingFunctionResponseTypesItem left, EventSourceMappingFunctionResponseTypesItem right) => left.Equals(right);
        public static bool operator !=(EventSourceMappingFunctionResponseTypesItem left, EventSourceMappingFunctionResponseTypesItem right) => !left.Equals(right);

        public static explicit operator string(EventSourceMappingFunctionResponseTypesItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is EventSourceMappingFunctionResponseTypesItem other && Equals(other);
        public bool Equals(EventSourceMappingFunctionResponseTypesItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type of source access configuration.
    /// </summary>
    [EnumType]
    public readonly struct EventSourceMappingSourceAccessConfigurationType : IEquatable<EventSourceMappingSourceAccessConfigurationType>
    {
        private readonly string _value;

        private EventSourceMappingSourceAccessConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static EventSourceMappingSourceAccessConfigurationType BasicAuth { get; } = new EventSourceMappingSourceAccessConfigurationType("BASIC_AUTH");
        public static EventSourceMappingSourceAccessConfigurationType VpcSubnet { get; } = new EventSourceMappingSourceAccessConfigurationType("VPC_SUBNET");
        public static EventSourceMappingSourceAccessConfigurationType VpcSecurityGroup { get; } = new EventSourceMappingSourceAccessConfigurationType("VPC_SECURITY_GROUP");
        public static EventSourceMappingSourceAccessConfigurationType SaslScram512Auth { get; } = new EventSourceMappingSourceAccessConfigurationType("SASL_SCRAM_512_AUTH");
        public static EventSourceMappingSourceAccessConfigurationType SaslScram256Auth { get; } = new EventSourceMappingSourceAccessConfigurationType("SASL_SCRAM_256_AUTH");
        public static EventSourceMappingSourceAccessConfigurationType VirtualHost { get; } = new EventSourceMappingSourceAccessConfigurationType("VIRTUAL_HOST");
        public static EventSourceMappingSourceAccessConfigurationType ClientCertificateTlsAuth { get; } = new EventSourceMappingSourceAccessConfigurationType("CLIENT_CERTIFICATE_TLS_AUTH");
        public static EventSourceMappingSourceAccessConfigurationType ServerRootCaCertificate { get; } = new EventSourceMappingSourceAccessConfigurationType("SERVER_ROOT_CA_CERTIFICATE");

        public static bool operator ==(EventSourceMappingSourceAccessConfigurationType left, EventSourceMappingSourceAccessConfigurationType right) => left.Equals(right);
        public static bool operator !=(EventSourceMappingSourceAccessConfigurationType left, EventSourceMappingSourceAccessConfigurationType right) => !left.Equals(right);

        public static explicit operator string(EventSourceMappingSourceAccessConfigurationType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is EventSourceMappingSourceAccessConfigurationType other && Equals(other);
        public bool Equals(EventSourceMappingSourceAccessConfigurationType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct FunctionArchitecturesItem : IEquatable<FunctionArchitecturesItem>
    {
        private readonly string _value;

        private FunctionArchitecturesItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static FunctionArchitecturesItem X8664 { get; } = new FunctionArchitecturesItem("x86_64");
        public static FunctionArchitecturesItem Arm64 { get; } = new FunctionArchitecturesItem("arm64");

        public static bool operator ==(FunctionArchitecturesItem left, FunctionArchitecturesItem right) => left.Equals(right);
        public static bool operator !=(FunctionArchitecturesItem left, FunctionArchitecturesItem right) => !left.Equals(right);

        public static explicit operator string(FunctionArchitecturesItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is FunctionArchitecturesItem other && Equals(other);
        public bool Equals(FunctionArchitecturesItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// PackageType.
    /// </summary>
    [EnumType]
    public readonly struct FunctionPackageType : IEquatable<FunctionPackageType>
    {
        private readonly string _value;

        private FunctionPackageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static FunctionPackageType Image { get; } = new FunctionPackageType("Image");
        public static FunctionPackageType Zip { get; } = new FunctionPackageType("Zip");

        public static bool operator ==(FunctionPackageType left, FunctionPackageType right) => left.Equals(right);
        public static bool operator !=(FunctionPackageType left, FunctionPackageType right) => !left.Equals(right);

        public static explicit operator string(FunctionPackageType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is FunctionPackageType other && Equals(other);
        public bool Equals(FunctionPackageType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The tracing mode.
    /// </summary>
    [EnumType]
    public readonly struct FunctionTracingConfigMode : IEquatable<FunctionTracingConfigMode>
    {
        private readonly string _value;

        private FunctionTracingConfigMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static FunctionTracingConfigMode Active { get; } = new FunctionTracingConfigMode("Active");
        public static FunctionTracingConfigMode PassThrough { get; } = new FunctionTracingConfigMode("PassThrough");

        public static bool operator ==(FunctionTracingConfigMode left, FunctionTracingConfigMode right) => left.Equals(right);
        public static bool operator !=(FunctionTracingConfigMode left, FunctionTracingConfigMode right) => !left.Equals(right);

        public static explicit operator string(FunctionTracingConfigMode value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is FunctionTracingConfigMode other && Equals(other);
        public bool Equals(FunctionTracingConfigMode other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    [EnumType]
    public readonly struct UrlAllowMethodsItem : IEquatable<UrlAllowMethodsItem>
    {
        private readonly string _value;

        private UrlAllowMethodsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static UrlAllowMethodsItem Get { get; } = new UrlAllowMethodsItem("GET");
        public static UrlAllowMethodsItem Put { get; } = new UrlAllowMethodsItem("PUT");
        public static UrlAllowMethodsItem Head { get; } = new UrlAllowMethodsItem("HEAD");
        public static UrlAllowMethodsItem Post { get; } = new UrlAllowMethodsItem("POST");
        public static UrlAllowMethodsItem Patch { get; } = new UrlAllowMethodsItem("PATCH");
        public static UrlAllowMethodsItem Delete { get; } = new UrlAllowMethodsItem("DELETE");
        public static UrlAllowMethodsItem Asterisk { get; } = new UrlAllowMethodsItem("*");

        public static bool operator ==(UrlAllowMethodsItem left, UrlAllowMethodsItem right) => left.Equals(right);
        public static bool operator !=(UrlAllowMethodsItem left, UrlAllowMethodsItem right) => !left.Equals(right);

        public static explicit operator string(UrlAllowMethodsItem value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is UrlAllowMethodsItem other && Equals(other);
        public bool Equals(UrlAllowMethodsItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Can be either AWS_IAM if the requests are authorized via IAM, or NONE if no authorization is configured on the Function URL.
    /// </summary>
    [EnumType]
    public readonly struct UrlAuthorizationType : IEquatable<UrlAuthorizationType>
    {
        private readonly string _value;

        private UrlAuthorizationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static UrlAuthorizationType AwsIam { get; } = new UrlAuthorizationType("AWS_IAM");
        public static UrlAuthorizationType None { get; } = new UrlAuthorizationType("NONE");

        public static bool operator ==(UrlAuthorizationType left, UrlAuthorizationType right) => left.Equals(right);
        public static bool operator !=(UrlAuthorizationType left, UrlAuthorizationType right) => !left.Equals(right);

        public static explicit operator string(UrlAuthorizationType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is UrlAuthorizationType other && Equals(other);
        public bool Equals(UrlAuthorizationType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
