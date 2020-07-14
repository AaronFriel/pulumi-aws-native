# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables


class GetSsmParameterListResult:
    def __init__(__self__, value=None):
        if value and not isinstance(value, list):
            raise TypeError("Expected argument 'value' to be a list")
        __self__.value = value


class AwaitableGetSsmParameterListResult(GetSsmParameterListResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSsmParameterListResult(
            value=self.value)


def get_ssm_parameter_list(name=None, opts=None):
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('cloudformation:index:getSsmParameterList', __args__, opts=opts).value

    return AwaitableGetSsmParameterListResult(
        value=__ret__.get('value'))
