# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'UsagePlanKeyKeyType',
]


class UsagePlanKeyKeyType(str, Enum):
    """
    The type of usage plan key. Currently, the only valid key type is API_KEY.
    """
    API_KEY = "API_KEY"