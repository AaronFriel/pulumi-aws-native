# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'DataSourceAuthorizationConfig',
    'DataSourceAwsIamConfig',
    'DataSourceDeltaSyncConfig',
    'DataSourceDynamoDBConfig',
    'DataSourceElasticsearchConfig',
    'DataSourceHttpConfig',
    'DataSourceLambdaConfig',
    'DataSourceOpenSearchServiceConfig',
    'DataSourceRdsHttpEndpointConfig',
    'DataSourceRelationalDatabaseConfig',
    'FunctionConfigurationLambdaConflictHandlerConfig',
    'FunctionConfigurationSyncConfig',
    'GraphQLApiAdditionalAuthenticationProviders',
    'GraphQLApiLambdaAuthorizerConfig',
    'GraphQLApiLogConfig',
    'GraphQLApiOpenIDConnectConfig',
    'GraphQLApiTags',
    'GraphQLApiUserPoolConfig',
    'ResolverCachingConfig',
    'ResolverLambdaConflictHandlerConfig',
    'ResolverPipelineConfig',
    'ResolverSyncConfig',
]

@pulumi.output_type
class DataSourceAuthorizationConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "authorizationType":
            suggest = "authorization_type"
        elif key == "awsIamConfig":
            suggest = "aws_iam_config"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceAuthorizationConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceAuthorizationConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceAuthorizationConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 authorization_type: str,
                 aws_iam_config: Optional['outputs.DataSourceAwsIamConfig'] = None):
        pulumi.set(__self__, "authorization_type", authorization_type)
        if aws_iam_config is not None:
            pulumi.set(__self__, "aws_iam_config", aws_iam_config)

    @property
    @pulumi.getter(name="authorizationType")
    def authorization_type(self) -> str:
        return pulumi.get(self, "authorization_type")

    @property
    @pulumi.getter(name="awsIamConfig")
    def aws_iam_config(self) -> Optional['outputs.DataSourceAwsIamConfig']:
        return pulumi.get(self, "aws_iam_config")


@pulumi.output_type
class DataSourceAwsIamConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "signingRegion":
            suggest = "signing_region"
        elif key == "signingServiceName":
            suggest = "signing_service_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceAwsIamConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceAwsIamConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceAwsIamConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 signing_region: Optional[str] = None,
                 signing_service_name: Optional[str] = None):
        if signing_region is not None:
            pulumi.set(__self__, "signing_region", signing_region)
        if signing_service_name is not None:
            pulumi.set(__self__, "signing_service_name", signing_service_name)

    @property
    @pulumi.getter(name="signingRegion")
    def signing_region(self) -> Optional[str]:
        return pulumi.get(self, "signing_region")

    @property
    @pulumi.getter(name="signingServiceName")
    def signing_service_name(self) -> Optional[str]:
        return pulumi.get(self, "signing_service_name")


@pulumi.output_type
class DataSourceDeltaSyncConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "baseTableTTL":
            suggest = "base_table_ttl"
        elif key == "deltaSyncTableName":
            suggest = "delta_sync_table_name"
        elif key == "deltaSyncTableTTL":
            suggest = "delta_sync_table_ttl"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceDeltaSyncConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceDeltaSyncConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceDeltaSyncConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 base_table_ttl: str,
                 delta_sync_table_name: str,
                 delta_sync_table_ttl: str):
        pulumi.set(__self__, "base_table_ttl", base_table_ttl)
        pulumi.set(__self__, "delta_sync_table_name", delta_sync_table_name)
        pulumi.set(__self__, "delta_sync_table_ttl", delta_sync_table_ttl)

    @property
    @pulumi.getter(name="baseTableTTL")
    def base_table_ttl(self) -> str:
        return pulumi.get(self, "base_table_ttl")

    @property
    @pulumi.getter(name="deltaSyncTableName")
    def delta_sync_table_name(self) -> str:
        return pulumi.get(self, "delta_sync_table_name")

    @property
    @pulumi.getter(name="deltaSyncTableTTL")
    def delta_sync_table_ttl(self) -> str:
        return pulumi.get(self, "delta_sync_table_ttl")


