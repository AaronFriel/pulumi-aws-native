# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['DashboardArgs', 'Dashboard']

@pulumi.input_type
class DashboardArgs:
    def __init__(__self__, *,
                 aws_account_id: pulumi.Input[str],
                 dashboard_id: pulumi.Input[str],
                 dashboard_publish_options: Optional[pulumi.Input['DashboardDashboardPublishOptionsArgs']] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input['DashboardParametersArgs']] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input['DashboardResourcePermissionArgs']]]] = None,
                 source_entity: Optional[pulumi.Input['DashboardDashboardSourceEntityArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DashboardTagArgs']]]] = None,
                 theme_arn: Optional[pulumi.Input[str]] = None,
                 version_description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Dashboard resource.
        :param pulumi.Input[str] name: <p>The display name of the dashboard.</p>
        :param pulumi.Input[Sequence[pulumi.Input['DashboardResourcePermissionArgs']]] permissions: <p>A structure that contains the permissions of the dashboard. You can use this structure
                           for granting permissions by providing a list of IAM action information for each
                           principal ARN. </p>
               
                       <p>To specify no permissions, omit the permissions list.</p>
        :param pulumi.Input[Sequence[pulumi.Input['DashboardTagArgs']]] tags: <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
                           dashboard.</p>
        :param pulumi.Input[str] theme_arn: <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
                           you add a value for this field, it overrides the value that is used in the source
                           entity. The theme ARN must exist in the same AWS account where you create the
                           dashboard.</p>
        :param pulumi.Input[str] version_description: <p>A description for the first version of the dashboard being created.</p>
        """
        pulumi.set(__self__, "aws_account_id", aws_account_id)
        pulumi.set(__self__, "dashboard_id", dashboard_id)
        if dashboard_publish_options is not None:
            pulumi.set(__self__, "dashboard_publish_options", dashboard_publish_options)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)
        if source_entity is not None:
            pulumi.set(__self__, "source_entity", source_entity)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if theme_arn is not None:
            pulumi.set(__self__, "theme_arn", theme_arn)
        if version_description is not None:
            pulumi.set(__self__, "version_description", version_description)

    @property
    @pulumi.getter(name="awsAccountId")
    def aws_account_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "aws_account_id")

    @aws_account_id.setter
    def aws_account_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "aws_account_id", value)

    @property
    @pulumi.getter(name="dashboardId")
    def dashboard_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "dashboard_id")

    @dashboard_id.setter
    def dashboard_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "dashboard_id", value)

    @property
    @pulumi.getter(name="dashboardPublishOptions")
    def dashboard_publish_options(self) -> Optional[pulumi.Input['DashboardDashboardPublishOptionsArgs']]:
        return pulumi.get(self, "dashboard_publish_options")

    @dashboard_publish_options.setter
    def dashboard_publish_options(self, value: Optional[pulumi.Input['DashboardDashboardPublishOptionsArgs']]):
        pulumi.set(self, "dashboard_publish_options", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        <p>The display name of the dashboard.</p>
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def parameters(self) -> Optional[pulumi.Input['DashboardParametersArgs']]:
        return pulumi.get(self, "parameters")

    @parameters.setter
    def parameters(self, value: Optional[pulumi.Input['DashboardParametersArgs']]):
        pulumi.set(self, "parameters", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DashboardResourcePermissionArgs']]]]:
        """
        <p>A structure that contains the permissions of the dashboard. You can use this structure
                    for granting permissions by providing a list of IAM action information for each
                    principal ARN. </p>

                <p>To specify no permissions, omit the permissions list.</p>
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DashboardResourcePermissionArgs']]]]):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter(name="sourceEntity")
    def source_entity(self) -> Optional[pulumi.Input['DashboardDashboardSourceEntityArgs']]:
        return pulumi.get(self, "source_entity")

    @source_entity.setter
    def source_entity(self, value: Optional[pulumi.Input['DashboardDashboardSourceEntityArgs']]):
        pulumi.set(self, "source_entity", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DashboardTagArgs']]]]:
        """
        <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
                    dashboard.</p>
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DashboardTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="themeArn")
    def theme_arn(self) -> Optional[pulumi.Input[str]]:
        """
        <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
                    you add a value for this field, it overrides the value that is used in the source
                    entity. The theme ARN must exist in the same AWS account where you create the
                    dashboard.</p>
        """
        return pulumi.get(self, "theme_arn")

    @theme_arn.setter
    def theme_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "theme_arn", value)

    @property
    @pulumi.getter(name="versionDescription")
    def version_description(self) -> Optional[pulumi.Input[str]]:
        """
        <p>A description for the first version of the dashboard being created.</p>
        """
        return pulumi.get(self, "version_description")

    @version_description.setter
    def version_description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version_description", value)


class Dashboard(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aws_account_id: Optional[pulumi.Input[str]] = None,
                 dashboard_id: Optional[pulumi.Input[str]] = None,
                 dashboard_publish_options: Optional[pulumi.Input[pulumi.InputType['DashboardDashboardPublishOptionsArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[pulumi.InputType['DashboardParametersArgs']]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DashboardResourcePermissionArgs']]]]] = None,
                 source_entity: Optional[pulumi.Input[pulumi.InputType['DashboardDashboardSourceEntityArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DashboardTagArgs']]]]] = None,
                 theme_arn: Optional[pulumi.Input[str]] = None,
                 version_description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Definition of the AWS::QuickSight::Dashboard Resource Type.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: <p>The display name of the dashboard.</p>
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DashboardResourcePermissionArgs']]]] permissions: <p>A structure that contains the permissions of the dashboard. You can use this structure
                           for granting permissions by providing a list of IAM action information for each
                           principal ARN. </p>
               
                       <p>To specify no permissions, omit the permissions list.</p>
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DashboardTagArgs']]]] tags: <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
                           dashboard.</p>
        :param pulumi.Input[str] theme_arn: <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
                           you add a value for this field, it overrides the value that is used in the source
                           entity. The theme ARN must exist in the same AWS account where you create the
                           dashboard.</p>
        :param pulumi.Input[str] version_description: <p>A description for the first version of the dashboard being created.</p>
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DashboardArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Definition of the AWS::QuickSight::Dashboard Resource Type.

        :param str resource_name: The name of the resource.
        :param DashboardArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DashboardArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aws_account_id: Optional[pulumi.Input[str]] = None,
                 dashboard_id: Optional[pulumi.Input[str]] = None,
                 dashboard_publish_options: Optional[pulumi.Input[pulumi.InputType['DashboardDashboardPublishOptionsArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[pulumi.InputType['DashboardParametersArgs']]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DashboardResourcePermissionArgs']]]]] = None,
                 source_entity: Optional[pulumi.Input[pulumi.InputType['DashboardDashboardSourceEntityArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DashboardTagArgs']]]]] = None,
                 theme_arn: Optional[pulumi.Input[str]] = None,
                 version_description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DashboardArgs.__new__(DashboardArgs)

            if aws_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'aws_account_id'")
            __props__.__dict__["aws_account_id"] = aws_account_id
            if dashboard_id is None and not opts.urn:
                raise TypeError("Missing required property 'dashboard_id'")
            __props__.__dict__["dashboard_id"] = dashboard_id
            __props__.__dict__["dashboard_publish_options"] = dashboard_publish_options
            __props__.__dict__["name"] = name
            __props__.__dict__["parameters"] = parameters
            __props__.__dict__["permissions"] = permissions
            __props__.__dict__["source_entity"] = source_entity
            __props__.__dict__["tags"] = tags
            __props__.__dict__["theme_arn"] = theme_arn
            __props__.__dict__["version_description"] = version_description
            __props__.__dict__["arn"] = None
            __props__.__dict__["created_time"] = None
            __props__.__dict__["last_published_time"] = None
            __props__.__dict__["last_updated_time"] = None
            __props__.__dict__["version"] = None
        super(Dashboard, __self__).__init__(
            'aws-native:quicksight:Dashboard',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Dashboard':
        """
        Get an existing Dashboard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DashboardArgs.__new__(DashboardArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["aws_account_id"] = None
        __props__.__dict__["created_time"] = None
        __props__.__dict__["dashboard_id"] = None
        __props__.__dict__["dashboard_publish_options"] = None
        __props__.__dict__["last_published_time"] = None
        __props__.__dict__["last_updated_time"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["parameters"] = None
        __props__.__dict__["permissions"] = None
        __props__.__dict__["source_entity"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["theme_arn"] = None
        __props__.__dict__["version"] = None
        __props__.__dict__["version_description"] = None
        return Dashboard(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        <p>The Amazon Resource Name (ARN) of the resource.</p>
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="awsAccountId")
    def aws_account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "aws_account_id")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> pulumi.Output[str]:
        """
        <p>The time that this dataset was created.</p>
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="dashboardId")
    def dashboard_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "dashboard_id")

    @property
    @pulumi.getter(name="dashboardPublishOptions")
    def dashboard_publish_options(self) -> pulumi.Output[Optional['outputs.DashboardDashboardPublishOptions']]:
        return pulumi.get(self, "dashboard_publish_options")

    @property
    @pulumi.getter(name="lastPublishedTime")
    def last_published_time(self) -> pulumi.Output[str]:
        """
        <p>The last time that this dataset was published.</p>
        """
        return pulumi.get(self, "last_published_time")

    @property
    @pulumi.getter(name="lastUpdatedTime")
    def last_updated_time(self) -> pulumi.Output[str]:
        """
        <p>The last time that this dataset was updated.</p>
        """
        return pulumi.get(self, "last_updated_time")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        <p>The display name of the dashboard.</p>
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Optional['outputs.DashboardParameters']]:
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Output[Optional[Sequence['outputs.DashboardResourcePermission']]]:
        """
        <p>A structure that contains the permissions of the dashboard. You can use this structure
                    for granting permissions by providing a list of IAM action information for each
                    principal ARN. </p>

                <p>To specify no permissions, omit the permissions list.</p>
        """
        return pulumi.get(self, "permissions")

    @property
    @pulumi.getter(name="sourceEntity")
    def source_entity(self) -> pulumi.Output[Optional['outputs.DashboardDashboardSourceEntity']]:
        return pulumi.get(self, "source_entity")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DashboardTag']]]:
        """
        <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
                    dashboard.</p>
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="themeArn")
    def theme_arn(self) -> pulumi.Output[Optional[str]]:
        """
        <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
                    you add a value for this field, it overrides the value that is used in the source
                    entity. The theme ARN must exist in the same AWS account where you create the
                    dashboard.</p>
        """
        return pulumi.get(self, "theme_arn")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output['outputs.DashboardDashboardVersion']:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="versionDescription")
    def version_description(self) -> pulumi.Output[Optional[str]]:
        """
        <p>A description for the first version of the dashboard being created.</p>
        """
        return pulumi.get(self, "version_description")

