# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'EventIntegrationEventFilterArgs',
    'EventIntegrationTagArgs',
]

@pulumi.input_type
class EventIntegrationEventFilterArgs:
    def __init__(__self__, *,
                 source: pulumi.Input[str]):
        """
        :param pulumi.Input[str] source: The source of the events.
        """
        pulumi.set(__self__, "source", source)

    @property
    @pulumi.getter
    def source(self) -> pulumi.Input[str]:
        """
        The source of the events.
        """
        return pulumi.get(self, "source")

    @source.setter
    def source(self, value: pulumi.Input[str]):
        pulumi.set(self, "source", value)


@pulumi.input_type
class EventIntegrationTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        :param pulumi.Input[str] key: A key to identify the tag.
        :param pulumi.Input[str] value: Corresponding tag value for the key.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        A key to identify the tag.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        Corresponding tag value for the key.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


