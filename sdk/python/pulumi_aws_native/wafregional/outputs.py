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
    'ByteMatchSetByteMatchTuple',
    'ByteMatchSetFieldToMatch',
    'GeoMatchSetGeoMatchConstraint',
    'IPSetIPSetDescriptor',
    'RateBasedRulePredicate',
    'RulePredicate',
    'SizeConstraintSetFieldToMatch',
    'SizeConstraintSetSizeConstraint',
    'SqlInjectionMatchSetFieldToMatch',
    'SqlInjectionMatchSetSqlInjectionMatchTuple',
    'WebACLAction',
    'WebACLRule',
    'XssMatchSetFieldToMatch',
    'XssMatchSetXssMatchTuple',
]

@pulumi.output_type
class ByteMatchSetByteMatchTuple(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "fieldToMatch":
            suggest = "field_to_match"
        elif key == "positionalConstraint":
            suggest = "positional_constraint"
        elif key == "textTransformation":
            suggest = "text_transformation"
        elif key == "targetString":
            suggest = "target_string"
        elif key == "targetStringBase64":
            suggest = "target_string_base64"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ByteMatchSetByteMatchTuple. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ByteMatchSetByteMatchTuple.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ByteMatchSetByteMatchTuple.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 field_to_match: 'outputs.ByteMatchSetFieldToMatch',
                 positional_constraint: str,
                 text_transformation: str,
                 target_string: Optional[str] = None,
                 target_string_base64: Optional[str] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html
        :param 'ByteMatchSetFieldToMatch' field_to_match: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-fieldtomatch
        :param str positional_constraint: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-positionalconstraint
        :param str text_transformation: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-texttransformation
        :param str target_string: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstring
        :param str target_string_base64: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstringbase64
        """
        pulumi.set(__self__, "field_to_match", field_to_match)
        pulumi.set(__self__, "positional_constraint", positional_constraint)
        pulumi.set(__self__, "text_transformation", text_transformation)
        if target_string is not None:
            pulumi.set(__self__, "target_string", target_string)
        if target_string_base64 is not None:
            pulumi.set(__self__, "target_string_base64", target_string_base64)

    @property
    @pulumi.getter(name="fieldToMatch")
    def field_to_match(self) -> 'outputs.ByteMatchSetFieldToMatch':
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-fieldtomatch
        """
        return pulumi.get(self, "field_to_match")

    @property
    @pulumi.getter(name="positionalConstraint")
    def positional_constraint(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-positionalconstraint
        """
        return pulumi.get(self, "positional_constraint")

    @property
    @pulumi.getter(name="textTransformation")
    def text_transformation(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-texttransformation
        """
        return pulumi.get(self, "text_transformation")

    @property
    @pulumi.getter(name="targetString")
    def target_string(self) -> Optional[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstring
        """
        return pulumi.get(self, "target_string")

    @property
    @pulumi.getter(name="targetStringBase64")
    def target_string_base64(self) -> Optional[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstringbase64
        """
        return pulumi.get(self, "target_string_base64")


@pulumi.output_type
class ByteMatchSetFieldToMatch(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html
    """
    def __init__(__self__, *,
                 type: str,
                 data: Optional[str] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-type
        :param str data: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-data
        """
        pulumi.set(__self__, "type", type)
        if data is not None:
            pulumi.set(__self__, "data", data)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def data(self) -> Optional[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-data
        """
        return pulumi.get(self, "data")


@pulumi.output_type
class GeoMatchSetGeoMatchConstraint(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html
    """
    def __init__(__self__, *,
                 type: str,
                 value: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-type
        :param str value: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-value
        """
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-geomatchset-geomatchconstraint.html#cfn-wafregional-geomatchset-geomatchconstraint-value
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class IPSetIPSetDescriptor(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html
    """
    def __init__(__self__, *,
                 type: str,
                 value: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html#cfn-wafregional-ipset-ipsetdescriptor-type
        :param str value: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html#cfn-wafregional-ipset-ipsetdescriptor-value
        """
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html#cfn-wafregional-ipset-ipsetdescriptor-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ipset-ipsetdescriptor.html#cfn-wafregional-ipset-ipsetdescriptor-value
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class RateBasedRulePredicate(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "dataId":
            suggest = "data_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RateBasedRulePredicate. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RateBasedRulePredicate.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RateBasedRulePredicate.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 data_id: str,
                 negated: bool,
                 type: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html
        :param str data_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-dataid
        :param bool negated: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-negated
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-type
        """
        pulumi.set(__self__, "data_id", data_id)
        pulumi.set(__self__, "negated", negated)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="dataId")
    def data_id(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-dataid
        """
        return pulumi.get(self, "data_id")

    @property
    @pulumi.getter
    def negated(self) -> bool:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-negated
        """
        return pulumi.get(self, "negated")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-type
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class RulePredicate(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "dataId":
            suggest = "data_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RulePredicate. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RulePredicate.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RulePredicate.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 data_id: str,
                 negated: bool,
                 type: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html
        :param str data_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-dataid
        :param bool negated: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-negated
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-type
        """
        pulumi.set(__self__, "data_id", data_id)
        pulumi.set(__self__, "negated", negated)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="dataId")
    def data_id(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-dataid
        """
        return pulumi.get(self, "data_id")

    @property
    @pulumi.getter
    def negated(self) -> bool:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-negated
        """
        return pulumi.get(self, "negated")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-type
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class SizeConstraintSetFieldToMatch(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html
    """
    def __init__(__self__, *,
                 type: str,
                 data: Optional[str] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html#cfn-wafregional-sizeconstraintset-fieldtomatch-type
        :param str data: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html#cfn-wafregional-sizeconstraintset-fieldtomatch-data
        """
        pulumi.set(__self__, "type", type)
        if data is not None:
            pulumi.set(__self__, "data", data)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html#cfn-wafregional-sizeconstraintset-fieldtomatch-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def data(self) -> Optional[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-fieldtomatch.html#cfn-wafregional-sizeconstraintset-fieldtomatch-data
        """
        return pulumi.get(self, "data")


@pulumi.output_type
class SizeConstraintSetSizeConstraint(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "comparisonOperator":
            suggest = "comparison_operator"
        elif key == "fieldToMatch":
            suggest = "field_to_match"
        elif key == "textTransformation":
            suggest = "text_transformation"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in SizeConstraintSetSizeConstraint. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        SizeConstraintSetSizeConstraint.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        SizeConstraintSetSizeConstraint.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 comparison_operator: str,
                 field_to_match: 'outputs.SizeConstraintSetFieldToMatch',
                 size: int,
                 text_transformation: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html
        :param str comparison_operator: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-comparisonoperator
        :param 'SizeConstraintSetFieldToMatch' field_to_match: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-fieldtomatch
        :param int size: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-size
        :param str text_transformation: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-texttransformation
        """
        pulumi.set(__self__, "comparison_operator", comparison_operator)
        pulumi.set(__self__, "field_to_match", field_to_match)
        pulumi.set(__self__, "size", size)
        pulumi.set(__self__, "text_transformation", text_transformation)

    @property
    @pulumi.getter(name="comparisonOperator")
    def comparison_operator(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-comparisonoperator
        """
        return pulumi.get(self, "comparison_operator")

    @property
    @pulumi.getter(name="fieldToMatch")
    def field_to_match(self) -> 'outputs.SizeConstraintSetFieldToMatch':
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-fieldtomatch
        """
        return pulumi.get(self, "field_to_match")

    @property
    @pulumi.getter
    def size(self) -> int:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-size
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter(name="textTransformation")
    def text_transformation(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sizeconstraintset-sizeconstraint.html#cfn-wafregional-sizeconstraintset-sizeconstraint-texttransformation
        """
        return pulumi.get(self, "text_transformation")


@pulumi.output_type
class SqlInjectionMatchSetFieldToMatch(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-fieldtomatch.html
    """
    def __init__(__self__, *,
                 type: str,
                 data: Optional[str] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-fieldtomatch.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-fieldtomatch.html#cfn-wafregional-sqlinjectionmatchset-fieldtomatch-type
        :param str data: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-fieldtomatch.html#cfn-wafregional-sqlinjectionmatchset-fieldtomatch-data
        """
        pulumi.set(__self__, "type", type)
        if data is not None:
            pulumi.set(__self__, "data", data)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-fieldtomatch.html#cfn-wafregional-sqlinjectionmatchset-fieldtomatch-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def data(self) -> Optional[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-fieldtomatch.html#cfn-wafregional-sqlinjectionmatchset-fieldtomatch-data
        """
        return pulumi.get(self, "data")


@pulumi.output_type
class SqlInjectionMatchSetSqlInjectionMatchTuple(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "fieldToMatch":
            suggest = "field_to_match"
        elif key == "textTransformation":
            suggest = "text_transformation"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in SqlInjectionMatchSetSqlInjectionMatchTuple. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        SqlInjectionMatchSetSqlInjectionMatchTuple.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        SqlInjectionMatchSetSqlInjectionMatchTuple.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 field_to_match: 'outputs.SqlInjectionMatchSetFieldToMatch',
                 text_transformation: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html
        :param 'SqlInjectionMatchSetFieldToMatch' field_to_match: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html#cfn-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple-fieldtomatch
        :param str text_transformation: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html#cfn-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple-texttransformation
        """
        pulumi.set(__self__, "field_to_match", field_to_match)
        pulumi.set(__self__, "text_transformation", text_transformation)

    @property
    @pulumi.getter(name="fieldToMatch")
    def field_to_match(self) -> 'outputs.SqlInjectionMatchSetFieldToMatch':
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html#cfn-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple-fieldtomatch
        """
        return pulumi.get(self, "field_to_match")

    @property
    @pulumi.getter(name="textTransformation")
    def text_transformation(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple.html#cfn-wafregional-sqlinjectionmatchset-sqlinjectionmatchtuple-texttransformation
        """
        return pulumi.get(self, "text_transformation")


@pulumi.output_type
class WebACLAction(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-action.html
    """
    def __init__(__self__, *,
                 type: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-action.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-action.html#cfn-wafregional-webacl-action-type
        """
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-action.html#cfn-wafregional-webacl-action-type
        """
        return pulumi.get(self, "type")


@pulumi.output_type
class WebACLRule(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "ruleId":
            suggest = "rule_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in WebACLRule. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        WebACLRule.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        WebACLRule.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 action: 'outputs.WebACLAction',
                 priority: int,
                 rule_id: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html
        :param 'WebACLAction' action: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-action
        :param int priority: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-priority
        :param str rule_id: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-ruleid
        """
        pulumi.set(__self__, "action", action)
        pulumi.set(__self__, "priority", priority)
        pulumi.set(__self__, "rule_id", rule_id)

    @property
    @pulumi.getter
    def action(self) -> 'outputs.WebACLAction':
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-action
        """
        return pulumi.get(self, "action")

    @property
    @pulumi.getter
    def priority(self) -> int:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-priority
        """
        return pulumi.get(self, "priority")

    @property
    @pulumi.getter(name="ruleId")
    def rule_id(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-ruleid
        """
        return pulumi.get(self, "rule_id")


@pulumi.output_type
class XssMatchSetFieldToMatch(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html
    """
    def __init__(__self__, *,
                 type: str,
                 data: Optional[str] = None):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html
        :param str type: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-type
        :param str data: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-data
        """
        pulumi.set(__self__, "type", type)
        if data is not None:
            pulumi.set(__self__, "data", data)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-type
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def data(self) -> Optional[str]:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-fieldtomatch.html#cfn-wafregional-xssmatchset-fieldtomatch-data
        """
        return pulumi.get(self, "data")


@pulumi.output_type
class XssMatchSetXssMatchTuple(dict):
    """
    http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "fieldToMatch":
            suggest = "field_to_match"
        elif key == "textTransformation":
            suggest = "text_transformation"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in XssMatchSetXssMatchTuple. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        XssMatchSetXssMatchTuple.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        XssMatchSetXssMatchTuple.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 field_to_match: 'outputs.XssMatchSetFieldToMatch',
                 text_transformation: str):
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html
        :param 'XssMatchSetFieldToMatch' field_to_match: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-fieldtomatch
        :param str text_transformation: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-texttransformation
        """
        pulumi.set(__self__, "field_to_match", field_to_match)
        pulumi.set(__self__, "text_transformation", text_transformation)

    @property
    @pulumi.getter(name="fieldToMatch")
    def field_to_match(self) -> 'outputs.XssMatchSetFieldToMatch':
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-fieldtomatch
        """
        return pulumi.get(self, "field_to_match")

    @property
    @pulumi.getter(name="textTransformation")
    def text_transformation(self) -> str:
        """
        http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-xssmatchset-xssmatchtuple.html#cfn-wafregional-xssmatchset-xssmatchtuple-texttransformation
        """
        return pulumi.get(self, "text_transformation")

