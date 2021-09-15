# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'LaunchProfileStreamConfiguration',
    'StreamingImageStreamingImageEncryptionConfiguration',
    'StudioComponentActiveDirectoryComputerAttribute',
    'StudioComponentActiveDirectoryConfiguration',
    'StudioComponentComputeFarmConfiguration',
    'StudioComponentLicenseServiceConfiguration',
    'StudioComponentScriptParameterKeyValue',
    'StudioComponentSharedFileSystemConfiguration',
    'StudioComponentStudioComponentConfiguration',
    'StudioComponentStudioComponentInitializationScript',
    'StudioStudioEncryptionConfiguration',
]

@pulumi.output_type
class LaunchProfileStreamConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "clipboardMode":
            suggest = "clipboard_mode"
        elif key == "ec2InstanceTypes":
            suggest = "ec2_instance_types"
        elif key == "streamingImageIds":
            suggest = "streaming_image_ids"
        elif key == "maxSessionLengthInMinutes":
            suggest = "max_session_length_in_minutes"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in LaunchProfileStreamConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        LaunchProfileStreamConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        LaunchProfileStreamConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 clipboard_mode: str,
                 ec2_instance_types: Sequence[str],
                 streaming_image_ids: Sequence[str],
                 max_session_length_in_minutes: Optional[float] = None):
        pulumi.set(__self__, "clipboard_mode", clipboard_mode)
        pulumi.set(__self__, "ec2_instance_types", ec2_instance_types)
        pulumi.set(__self__, "streaming_image_ids", streaming_image_ids)
        if max_session_length_in_minutes is not None:
            pulumi.set(__self__, "max_session_length_in_minutes", max_session_length_in_minutes)

    @property
    @pulumi.getter(name="clipboardMode")
    def clipboard_mode(self) -> str:
        return pulumi.get(self, "clipboard_mode")

    @property
    @pulumi.getter(name="ec2InstanceTypes")
    def ec2_instance_types(self) -> Sequence[str]:
        return pulumi.get(self, "ec2_instance_types")

    @property
    @pulumi.getter(name="streamingImageIds")
    def streaming_image_ids(self) -> Sequence[str]:
        return pulumi.get(self, "streaming_image_ids")

    @property
    @pulumi.getter(name="maxSessionLengthInMinutes")
    def max_session_length_in_minutes(self) -> Optional[float]:
        return pulumi.get(self, "max_session_length_in_minutes")


@pulumi.output_type
class StreamingImageStreamingImageEncryptionConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "keyType":
            suggest = "key_type"
        elif key == "keyArn":
            suggest = "key_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StreamingImageStreamingImageEncryptionConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StreamingImageStreamingImageEncryptionConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StreamingImageStreamingImageEncryptionConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 key_type: str,
                 key_arn: Optional[str] = None):
        pulumi.set(__self__, "key_type", key_type)
        if key_arn is not None:
            pulumi.set(__self__, "key_arn", key_arn)

    @property
    @pulumi.getter(name="keyType")
    def key_type(self) -> str:
        return pulumi.get(self, "key_type")

    @property
    @pulumi.getter(name="keyArn")
    def key_arn(self) -> Optional[str]:
        return pulumi.get(self, "key_arn")


@pulumi.output_type
class StudioComponentActiveDirectoryComputerAttribute(dict):
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 value: Optional[str] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class StudioComponentActiveDirectoryConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "computerAttributes":
            suggest = "computer_attributes"
        elif key == "directoryId":
            suggest = "directory_id"
        elif key == "organizationalUnitDistinguishedName":
            suggest = "organizational_unit_distinguished_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StudioComponentActiveDirectoryConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StudioComponentActiveDirectoryConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StudioComponentActiveDirectoryConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 computer_attributes: Optional[Sequence['outputs.StudioComponentActiveDirectoryComputerAttribute']] = None,
                 directory_id: Optional[str] = None,
                 organizational_unit_distinguished_name: Optional[str] = None):
        if computer_attributes is not None:
            pulumi.set(__self__, "computer_attributes", computer_attributes)
        if directory_id is not None:
            pulumi.set(__self__, "directory_id", directory_id)
        if organizational_unit_distinguished_name is not None:
            pulumi.set(__self__, "organizational_unit_distinguished_name", organizational_unit_distinguished_name)

    @property
    @pulumi.getter(name="computerAttributes")
    def computer_attributes(self) -> Optional[Sequence['outputs.StudioComponentActiveDirectoryComputerAttribute']]:
        return pulumi.get(self, "computer_attributes")

    @property
    @pulumi.getter(name="directoryId")
    def directory_id(self) -> Optional[str]:
        return pulumi.get(self, "directory_id")

    @property
    @pulumi.getter(name="organizationalUnitDistinguishedName")
    def organizational_unit_distinguished_name(self) -> Optional[str]:
        return pulumi.get(self, "organizational_unit_distinguished_name")


