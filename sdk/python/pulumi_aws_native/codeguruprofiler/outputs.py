# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'ProfilingGroupChannel',
    'ProfilingGroupTag',
]

@pulumi.output_type
class ProfilingGroupChannel(dict):
    """
    Notification medium for users to get alerted for events that occur in application profile. We support SNS topic as a notification channel.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "channelUri":
            suggest = "channel_uri"
        elif key == "channelId":
            suggest = "channel_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ProfilingGroupChannel. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ProfilingGroupChannel.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ProfilingGroupChannel.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 channel_uri: str,
                 channel_id: Optional[str] = None):
        """
        Notification medium for users to get alerted for events that occur in application profile. We support SNS topic as a notification channel.
        """
        pulumi.set(__self__, "channel_uri", channel_uri)
        if channel_id is not None:
            pulumi.set(__self__, "channel_id", channel_id)

    @property
    @pulumi.getter(name="channelUri")
    def channel_uri(self) -> str:
        return pulumi.get(self, "channel_uri")

    @property
    @pulumi.getter(name="channelId")
    def channel_id(self) -> Optional[str]:
        return pulumi.get(self, "channel_id")


@pulumi.output_type
class ProfilingGroupTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
        :param str value: The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
        """
        return pulumi.get(self, "value")


