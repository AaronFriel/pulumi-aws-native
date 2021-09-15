# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'AccountExpiryEventsConfiguration',
]

@pulumi.output_type
class AccountExpiryEventsConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "daysBeforeExpiry":
            suggest = "days_before_expiry"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AccountExpiryEventsConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AccountExpiryEventsConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AccountExpiryEventsConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 days_before_expiry: Optional[int] = None):
        if days_before_expiry is not None:
            pulumi.set(__self__, "days_before_expiry", days_before_expiry)

    @property
    @pulumi.getter(name="daysBeforeExpiry")
    def days_before_expiry(self) -> Optional[int]:
        return pulumi.get(self, "days_before_expiry")