@pulumi.output_type
class StudioComponentComputeFarmConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "activeDirectoryUser":
            suggest = "active_directory_user"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StudioComponentComputeFarmConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StudioComponentComputeFarmConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StudioComponentComputeFarmConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 active_directory_user: Optional[str] = None,
                 endpoint: Optional[str] = None):
        if active_directory_user is not None:
            pulumi.set(__self__, "active_directory_user", active_directory_user)
        if endpoint is not None:
            pulumi.set(__self__, "endpoint", endpoint)

    @property
    @pulumi.getter(name="activeDirectoryUser")
    def active_directory_user(self) -> Optional[str]:
        return pulumi.get(self, "active_directory_user")

    @property
    @pulumi.getter
    def endpoint(self) -> Optional[str]:
        return pulumi.get(self, "endpoint")


@pulumi.output_type
class StudioComponentLicenseServiceConfiguration(dict):
    def __init__(__self__, *,
                 endpoint: Optional[str] = None):
        if endpoint is not None:
            pulumi.set(__self__, "endpoint", endpoint)

    @property
    @pulumi.getter
    def endpoint(self) -> Optional[str]:
        return pulumi.get(self, "endpoint")


@pulumi.output_type
class StudioComponentScriptParameterKeyValue(dict):
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 value: Optional[str] = None):
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class StudioComponentSharedFileSystemConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "fileSystemId":
            suggest = "file_system_id"
        elif key == "linuxMountPoint":
            suggest = "linux_mount_point"
        elif key == "shareName":
            suggest = "share_name"
        elif key == "windowsMountDrive":
            suggest = "windows_mount_drive"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StudioComponentSharedFileSystemConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StudioComponentSharedFileSystemConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StudioComponentSharedFileSystemConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 endpoint: Optional[str] = None,
                 file_system_id: Optional[str] = None,
                 linux_mount_point: Optional[str] = None,
                 share_name: Optional[str] = None,
                 windows_mount_drive: Optional[str] = None):
        if endpoint is not None:
            pulumi.set(__self__, "endpoint", endpoint)
        if file_system_id is not None:
            pulumi.set(__self__, "file_system_id", file_system_id)
        if linux_mount_point is not None:
            pulumi.set(__self__, "linux_mount_point", linux_mount_point)
        if share_name is not None:
            pulumi.set(__self__, "share_name", share_name)
        if windows_mount_drive is not None:
            pulumi.set(__self__, "windows_mount_drive", windows_mount_drive)

    @property
    @pulumi.getter
    def endpoint(self) -> Optional[str]:
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter(name="fileSystemId")
    def file_system_id(self) -> Optional[str]:
        return pulumi.get(self, "file_system_id")

    @property
    @pulumi.getter(name="linuxMountPoint")
    def linux_mount_point(self) -> Optional[str]:
        return pulumi.get(self, "linux_mount_point")

    @property
    @pulumi.getter(name="shareName")
    def share_name(self) -> Optional[str]:
        return pulumi.get(self, "share_name")

    @property
    @pulumi.getter(name="windowsMountDrive")
    def windows_mount_drive(self) -> Optional[str]:
        return pulumi.get(self, "windows_mount_drive")


