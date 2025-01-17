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
    'DomainAdvancedSecurityOptionsInput',
    'DomainClusterConfig',
    'DomainCognitoOptions',
    'DomainEBSOptions',
    'DomainEncryptionAtRestOptions',
    'DomainEndpointOptions',
    'DomainMasterUserOptions',
    'DomainNodeToNodeEncryptionOptions',
    'DomainServiceSoftwareOptions',
    'DomainSnapshotOptions',
    'DomainTag',
    'DomainVPCOptions',
    'DomainZoneAwarenessConfig',
]

@pulumi.output_type
class DomainAdvancedSecurityOptionsInput(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "internalUserDatabaseEnabled":
            suggest = "internal_user_database_enabled"
        elif key == "masterUserOptions":
            suggest = "master_user_options"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainAdvancedSecurityOptionsInput. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainAdvancedSecurityOptionsInput.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainAdvancedSecurityOptionsInput.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 enabled: Optional[bool] = None,
                 internal_user_database_enabled: Optional[bool] = None,
                 master_user_options: Optional['outputs.DomainMasterUserOptions'] = None):
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if internal_user_database_enabled is not None:
            pulumi.set(__self__, "internal_user_database_enabled", internal_user_database_enabled)
        if master_user_options is not None:
            pulumi.set(__self__, "master_user_options", master_user_options)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="internalUserDatabaseEnabled")
    def internal_user_database_enabled(self) -> Optional[bool]:
        return pulumi.get(self, "internal_user_database_enabled")

    @property
    @pulumi.getter(name="masterUserOptions")
    def master_user_options(self) -> Optional['outputs.DomainMasterUserOptions']:
        return pulumi.get(self, "master_user_options")


@pulumi.output_type
class DomainClusterConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "dedicatedMasterCount":
            suggest = "dedicated_master_count"
        elif key == "dedicatedMasterEnabled":
            suggest = "dedicated_master_enabled"
        elif key == "dedicatedMasterType":
            suggest = "dedicated_master_type"
        elif key == "instanceCount":
            suggest = "instance_count"
        elif key == "instanceType":
            suggest = "instance_type"
        elif key == "warmCount":
            suggest = "warm_count"
        elif key == "warmEnabled":
            suggest = "warm_enabled"
        elif key == "warmType":
            suggest = "warm_type"
        elif key == "zoneAwarenessConfig":
            suggest = "zone_awareness_config"
        elif key == "zoneAwarenessEnabled":
            suggest = "zone_awareness_enabled"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainClusterConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainClusterConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainClusterConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 dedicated_master_count: Optional[int] = None,
                 dedicated_master_enabled: Optional[bool] = None,
                 dedicated_master_type: Optional[str] = None,
                 instance_count: Optional[int] = None,
                 instance_type: Optional[str] = None,
                 warm_count: Optional[int] = None,
                 warm_enabled: Optional[bool] = None,
                 warm_type: Optional[str] = None,
                 zone_awareness_config: Optional['outputs.DomainZoneAwarenessConfig'] = None,
                 zone_awareness_enabled: Optional[bool] = None):
        if dedicated_master_count is not None:
            pulumi.set(__self__, "dedicated_master_count", dedicated_master_count)
        if dedicated_master_enabled is not None:
            pulumi.set(__self__, "dedicated_master_enabled", dedicated_master_enabled)
        if dedicated_master_type is not None:
            pulumi.set(__self__, "dedicated_master_type", dedicated_master_type)
        if instance_count is not None:
            pulumi.set(__self__, "instance_count", instance_count)
        if instance_type is not None:
            pulumi.set(__self__, "instance_type", instance_type)
        if warm_count is not None:
            pulumi.set(__self__, "warm_count", warm_count)
        if warm_enabled is not None:
            pulumi.set(__self__, "warm_enabled", warm_enabled)
        if warm_type is not None:
            pulumi.set(__self__, "warm_type", warm_type)
        if zone_awareness_config is not None:
            pulumi.set(__self__, "zone_awareness_config", zone_awareness_config)
        if zone_awareness_enabled is not None:
            pulumi.set(__self__, "zone_awareness_enabled", zone_awareness_enabled)

    @property
    @pulumi.getter(name="dedicatedMasterCount")
    def dedicated_master_count(self) -> Optional[int]:
        return pulumi.get(self, "dedicated_master_count")

    @property
    @pulumi.getter(name="dedicatedMasterEnabled")
    def dedicated_master_enabled(self) -> Optional[bool]:
        return pulumi.get(self, "dedicated_master_enabled")

    @property
    @pulumi.getter(name="dedicatedMasterType")
    def dedicated_master_type(self) -> Optional[str]:
        return pulumi.get(self, "dedicated_master_type")

    @property
    @pulumi.getter(name="instanceCount")
    def instance_count(self) -> Optional[int]:
        return pulumi.get(self, "instance_count")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> Optional[str]:
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="warmCount")
    def warm_count(self) -> Optional[int]:
        return pulumi.get(self, "warm_count")

    @property
    @pulumi.getter(name="warmEnabled")
    def warm_enabled(self) -> Optional[bool]:
        return pulumi.get(self, "warm_enabled")

    @property
    @pulumi.getter(name="warmType")
    def warm_type(self) -> Optional[str]:
        return pulumi.get(self, "warm_type")

    @property
    @pulumi.getter(name="zoneAwarenessConfig")
    def zone_awareness_config(self) -> Optional['outputs.DomainZoneAwarenessConfig']:
        return pulumi.get(self, "zone_awareness_config")

    @property
    @pulumi.getter(name="zoneAwarenessEnabled")
    def zone_awareness_enabled(self) -> Optional[bool]:
        return pulumi.get(self, "zone_awareness_enabled")