@pulumi.output_type
class DataSourceDynamoDBConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "awsRegion":
            suggest = "aws_region"
        elif key == "tableName":
            suggest = "table_name"
        elif key == "deltaSyncConfig":
            suggest = "delta_sync_config"
        elif key == "useCallerCredentials":
            suggest = "use_caller_credentials"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceDynamoDBConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceDynamoDBConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceDynamoDBConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 aws_region: str,
                 table_name: str,
                 delta_sync_config: Optional['outputs.DataSourceDeltaSyncConfig'] = None,
                 use_caller_credentials: Optional[bool] = None,
                 versioned: Optional[bool] = None):
        pulumi.set(__self__, "aws_region", aws_region)
        pulumi.set(__self__, "table_name", table_name)
        if delta_sync_config is not None:
            pulumi.set(__self__, "delta_sync_config", delta_sync_config)
        if use_caller_credentials is not None:
            pulumi.set(__self__, "use_caller_credentials", use_caller_credentials)
        if versioned is not None:
            pulumi.set(__self__, "versioned", versioned)

    @property
    @pulumi.getter(name="awsRegion")
    def aws_region(self) -> str:
        return pulumi.get(self, "aws_region")

    @property
    @pulumi.getter(name="tableName")
    def table_name(self) -> str:
        return pulumi.get(self, "table_name")

    @property
    @pulumi.getter(name="deltaSyncConfig")
    def delta_sync_config(self) -> Optional['outputs.DataSourceDeltaSyncConfig']:
        return pulumi.get(self, "delta_sync_config")

    @property
    @pulumi.getter(name="useCallerCredentials")
    def use_caller_credentials(self) -> Optional[bool]:
        return pulumi.get(self, "use_caller_credentials")

    @property
    @pulumi.getter
    def versioned(self) -> Optional[bool]:
        return pulumi.get(self, "versioned")


@pulumi.output_type
class DataSourceElasticsearchConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "awsRegion":
            suggest = "aws_region"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceElasticsearchConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceElasticsearchConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceElasticsearchConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 aws_region: str,
                 endpoint: str):
        pulumi.set(__self__, "aws_region", aws_region)
        pulumi.set(__self__, "endpoint", endpoint)

    @property
    @pulumi.getter(name="awsRegion")
    def aws_region(self) -> str:
        return pulumi.get(self, "aws_region")

    @property
    @pulumi.getter
    def endpoint(self) -> str:
        return pulumi.get(self, "endpoint")


@pulumi.output_type
class DataSourceHttpConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "authorizationConfig":
            suggest = "authorization_config"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceHttpConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceHttpConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceHttpConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 endpoint: str,
                 authorization_config: Optional['outputs.DataSourceAuthorizationConfig'] = None):
        pulumi.set(__self__, "endpoint", endpoint)
        if authorization_config is not None:
            pulumi.set(__self__, "authorization_config", authorization_config)

    @property
    @pulumi.getter
    def endpoint(self) -> str:
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter(name="authorizationConfig")
    def authorization_config(self) -> Optional['outputs.DataSourceAuthorizationConfig']:
        return pulumi.get(self, "authorization_config")


@pulumi.output_type
class DataSourceLambdaConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "lambdaFunctionArn":
            suggest = "lambda_function_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceLambdaConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceLambdaConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceLambdaConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 lambda_function_arn: str):
        pulumi.set(__self__, "lambda_function_arn", lambda_function_arn)

    @property
    @pulumi.getter(name="lambdaFunctionArn")
    def lambda_function_arn(self) -> str:
        return pulumi.get(self, "lambda_function_arn")


@pulumi.output_type
class DataSourceOpenSearchServiceConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "awsRegion":
            suggest = "aws_region"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceOpenSearchServiceConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceOpenSearchServiceConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceOpenSearchServiceConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 aws_region: str,
                 endpoint: str):
        pulumi.set(__self__, "aws_region", aws_region)
        pulumi.set(__self__, "endpoint", endpoint)

    @property
    @pulumi.getter(name="awsRegion")
    def aws_region(self) -> str:
        return pulumi.get(self, "aws_region")

    @property
    @pulumi.getter
    def endpoint(self) -> str:
        return pulumi.get(self, "endpoint")


