# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'PipelineFieldArgs',
    'PipelineParameterAttributeArgs',
    'PipelineParameterObjectArgs',
    'PipelineParameterValueArgs',
    'PipelinePipelineObjectArgs',
    'PipelinePipelineTagArgs',
]

@pulumi.input_type
class PipelineFieldArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 ref_value: Optional[pulumi.Input[str]] = None,
                 string_value: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "key", key)
        if ref_value is not None:
            pulumi.set(__self__, "ref_value", ref_value)
        if string_value is not None:
            pulumi.set(__self__, "string_value", string_value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter(name="refValue")
    def ref_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "ref_value")

    @ref_value.setter
    def ref_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ref_value", value)

    @property
    @pulumi.getter(name="stringValue")
    def string_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "string_value")

    @string_value.setter
    def string_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "string_value", value)


@pulumi.input_type
class PipelineParameterAttributeArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 string_value: pulumi.Input[str]):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "string_value", string_value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter(name="stringValue")
    def string_value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "string_value")

    @string_value.setter
    def string_value(self, value: pulumi.Input[str]):
        pulumi.set(self, "string_value", value)


@pulumi.input_type
class PipelineParameterObjectArgs:
    def __init__(__self__, *,
                 attributes: pulumi.Input[Sequence[pulumi.Input['PipelineParameterAttributeArgs']]],
                 id: pulumi.Input[str]):
        pulumi.set(__self__, "attributes", attributes)
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def attributes(self) -> pulumi.Input[Sequence[pulumi.Input['PipelineParameterAttributeArgs']]]:
        return pulumi.get(self, "attributes")

    @attributes.setter
    def attributes(self, value: pulumi.Input[Sequence[pulumi.Input['PipelineParameterAttributeArgs']]]):
        pulumi.set(self, "attributes", value)

    @property
    @pulumi.getter
    def id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: pulumi.Input[str]):
        pulumi.set(self, "id", value)


@pulumi.input_type
class PipelineParameterValueArgs:
    def __init__(__self__, *,
                 id: pulumi.Input[str],
                 string_value: pulumi.Input[str]):
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "string_value", string_value)

    @property
    @pulumi.getter
    def id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: pulumi.Input[str]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="stringValue")
    def string_value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "string_value")

    @string_value.setter
    def string_value(self, value: pulumi.Input[str]):
        pulumi.set(self, "string_value", value)


@pulumi.input_type
class PipelinePipelineObjectArgs:
    def __init__(__self__, *,
                 fields: pulumi.Input[Sequence[pulumi.Input['PipelineFieldArgs']]],
                 id: pulumi.Input[str],
                 name: pulumi.Input[str]):
        pulumi.set(__self__, "fields", fields)
        pulumi.set(__self__, "id", id)
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def fields(self) -> pulumi.Input[Sequence[pulumi.Input['PipelineFieldArgs']]]:
        return pulumi.get(self, "fields")

    @fields.setter
    def fields(self, value: pulumi.Input[Sequence[pulumi.Input['PipelineFieldArgs']]]):
        pulumi.set(self, "fields", value)

    @property
    @pulumi.getter
    def id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: pulumi.Input[str]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class PipelinePipelineTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