@pulumi.output_type
class DomainCognitoOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "identityPoolId":
            suggest = "identity_pool_id"
        elif key == "roleArn":
            suggest = "role_arn"
        elif key == "userPoolId":
            suggest = "user_pool_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainCognitoOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainCognitoOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainCognitoOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 enabled: Optional[bool] = None,
                 identity_pool_id: Optional[str] = None,
                 role_arn: Optional[str] = None,
                 user_pool_id: Optional[str] = None):
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if identity_pool_id is not None:
            pulumi.set(__self__, "identity_pool_id", identity_pool_id)
        if role_arn is not None:
            pulumi.set(__self__, "role_arn", role_arn)
        if user_pool_id is not None:
            pulumi.set(__self__, "user_pool_id", user_pool_id)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="identityPoolId")
    def identity_pool_id(self) -> Optional[str]:
        return pulumi.get(self, "identity_pool_id")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> Optional[str]:
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter(name="userPoolId")
    def user_pool_id(self) -> Optional[str]:
        return pulumi.get(self, "user_pool_id")


@pulumi.output_type
class DomainEBSOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "eBSEnabled":
            suggest = "e_bs_enabled"
        elif key == "volumeSize":
            suggest = "volume_size"
        elif key == "volumeType":
            suggest = "volume_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainEBSOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainEBSOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainEBSOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 e_bs_enabled: Optional[bool] = None,
                 iops: Optional[int] = None,
                 volume_size: Optional[int] = None,
                 volume_type: Optional[str] = None):
        if e_bs_enabled is not None:
            pulumi.set(__self__, "e_bs_enabled", e_bs_enabled)
        if iops is not None:
            pulumi.set(__self__, "iops", iops)
        if volume_size is not None:
            pulumi.set(__self__, "volume_size", volume_size)
        if volume_type is not None:
            pulumi.set(__self__, "volume_type", volume_type)

    @property
    @pulumi.getter(name="eBSEnabled")
    def e_bs_enabled(self) -> Optional[bool]:
        return pulumi.get(self, "e_bs_enabled")

    @property
    @pulumi.getter
    def iops(self) -> Optional[int]:
        return pulumi.get(self, "iops")

    @property
    @pulumi.getter(name="volumeSize")
    def volume_size(self) -> Optional[int]:
        return pulumi.get(self, "volume_size")

    @property
    @pulumi.getter(name="volumeType")
    def volume_type(self) -> Optional[str]:
        return pulumi.get(self, "volume_type")