@pulumi.output_type
class DataSourceRdsHttpEndpointConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "awsRegion":
            suggest = "aws_region"
        elif key == "awsSecretStoreArn":
            suggest = "aws_secret_store_arn"
        elif key == "dbClusterIdentifier":
            suggest = "db_cluster_identifier"
        elif key == "databaseName":
            suggest = "database_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceRdsHttpEndpointConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceRdsHttpEndpointConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceRdsHttpEndpointConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 aws_region: str,
                 aws_secret_store_arn: str,
                 db_cluster_identifier: str,
                 database_name: Optional[str] = None,
                 schema: Optional[str] = None):
        pulumi.set(__self__, "aws_region", aws_region)
        pulumi.set(__self__, "aws_secret_store_arn", aws_secret_store_arn)
        pulumi.set(__self__, "db_cluster_identifier", db_cluster_identifier)
        if database_name is not None:
            pulumi.set(__self__, "database_name", database_name)
        if schema is not None:
            pulumi.set(__self__, "schema", schema)

    @property
    @pulumi.getter(name="awsRegion")
    def aws_region(self) -> str:
        return pulumi.get(self, "aws_region")

    @property
    @pulumi.getter(name="awsSecretStoreArn")
    def aws_secret_store_arn(self) -> str:
        return pulumi.get(self, "aws_secret_store_arn")

    @property
    @pulumi.getter(name="dbClusterIdentifier")
    def db_cluster_identifier(self) -> str:
        return pulumi.get(self, "db_cluster_identifier")

    @property
    @pulumi.getter(name="databaseName")
    def database_name(self) -> Optional[str]:
        return pulumi.get(self, "database_name")

    @property
    @pulumi.getter
    def schema(self) -> Optional[str]:
        return pulumi.get(self, "schema")


@pulumi.output_type
class DataSourceRelationalDatabaseConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "relationalDatabaseSourceType":
            suggest = "relational_database_source_type"
        elif key == "rdsHttpEndpointConfig":
            suggest = "rds_http_endpoint_config"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DataSourceRelationalDatabaseConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DataSourceRelationalDatabaseConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DataSourceRelationalDatabaseConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 relational_database_source_type: str,
                 rds_http_endpoint_config: Optional['outputs.DataSourceRdsHttpEndpointConfig'] = None):
        pulumi.set(__self__, "relational_database_source_type", relational_database_source_type)
        if rds_http_endpoint_config is not None:
            pulumi.set(__self__, "rds_http_endpoint_config", rds_http_endpoint_config)

    @property
    @pulumi.getter(name="relationalDatabaseSourceType")
    def relational_database_source_type(self) -> str:
        return pulumi.get(self, "relational_database_source_type")

    @property
    @pulumi.getter(name="rdsHttpEndpointConfig")
    def rds_http_endpoint_config(self) -> Optional['outputs.DataSourceRdsHttpEndpointConfig']:
        return pulumi.get(self, "rds_http_endpoint_config")


@pulumi.output_type
class FunctionConfigurationLambdaConflictHandlerConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "lambdaConflictHandlerArn":
            suggest = "lambda_conflict_handler_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in FunctionConfigurationLambdaConflictHandlerConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        FunctionConfigurationLambdaConflictHandlerConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        FunctionConfigurationLambdaConflictHandlerConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 lambda_conflict_handler_arn: Optional[str] = None):
        if lambda_conflict_handler_arn is not None:
            pulumi.set(__self__, "lambda_conflict_handler_arn", lambda_conflict_handler_arn)

    @property
    @pulumi.getter(name="lambdaConflictHandlerArn")
    def lambda_conflict_handler_arn(self) -> Optional[str]:
        return pulumi.get(self, "lambda_conflict_handler_arn")


@pulumi.output_type
class FunctionConfigurationSyncConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "conflictDetection":
            suggest = "conflict_detection"
        elif key == "conflictHandler":
            suggest = "conflict_handler"
        elif key == "lambdaConflictHandlerConfig":
            suggest = "lambda_conflict_handler_config"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in FunctionConfigurationSyncConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        FunctionConfigurationSyncConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        FunctionConfigurationSyncConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 conflict_detection: str,
                 conflict_handler: Optional[str] = None,
                 lambda_conflict_handler_config: Optional['outputs.FunctionConfigurationLambdaConflictHandlerConfig'] = None):
        pulumi.set(__self__, "conflict_detection", conflict_detection)
        if conflict_handler is not None:
            pulumi.set(__self__, "conflict_handler", conflict_handler)
        if lambda_conflict_handler_config is not None:
            pulumi.set(__self__, "lambda_conflict_handler_config", lambda_conflict_handler_config)

    @property
    @pulumi.getter(name="conflictDetection")
    def conflict_detection(self) -> str:
        return pulumi.get(self, "conflict_detection")

    @property
    @pulumi.getter(name="conflictHandler")
    def conflict_handler(self) -> Optional[str]:
        return pulumi.get(self, "conflict_handler")

    @property
    @pulumi.getter(name="lambdaConflictHandlerConfig")
    def lambda_conflict_handler_config(self) -> Optional['outputs.FunctionConfigurationLambdaConflictHandlerConfig']:
        return pulumi.get(self, "lambda_conflict_handler_config")


@pulumi.output_type
class GraphQLApiAdditionalAuthenticationProviders(dict):
    def __init__(__self__):
        pass


