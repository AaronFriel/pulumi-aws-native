# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ReportGroupArgs', 'ReportGroup']

@pulumi.input_type
class ReportGroupArgs:
    def __init__(__self__, *,
                 export_config: pulumi.Input['ReportGroupReportExportConfigArgs'],
                 type: pulumi.Input[str],
                 delete_reports: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['ReportGroupTagArgs']]]] = None):
        """
        The set of arguments for constructing a ReportGroup resource.
        """
        pulumi.set(__self__, "export_config", export_config)
        pulumi.set(__self__, "type", type)
        if delete_reports is not None:
            pulumi.set(__self__, "delete_reports", delete_reports)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="exportConfig")
    def export_config(self) -> pulumi.Input['ReportGroupReportExportConfigArgs']:
        return pulumi.get(self, "export_config")

    @export_config.setter
    def export_config(self, value: pulumi.Input['ReportGroupReportExportConfigArgs']):
        pulumi.set(self, "export_config", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="deleteReports")
    def delete_reports(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "delete_reports")

    @delete_reports.setter
    def delete_reports(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "delete_reports", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ReportGroupTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ReportGroupTagArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""ReportGroup is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class ReportGroup(pulumi.CustomResource):
    warnings.warn("""ReportGroup is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 delete_reports: Optional[pulumi.Input[bool]] = None,
                 export_config: Optional[pulumi.Input[pulumi.InputType['ReportGroupReportExportConfigArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ReportGroupTagArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::CodeBuild::ReportGroup

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ReportGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::CodeBuild::ReportGroup

        :param str resource_name: The name of the resource.
        :param ReportGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ReportGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 delete_reports: Optional[pulumi.Input[bool]] = None,
                 export_config: Optional[pulumi.Input[pulumi.InputType['ReportGroupReportExportConfigArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ReportGroupTagArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""ReportGroup is deprecated: ReportGroup is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ReportGroupArgs.__new__(ReportGroupArgs)

            __props__.__dict__["delete_reports"] = delete_reports
            if export_config is None and not opts.urn:
                raise TypeError("Missing required property 'export_config'")
            __props__.__dict__["export_config"] = export_config
            __props__.__dict__["name"] = name
            __props__.__dict__["tags"] = tags
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["arn"] = None
        super(ReportGroup, __self__).__init__(
            'aws-native:codebuild:ReportGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ReportGroup':
        """
        Get an existing ReportGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ReportGroupArgs.__new__(ReportGroupArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["delete_reports"] = None
        __props__.__dict__["export_config"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        return ReportGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="deleteReports")
    def delete_reports(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "delete_reports")

    @property
    @pulumi.getter(name="exportConfig")
    def export_config(self) -> pulumi.Output['outputs.ReportGroupReportExportConfig']:
        return pulumi.get(self, "export_config")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.ReportGroupTag']]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "type")

