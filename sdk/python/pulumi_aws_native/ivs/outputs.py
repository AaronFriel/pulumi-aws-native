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
    'ChannelTag',
    'PlaybackKeyPairTag',
    'RecordingConfigurationDestinationConfiguration',
    'RecordingConfigurationS3DestinationConfiguration',
    'RecordingConfigurationTag',
    'StreamKeyTag',
]

@pulumi.output_type
class ChannelTag(dict):
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
class PlaybackKeyPairTag(dict):
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
class RecordingConfigurationDestinationConfiguration(dict):
    """
    Recording Destination Configuration.
    """
    def __init__(__self__, *,
                 s3: 'outputs.RecordingConfigurationS3DestinationConfiguration'):
        """
        Recording Destination Configuration.
        """
        pulumi.set(__self__, "s3", s3)

    @property
    @pulumi.getter
    def s3(self) -> 'outputs.RecordingConfigurationS3DestinationConfiguration':
        return pulumi.get(self, "s3")


@pulumi.output_type
class RecordingConfigurationS3DestinationConfiguration(dict):
    """
    Recording S3 Destination Configuration.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "bucketName":
            suggest = "bucket_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RecordingConfigurationS3DestinationConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RecordingConfigurationS3DestinationConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RecordingConfigurationS3DestinationConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 bucket_name: str):
        """
        Recording S3 Destination Configuration.
        """
        pulumi.set(__self__, "bucket_name", bucket_name)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> str:
        return pulumi.get(self, "bucket_name")


@pulumi.output_type
class RecordingConfigurationTag(dict):
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
class StreamKeyTag(dict):
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