@pulumi.output_type
class DomainEncryptionAtRestOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "kmsKeyId":
            suggest = "kms_key_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainEncryptionAtRestOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainEncryptionAtRestOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainEncryptionAtRestOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 enabled: Optional[bool] = None,
                 kms_key_id: Optional[str] = None):
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if kms_key_id is not None:
            pulumi.set(__self__, "kms_key_id", kms_key_id)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="kmsKeyId")
    def kms_key_id(self) -> Optional[str]:
        return pulumi.get(self, "kms_key_id")


@pulumi.output_type
class DomainEndpointOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "customEndpoint":
            suggest = "custom_endpoint"
        elif key == "customEndpointCertificateArn":
            suggest = "custom_endpoint_certificate_arn"
        elif key == "customEndpointEnabled":
            suggest = "custom_endpoint_enabled"
        elif key == "enforceHTTPS":
            suggest = "enforce_https"
        elif key == "tLSSecurityPolicy":
            suggest = "t_ls_security_policy"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainEndpointOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainEndpointOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainEndpointOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 custom_endpoint: Optional[str] = None,
                 custom_endpoint_certificate_arn: Optional[str] = None,
                 custom_endpoint_enabled: Optional[bool] = None,
                 enforce_https: Optional[bool] = None,
                 t_ls_security_policy: Optional[str] = None):
        if custom_endpoint is not None:
            pulumi.set(__self__, "custom_endpoint", custom_endpoint)
        if custom_endpoint_certificate_arn is not None:
            pulumi.set(__self__, "custom_endpoint_certificate_arn", custom_endpoint_certificate_arn)
        if custom_endpoint_enabled is not None:
            pulumi.set(__self__, "custom_endpoint_enabled", custom_endpoint_enabled)
        if enforce_https is not None:
            pulumi.set(__self__, "enforce_https", enforce_https)
        if t_ls_security_policy is not None:
            pulumi.set(__self__, "t_ls_security_policy", t_ls_security_policy)

    @property
    @pulumi.getter(name="customEndpoint")
    def custom_endpoint(self) -> Optional[str]:
        return pulumi.get(self, "custom_endpoint")

    @property
    @pulumi.getter(name="customEndpointCertificateArn")
    def custom_endpoint_certificate_arn(self) -> Optional[str]:
        return pulumi.get(self, "custom_endpoint_certificate_arn")

    @property
    @pulumi.getter(name="customEndpointEnabled")
    def custom_endpoint_enabled(self) -> Optional[bool]:
        return pulumi.get(self, "custom_endpoint_enabled")

    @property
    @pulumi.getter(name="enforceHTTPS")
    def enforce_https(self) -> Optional[bool]:
        return pulumi.get(self, "enforce_https")

    @property
    @pulumi.getter(name="tLSSecurityPolicy")
    def t_ls_security_policy(self) -> Optional[str]:
        return pulumi.get(self, "t_ls_security_policy")


@pulumi.output_type
class DomainMasterUserOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "masterUserARN":
            suggest = "master_user_arn"
        elif key == "masterUserName":
            suggest = "master_user_name"
        elif key == "masterUserPassword":
            suggest = "master_user_password"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainMasterUserOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainMasterUserOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainMasterUserOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 master_user_arn: Optional[str] = None,
                 master_user_name: Optional[str] = None,
                 master_user_password: Optional[str] = None):
        if master_user_arn is not None:
            pulumi.set(__self__, "master_user_arn", master_user_arn)
        if master_user_name is not None:
            pulumi.set(__self__, "master_user_name", master_user_name)
        if master_user_password is not None:
            pulumi.set(__self__, "master_user_password", master_user_password)

    @property
    @pulumi.getter(name="masterUserARN")
    def master_user_arn(self) -> Optional[str]:
        return pulumi.get(self, "master_user_arn")

    @property
    @pulumi.getter(name="masterUserName")
    def master_user_name(self) -> Optional[str]:
        return pulumi.get(self, "master_user_name")

    @property
    @pulumi.getter(name="masterUserPassword")
    def master_user_password(self) -> Optional[str]:
        return pulumi.get(self, "master_user_password")


@pulumi.output_type
class DomainNodeToNodeEncryptionOptions(dict):
    def __init__(__self__, *,
                 enabled: Optional[bool] = None):
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")


