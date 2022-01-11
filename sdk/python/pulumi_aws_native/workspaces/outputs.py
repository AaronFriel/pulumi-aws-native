# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from ._enums import *

__all__ = [
    'ConnectionAliasAssociation',
    'ConnectionAliasTag',
    'WorkspaceProperties',
    'WorkspaceTag',
]

@pulumi.output_type
class ConnectionAliasAssociation(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "associatedAccountId":
            suggest = "associated_account_id"
        elif key == "associationStatus":
            suggest = "association_status"
        elif key == "connectionIdentifier":
            suggest = "connection_identifier"
        elif key == "resourceId":
            suggest = "resource_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ConnectionAliasAssociation. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ConnectionAliasAssociation.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ConnectionAliasAssociation.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 associated_account_id: Optional[str] = None,
                 association_status: Optional['ConnectionAliasAssociationAssociationStatus'] = None,
                 connection_identifier: Optional[str] = None,
                 resource_id: Optional[str] = None):
        if associated_account_id is not None:
            pulumi.set(__self__, "associated_account_id", associated_account_id)
        if association_status is not None:
            pulumi.set(__self__, "association_status", association_status)
        if connection_identifier is not None:
            pulumi.set(__self__, "connection_identifier", connection_identifier)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)

    @property
    @pulumi.getter(name="associatedAccountId")
    def associated_account_id(self) -> Optional[str]:
        return pulumi.get(self, "associated_account_id")

    @property
    @pulumi.getter(name="associationStatus")
    def association_status(self) -> Optional['ConnectionAliasAssociationAssociationStatus']:
        return pulumi.get(self, "association_status")

    @property
    @pulumi.getter(name="connectionIdentifier")
    def connection_identifier(self) -> Optional[str]:
        return pulumi.get(self, "connection_identifier")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        return pulumi.get(self, "resource_id")


@pulumi.output_type
class ConnectionAliasTag(dict):
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
class WorkspaceProperties(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "computeTypeName":
            suggest = "compute_type_name"
        elif key == "rootVolumeSizeGib":
            suggest = "root_volume_size_gib"
        elif key == "runningMode":
            suggest = "running_mode"
        elif key == "runningModeAutoStopTimeoutInMinutes":
            suggest = "running_mode_auto_stop_timeout_in_minutes"
        elif key == "userVolumeSizeGib":
            suggest = "user_volume_size_gib"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in WorkspaceProperties. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        WorkspaceProperties.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        WorkspaceProperties.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 compute_type_name: Optional[str] = None,
                 root_volume_size_gib: Optional[int] = None,
                 running_mode: Optional[str] = None,
                 running_mode_auto_stop_timeout_in_minutes: Optional[int] = None,
                 user_volume_size_gib: Optional[int] = None):
        if compute_type_name is not None:
            pulumi.set(__self__, "compute_type_name", compute_type_name)
        if root_volume_size_gib is not None:
            pulumi.set(__self__, "root_volume_size_gib", root_volume_size_gib)
        if running_mode is not None:
            pulumi.set(__self__, "running_mode", running_mode)
        if running_mode_auto_stop_timeout_in_minutes is not None:
            pulumi.set(__self__, "running_mode_auto_stop_timeout_in_minutes", running_mode_auto_stop_timeout_in_minutes)
        if user_volume_size_gib is not None:
            pulumi.set(__self__, "user_volume_size_gib", user_volume_size_gib)

    @property
    @pulumi.getter(name="computeTypeName")
    def compute_type_name(self) -> Optional[str]:
        return pulumi.get(self, "compute_type_name")

    @property
    @pulumi.getter(name="rootVolumeSizeGib")
    def root_volume_size_gib(self) -> Optional[int]:
        return pulumi.get(self, "root_volume_size_gib")

    @property
    @pulumi.getter(name="runningMode")
    def running_mode(self) -> Optional[str]:
        return pulumi.get(self, "running_mode")

    @property
    @pulumi.getter(name="runningModeAutoStopTimeoutInMinutes")
    def running_mode_auto_stop_timeout_in_minutes(self) -> Optional[int]:
        return pulumi.get(self, "running_mode_auto_stop_timeout_in_minutes")

    @property
    @pulumi.getter(name="userVolumeSizeGib")
    def user_volume_size_gib(self) -> Optional[int]:
        return pulumi.get(self, "user_volume_size_gib")


@pulumi.output_type
class WorkspaceTag(dict):
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


