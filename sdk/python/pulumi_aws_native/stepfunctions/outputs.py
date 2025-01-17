# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._enums import *

__all__ = [
    'ActivityTagsEntry',
    'StateMachineCloudWatchLogsLogGroup',
    'StateMachineDefinition',
    'StateMachineDefinitionSubstitutions',
    'StateMachineLogDestination',
    'StateMachineLoggingConfiguration',
    'StateMachineS3Location',
    'StateMachineTagsEntry',
    'StateMachineTracingConfiguration',
]

@pulumi.output_type
class ActivityTagsEntry(dict):
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
class StateMachineCloudWatchLogsLogGroup(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "logGroupArn":
            suggest = "log_group_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StateMachineCloudWatchLogsLogGroup. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StateMachineCloudWatchLogsLogGroup.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StateMachineCloudWatchLogsLogGroup.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 log_group_arn: Optional[str] = None):
        if log_group_arn is not None:
            pulumi.set(__self__, "log_group_arn", log_group_arn)

    @property
    @pulumi.getter(name="logGroupArn")
    def log_group_arn(self) -> Optional[str]:
        return pulumi.get(self, "log_group_arn")


@pulumi.output_type
class StateMachineDefinition(dict):
    def __init__(__self__):
        pass


@pulumi.output_type
class StateMachineDefinitionSubstitutions(dict):
    def __init__(__self__):
        pass


@pulumi.output_type
class StateMachineLogDestination(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "cloudWatchLogsLogGroup":
            suggest = "cloud_watch_logs_log_group"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StateMachineLogDestination. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StateMachineLogDestination.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StateMachineLogDestination.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 cloud_watch_logs_log_group: Optional['outputs.StateMachineCloudWatchLogsLogGroup'] = None):
        if cloud_watch_logs_log_group is not None:
            pulumi.set(__self__, "cloud_watch_logs_log_group", cloud_watch_logs_log_group)

    @property
    @pulumi.getter(name="cloudWatchLogsLogGroup")
    def cloud_watch_logs_log_group(self) -> Optional['outputs.StateMachineCloudWatchLogsLogGroup']:
        return pulumi.get(self, "cloud_watch_logs_log_group")


@pulumi.output_type
class StateMachineLoggingConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "includeExecutionData":
            suggest = "include_execution_data"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in StateMachineLoggingConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        StateMachineLoggingConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        StateMachineLoggingConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 destinations: Optional[Sequence['outputs.StateMachineLogDestination']] = None,
                 include_execution_data: Optional[bool] = None,
                 level: Optional['StateMachineLoggingConfigurationLevel'] = None):
        if destinations is not None:
            pulumi.set(__self__, "destinations", destinations)
        if include_execution_data is not None:
            pulumi.set(__self__, "include_execution_data", include_execution_data)
        if level is not None:
            pulumi.set(__self__, "level", level)

    @property
    @pulumi.getter
    def destinations(self) -> Optional[Sequence['outputs.StateMachineLogDestination']]:
        return pulumi.get(self, "destinations")

    @property
    @pulumi.getter(name="includeExecutionData")
    def include_execution_data(self) -> Optional[bool]:
        return pulumi.get(self, "include_execution_data")

    @property
    @pulumi.getter
    def level(self) -> Optional['StateMachineLoggingConfigurationLevel']:
        return pulumi.get(self, "level")


@pulumi.output_type
class StateMachineS3Location(dict):
    def __init__(__self__, *,
                 bucket: str,
                 key: str,
                 version: Optional[str] = None):
        pulumi.set(__self__, "bucket", bucket)
        pulumi.set(__self__, "key", key)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def bucket(self) -> str:
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        return pulumi.get(self, "version")


@pulumi.output_type
class StateMachineTagsEntry(dict):
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
class StateMachineTracingConfiguration(dict):
    def __init__(__self__, *,
                 enabled: Optional[bool] = None):
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")


