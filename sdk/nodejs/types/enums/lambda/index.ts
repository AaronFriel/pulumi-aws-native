// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment = {
    Warn: "Warn",
    Enforce: "Enforce",
} as const;

/**
 * Indicates how Lambda operations involve updating the code artifact will operate. Default to Warn if not provided
 */
export type CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment = (typeof CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment)[keyof typeof CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment];

export const EventSourceMappingFunctionResponseTypesItem = {
    ReportBatchItemFailures: "ReportBatchItemFailures",
} as const;

export type EventSourceMappingFunctionResponseTypesItem = (typeof EventSourceMappingFunctionResponseTypesItem)[keyof typeof EventSourceMappingFunctionResponseTypesItem];

export const EventSourceMappingSourceAccessConfigurationType = {
    BasicAuth: "BASIC_AUTH",
    VpcSubnet: "VPC_SUBNET",
    VpcSecurityGroup: "VPC_SECURITY_GROUP",
    SaslScram512Auth: "SASL_SCRAM_512_AUTH",
    SaslScram256Auth: "SASL_SCRAM_256_AUTH",
    VirtualHost: "VIRTUAL_HOST",
    ClientCertificateTlsAuth: "CLIENT_CERTIFICATE_TLS_AUTH",
    ServerRootCaCertificate: "SERVER_ROOT_CA_CERTIFICATE",
} as const;

/**
 * The type of source access configuration.
 */
export type EventSourceMappingSourceAccessConfigurationType = (typeof EventSourceMappingSourceAccessConfigurationType)[keyof typeof EventSourceMappingSourceAccessConfigurationType];

export const FunctionArchitecturesItem = {
    X8664: "x86_64",
    Arm64: "arm64",
} as const;

export type FunctionArchitecturesItem = (typeof FunctionArchitecturesItem)[keyof typeof FunctionArchitecturesItem];

export const FunctionPackageType = {
    Image: "Image",
    Zip: "Zip",
} as const;

/**
 * PackageType.
 */
export type FunctionPackageType = (typeof FunctionPackageType)[keyof typeof FunctionPackageType];

export const FunctionTracingConfigMode = {
    Active: "Active",
    PassThrough: "PassThrough",
} as const;

/**
 * The tracing mode.
 */
export type FunctionTracingConfigMode = (typeof FunctionTracingConfigMode)[keyof typeof FunctionTracingConfigMode];