@pulumi.output_type
class GraphQLApiLambdaAuthorizerConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "authorizerResultTtlInSeconds":
            suggest = "authorizer_result_ttl_in_seconds"
        elif key == "authorizerUri":
            suggest = "authorizer_uri"
        elif key == "identityValidationExpression":
            suggest = "identity_validation_expression"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GraphQLApiLambdaAuthorizerConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GraphQLApiLambdaAuthorizerConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GraphQLApiLambdaAuthorizerConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 authorizer_result_ttl_in_seconds: Optional[float] = None,
                 authorizer_uri: Optional[str] = None,
                 identity_validation_expression: Optional[str] = None):
        if authorizer_result_ttl_in_seconds is not None:
            pulumi.set(__self__, "authorizer_result_ttl_in_seconds", authorizer_result_ttl_in_seconds)
        if authorizer_uri is not None:
            pulumi.set(__self__, "authorizer_uri", authorizer_uri)
        if identity_validation_expression is not None:
            pulumi.set(__self__, "identity_validation_expression", identity_validation_expression)

    @property
    @pulumi.getter(name="authorizerResultTtlInSeconds")
    def authorizer_result_ttl_in_seconds(self) -> Optional[float]:
        return pulumi.get(self, "authorizer_result_ttl_in_seconds")

    @property
    @pulumi.getter(name="authorizerUri")
    def authorizer_uri(self) -> Optional[str]:
        return pulumi.get(self, "authorizer_uri")

    @property
    @pulumi.getter(name="identityValidationExpression")
    def identity_validation_expression(self) -> Optional[str]:
        return pulumi.get(self, "identity_validation_expression")


@pulumi.output_type
class GraphQLApiLogConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "cloudWatchLogsRoleArn":
            suggest = "cloud_watch_logs_role_arn"
        elif key == "excludeVerboseContent":
            suggest = "exclude_verbose_content"
        elif key == "fieldLogLevel":
            suggest = "field_log_level"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GraphQLApiLogConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GraphQLApiLogConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GraphQLApiLogConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 cloud_watch_logs_role_arn: Optional[str] = None,
                 exclude_verbose_content: Optional[bool] = None,
                 field_log_level: Optional[str] = None):
        if cloud_watch_logs_role_arn is not None:
            pulumi.set(__self__, "cloud_watch_logs_role_arn", cloud_watch_logs_role_arn)
        if exclude_verbose_content is not None:
            pulumi.set(__self__, "exclude_verbose_content", exclude_verbose_content)
        if field_log_level is not None:
            pulumi.set(__self__, "field_log_level", field_log_level)

    @property
    @pulumi.getter(name="cloudWatchLogsRoleArn")
    def cloud_watch_logs_role_arn(self) -> Optional[str]:
        return pulumi.get(self, "cloud_watch_logs_role_arn")

    @property
    @pulumi.getter(name="excludeVerboseContent")
    def exclude_verbose_content(self) -> Optional[bool]:
        return pulumi.get(self, "exclude_verbose_content")

    @property
    @pulumi.getter(name="fieldLogLevel")
    def field_log_level(self) -> Optional[str]:
        return pulumi.get(self, "field_log_level")


@pulumi.output_type
class GraphQLApiOpenIDConnectConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "authTTL":
            suggest = "auth_ttl"
        elif key == "clientId":
            suggest = "client_id"
        elif key == "iatTTL":
            suggest = "iat_ttl"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GraphQLApiOpenIDConnectConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GraphQLApiOpenIDConnectConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GraphQLApiOpenIDConnectConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 auth_ttl: Optional[float] = None,
                 client_id: Optional[str] = None,
                 iat_ttl: Optional[float] = None,
                 issuer: Optional[str] = None):
        if auth_ttl is not None:
            pulumi.set(__self__, "auth_ttl", auth_ttl)
        if client_id is not None:
            pulumi.set(__self__, "client_id", client_id)
        if iat_ttl is not None:
            pulumi.set(__self__, "iat_ttl", iat_ttl)
        if issuer is not None:
            pulumi.set(__self__, "issuer", issuer)

    @property
    @pulumi.getter(name="authTTL")
    def auth_ttl(self) -> Optional[float]:
        return pulumi.get(self, "auth_ttl")

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> Optional[str]:
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="iatTTL")
    def iat_ttl(self) -> Optional[float]:
        return pulumi.get(self, "iat_ttl")

    @property
    @pulumi.getter
    def issuer(self) -> Optional[str]:
        return pulumi.get(self, "issuer")


@pulumi.output_type
class GraphQLApiTags(dict):
    def __init__(__self__):
        pass