@pulumi.output_type
class DomainServiceSoftwareOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "automatedUpdateDate":
            suggest = "automated_update_date"
        elif key == "currentVersion":
            suggest = "current_version"
        elif key == "newVersion":
            suggest = "new_version"
        elif key == "optionalDeployment":
            suggest = "optional_deployment"
        elif key == "updateAvailable":
            suggest = "update_available"
        elif key == "updateStatus":
            suggest = "update_status"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainServiceSoftwareOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainServiceSoftwareOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainServiceSoftwareOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 automated_update_date: Optional[str] = None,
                 cancellable: Optional[bool] = None,
                 current_version: Optional[str] = None,
                 description: Optional[str] = None,
                 new_version: Optional[str] = None,
                 optional_deployment: Optional[bool] = None,
                 update_available: Optional[bool] = None,
                 update_status: Optional[str] = None):
        if automated_update_date is not None:
            pulumi.set(__self__, "automated_update_date", automated_update_date)
        if cancellable is not None:
            pulumi.set(__self__, "cancellable", cancellable)
        if current_version is not None:
            pulumi.set(__self__, "current_version", current_version)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if new_version is not None:
            pulumi.set(__self__, "new_version", new_version)
        if optional_deployment is not None:
            pulumi.set(__self__, "optional_deployment", optional_deployment)
        if update_available is not None:
            pulumi.set(__self__, "update_available", update_available)
        if update_status is not None:
            pulumi.set(__self__, "update_status", update_status)

    @property
    @pulumi.getter(name="automatedUpdateDate")
    def automated_update_date(self) -> Optional[str]:
        return pulumi.get(self, "automated_update_date")

    @property
    @pulumi.getter
    def cancellable(self) -> Optional[bool]:
        return pulumi.get(self, "cancellable")

    @property
    @pulumi.getter(name="currentVersion")
    def current_version(self) -> Optional[str]:
        return pulumi.get(self, "current_version")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="newVersion")
    def new_version(self) -> Optional[str]:
        return pulumi.get(self, "new_version")

    @property
    @pulumi.getter(name="optionalDeployment")
    def optional_deployment(self) -> Optional[bool]:
        return pulumi.get(self, "optional_deployment")

    @property
    @pulumi.getter(name="updateAvailable")
    def update_available(self) -> Optional[bool]:
        return pulumi.get(self, "update_available")

    @property
    @pulumi.getter(name="updateStatus")
    def update_status(self) -> Optional[str]:
        return pulumi.get(self, "update_status")


@pulumi.output_type
class DomainSnapshotOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "automatedSnapshotStartHour":
            suggest = "automated_snapshot_start_hour"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainSnapshotOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainSnapshotOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainSnapshotOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 automated_snapshot_start_hour: Optional[int] = None):
        if automated_snapshot_start_hour is not None:
            pulumi.set(__self__, "automated_snapshot_start_hour", automated_snapshot_start_hour)

    @property
    @pulumi.getter(name="automatedSnapshotStartHour")
    def automated_snapshot_start_hour(self) -> Optional[int]:
        return pulumi.get(self, "automated_snapshot_start_hour")


@pulumi.output_type
class DomainTag(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")


@pulumi.output_type
class DomainVPCOptions(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "securityGroupIds":
            suggest = "security_group_ids"
        elif key == "subnetIds":
            suggest = "subnet_ids"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainVPCOptions. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainVPCOptions.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainVPCOptions.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 security_group_ids: Optional[Sequence[str]] = None,
                 subnet_ids: Optional[Sequence[str]] = None):
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if subnet_ids is not None:
            pulumi.set(__self__, "subnet_ids", subnet_ids)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter(name="subnetIds")
    def subnet_ids(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "subnet_ids")


@pulumi.output_type
class DomainZoneAwarenessConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "availabilityZoneCount":
            suggest = "availability_zone_count"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DomainZoneAwarenessConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DomainZoneAwarenessConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DomainZoneAwarenessConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 availability_zone_count: Optional[int] = None):
        if availability_zone_count is not None:
            pulumi.set(__self__, "availability_zone_count", availability_zone_count)

    @property
    @pulumi.getter(name="availabilityZoneCount")
    def availability_zone_count(self) -> Optional[int]:
        return pulumi.get(self, "availability_zone_count")


