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
    'AnalyzerArchiveRule',
    'AnalyzerFilter',
    'AnalyzerTag',
]

@pulumi.output_type
class AnalyzerArchiveRule(dict):
    """
    An Access Analyzer archive rule. Archive rules automatically archive new findings that meet the criteria you define when you create the rule.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "ruleName":
            suggest = "rule_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in AnalyzerArchiveRule. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        AnalyzerArchiveRule.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        AnalyzerArchiveRule.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 filter: Sequence['outputs.AnalyzerFilter'],
                 rule_name: str):
        """
        An Access Analyzer archive rule. Archive rules automatically archive new findings that meet the criteria you define when you create the rule.
        :param str rule_name: The archive rule name
        """
        pulumi.set(__self__, "filter", filter)
        pulumi.set(__self__, "rule_name", rule_name)

    @property
    @pulumi.getter
    def filter(self) -> Sequence['outputs.AnalyzerFilter']:
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter(name="ruleName")
    def rule_name(self) -> str:
        """
        The archive rule name
        """
        return pulumi.get(self, "rule_name")


@pulumi.output_type
class AnalyzerFilter(dict):
    def __init__(__self__, *,
                 property: str,
                 contains: Optional[Sequence[str]] = None,
                 eq: Optional[Sequence[str]] = None,
                 exists: Optional[bool] = None,
                 neq: Optional[Sequence[str]] = None):
        pulumi.set(__self__, "property", property)
        if contains is not None:
            pulumi.set(__self__, "contains", contains)
        if eq is not None:
            pulumi.set(__self__, "eq", eq)
        if exists is not None:
            pulumi.set(__self__, "exists", exists)
        if neq is not None:
            pulumi.set(__self__, "neq", neq)

    @property
    @pulumi.getter
    def contains(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "contains")

    @property
    @pulumi.getter
    def eq(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "eq")

    @property
    @pulumi.getter
    def exists(self) -> Optional[bool]:
        return pulumi.get(self, "exists")

    @property
    @pulumi.getter
    def neq(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "neq")

    @property
    @pulumi.getter
    def property(self) -> str:
        return pulumi.get(self, "property")


@pulumi.output_type
class AnalyzerTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        :param str value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "value")