@pulumi.output_type
class StudioComponentStudioComponentConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "activeDirectoryConfiguration":
            suggest = "active_directory_configuration"
        elif key == "computeFarmConfiguration":
            suggest = "compute_farm_configuration"
        elif key == "licenseServiceConfiguration":
            suggest = "license_service_configuration"
        elif key == "sharedFileSystemConfiguration":
            suggest = "shared_file_system_configuration"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StudioComponentStudioComponentConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StudioComponentStudioComponentConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StudioComponentStudioComponentConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 active_directory_configuration: Optional['outputs.StudioComponentActiveDirectoryConfiguration'] = None,
                 compute_farm_configuration: Optional['outputs.StudioComponentComputeFarmConfiguration'] = None,
                 license_service_configuration: Optional['outputs.StudioComponentLicenseServiceConfiguration'] = None,
                 shared_file_system_configuration: Optional['outputs.StudioComponentSharedFileSystemConfiguration'] = None):
        if active_directory_configuration is not None:
            pulumi.set(__self__, "active_directory_configuration", active_directory_configuration)
        if compute_farm_configuration is not None:
            pulumi.set(__self__, "compute_farm_configuration", compute_farm_configuration)
        if license_service_configuration is not None:
            pulumi.set(__self__, "license_service_configuration", license_service_configuration)
        if shared_file_system_configuration is not None:
            pulumi.set(__self__, "shared_file_system_configuration", shared_file_system_configuration)

    @property
    @pulumi.getter(name="activeDirectoryConfiguration")
    def active_directory_configuration(self) -> Optional['outputs.StudioComponentActiveDirectoryConfiguration']:
        return pulumi.get(self, "active_directory_configuration")

    @property
    @pulumi.getter(name="computeFarmConfiguration")
    def compute_farm_configuration(self) -> Optional['outputs.StudioComponentComputeFarmConfiguration']:
        return pulumi.get(self, "compute_farm_configuration")

    @property
    @pulumi.getter(name="licenseServiceConfiguration")
    def license_service_configuration(self) -> Optional['outputs.StudioComponentLicenseServiceConfiguration']:
        return pulumi.get(self, "license_service_configuration")

    @property
    @pulumi.getter(name="sharedFileSystemConfiguration")
    def shared_file_system_configuration(self) -> Optional['outputs.StudioComponentSharedFileSystemConfiguration']:
        return pulumi.get(self, "shared_file_system_configuration")


@pulumi.output_type
class StudioComponentStudioComponentInitializationScript(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "launchProfileProtocolVersion":
            suggest = "launch_profile_protocol_version"
        elif key == "runContext":
            suggest = "run_context"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StudioComponentStudioComponentInitializationScript. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StudioComponentStudioComponentInitializationScript.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StudioComponentStudioComponentInitializationScript.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 launch_profile_protocol_version: Optional[str] = None,
                 platform: Optional[str] = None,
                 run_context: Optional[str] = None,
                 script: Optional[str] = None):
        if launch_profile_protocol_version is not None:
            pulumi.set(__self__, "launch_profile_protocol_version", launch_profile_protocol_version)
        if platform is not None:
            pulumi.set(__self__, "platform", platform)
        if run_context is not None:
            pulumi.set(__self__, "run_context", run_context)
        if script is not None:
            pulumi.set(__self__, "script", script)

    @property
    @pulumi.getter(name="launchProfileProtocolVersion")
    def launch_profile_protocol_version(self) -> Optional[str]:
        return pulumi.get(self, "launch_profile_protocol_version")

    @property
    @pulumi.getter
    def platform(self) -> Optional[str]:
        return pulumi.get(self, "platform")

    @property
    @pulumi.getter(name="runContext")
    def run_context(self) -> Optional[str]:
        return pulumi.get(self, "run_context")

    @property
    @pulumi.getter
    def script(self) -> Optional[str]:
        return pulumi.get(self, "script")


@pulumi.output_type
class StudioStudioEncryptionConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "keyType":
            suggest = "key_type"
        elif key == "keyArn":
            suggest = "key_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StudioStudioEncryptionConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StudioStudioEncryptionConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StudioStudioEncryptionConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 key_type: str,
                 key_arn: Optional[str] = None):
        pulumi.set(__self__, "key_type", key_type)
        if key_arn is not None:
            pulumi.set(__self__, "key_arn", key_arn)

    @property
    @pulumi.getter(name="keyType")
    def key_type(self) -> str:
        return pulumi.get(self, "key_type")

    @property
    @pulumi.getter(name="keyArn")
    def key_arn(self) -> Optional[str]:
        return pulumi.get(self, "key_arn")


