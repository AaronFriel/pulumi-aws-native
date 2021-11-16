# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment',
    'EventSourceMappingFunctionResponseTypesItem',
    'EventSourceMappingSourceAccessConfigurationType',
    'FunctionArchitecturesItem',
    'FunctionPackageType',
    'FunctionTracingConfigMode',
]


class CodeSigningConfigCodeSigningPoliciesUntrustedArtifactOnDeployment(str, Enum):
    """
    Indicates how Lambda operations involve updating the code artifact will operate. Default to Warn if not provided
    """
    WARN = "Warn"
    ENFORCE = "Enforce"


class EventSourceMappingFunctionResponseTypesItem(str, Enum):
    REPORT_BATCH_ITEM_FAILURES = "ReportBatchItemFailures"


class EventSourceMappingSourceAccessConfigurationType(str, Enum):
    """
    The type of source access configuration.
    """
    BASIC_AUTH = "BASIC_AUTH"
    VPC_SUBNET = "VPC_SUBNET"
    VPC_SECURITY_GROUP = "VPC_SECURITY_GROUP"
    SASL_SCRAM512_AUTH = "SASL_SCRAM_512_AUTH"
    SASL_SCRAM256_AUTH = "SASL_SCRAM_256_AUTH"
    VIRTUAL_HOST = "VIRTUAL_HOST"
    CLIENT_CERTIFICATE_TLS_AUTH = "CLIENT_CERTIFICATE_TLS_AUTH"
    SERVER_ROOT_CA_CERTIFICATE = "SERVER_ROOT_CA_CERTIFICATE"


class FunctionArchitecturesItem(str, Enum):
    X8664 = "x86_64"
    ARM64 = "arm64"


class FunctionPackageType(str, Enum):
    """
    PackageType.
    """
    IMAGE = "Image"
    ZIP = "Zip"


class FunctionTracingConfigMode(str, Enum):
    """
    The tracing mode.
    """
    ACTIVE = "Active"
    PASS_THROUGH = "PassThrough"
