# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'ClusterSSESpecificationArgs',
]

@pulumi.input_type
class ClusterSSESpecificationArgs:
    def __init__(__self__, *,
                 s_se_enabled: Optional[pulumi.Input[bool]] = None):
        if s_se_enabled is not None:
            pulumi.set(__self__, "s_se_enabled", s_se_enabled)

    @property
    @pulumi.getter(name="sSEEnabled")
    def s_se_enabled(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "s_se_enabled")

    @s_se_enabled.setter
    def s_se_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "s_se_enabled", value)