@pulumi.output_type
class GraphQLApiUserPoolConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "appIdClientRegex":
            suggest = "app_id_client_regex"
        elif key == "awsRegion":
            suggest = "aws_region"
        elif key == "defaultAction":
            suggest = "default_action"
        elif key == "userPoolId":
            suggest = "user_pool_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in GraphQLApiUserPoolConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        GraphQLApiUserPoolConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        GraphQLApiUserPoolConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 app_id_client_regex: Optional[str] = None,
                 aws_region: Optional[str] = None,
                 default_action: Optional[str] = None,
                 user_pool_id: Optional[str] = None):
        if app_id_client_regex is not None:
            pulumi.set(__self__, "app_id_client_regex", app_id_client_regex)
        if aws_region is not None:
            pulumi.set(__self__, "aws_region", aws_region)
        if default_action is not None:
            pulumi.set(__self__, "default_action", default_action)
        if user_pool_id is not None:
            pulumi.set(__self__, "user_pool_id", user_pool_id)

    @property
    @pulumi.getter(name="appIdClientRegex")
    def app_id_client_regex(self) -> Optional[str]:
        return pulumi.get(self, "app_id_client_regex")

    @property
    @pulumi.getter(name="awsRegion")
    def aws_region(self) -> Optional[str]:
        return pulumi.get(self, "aws_region")

    @property
    @pulumi.getter(name="defaultAction")
    def default_action(self) -> Optional[str]:
        return pulumi.get(self, "default_action")

    @property
    @pulumi.getter(name="userPoolId")
    def user_pool_id(self) -> Optional[str]:
        return pulumi.get(self, "user_pool_id")


@pulumi.output_type
class ResolverCachingConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "cachingKeys":
            suggest = "caching_keys"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ResolverCachingConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ResolverCachingConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ResolverCachingConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 caching_keys: Optional[Sequence[str]] = None,
                 ttl: Optional[float] = None):
        if caching_keys is not None:
            pulumi.set(__self__, "caching_keys", caching_keys)
        if ttl is not None:
            pulumi.set(__self__, "ttl", ttl)

    @property
    @pulumi.getter(name="cachingKeys")
    def caching_keys(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "caching_keys")

    @property
    @pulumi.getter
    def ttl(self) -> Optional[float]:
        return pulumi.get(self, "ttl")


@pulumi.output_type
class ResolverLambdaConflictHandlerConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "lambdaConflictHandlerArn":
            suggest = "lambda_conflict_handler_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ResolverLambdaConflictHandlerConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ResolverLambdaConflictHandlerConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ResolverLambdaConflictHandlerConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 lambda_conflict_handler_arn: Optional[str] = None):
        if lambda_conflict_handler_arn is not None:
            pulumi.set(__self__, "lambda_conflict_handler_arn", lambda_conflict_handler_arn)

    @property
    @pulumi.getter(name="lambdaConflictHandlerArn")
    def lambda_conflict_handler_arn(self) -> Optional[str]:
        return pulumi.get(self, "lambda_conflict_handler_arn")


@pulumi.output_type
class ResolverPipelineConfig(dict):
    def __init__(__self__, *,
                 functions: Optional[Sequence[str]] = None):
        if functions is not None:
            pulumi.set(__self__, "functions", functions)

    @property
    @pulumi.getter
    def functions(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "functions")


@pulumi.output_type
class ResolverSyncConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "conflictDetection":
            suggest = "conflict_detection"
        elif key == "conflictHandler":
            suggest = "conflict_handler"
        elif key == "lambdaConflictHandlerConfig":
            suggest = "lambda_conflict_handler_config"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ResolverSyncConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ResolverSyncConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ResolverSyncConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 conflict_detection: str,
                 conflict_handler: Optional[str] = None,
                 lambda_conflict_handler_config: Optional['outputs.ResolverLambdaConflictHandlerConfig'] = None):
        pulumi.set(__self__, "conflict_detection", conflict_detection)
        if conflict_handler is not None:
            pulumi.set(__self__, "conflict_handler", conflict_handler)
        if lambda_conflict_handler_config is not None:
            pulumi.set(__self__, "lambda_conflict_handler_config", lambda_conflict_handler_config)

    @property
    @pulumi.getter(name="conflictDetection")
    def conflict_detection(self) -> str:
        return pulumi.get(self, "conflict_detection")

    @property
    @pulumi.getter(name="conflictHandler")
    def conflict_handler(self) -> Optional[str]:
        return pulumi.get(self, "conflict_handler")

    @property
    @pulumi.getter(name="lambdaConflictHandlerConfig")
    def lambda_conflict_handler_config(self) -> Optional['outputs.ResolverLambdaConflictHandlerConfig']:
        return pulumi.get(self, "lambda_conflict_handler_config")


