﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.TestSupport.TestClasses
{
    public class DerivedTestTypeWithValidatorAttributes : BaseTestTypeWithValidatorAttributes
    {
        [MockValidator(false, MessageTemplate = "PropertyWithMultipleAttributesOverride-Message1")]
        public override object PropertyWithMultipleAttributes
        {
            get
            {
                return base.PropertyWithMultipleAttributes;
            }
        }

        [MockValidator(false, MessageTemplate = "MethodWithMultipleAttributesOverride-Message1")]
        [MockValidator(false, MessageTemplate = "MethodWithMultipleAttributesOverride-Message1-RuleA", Ruleset = "RuleA")]
        [MockValidator(false, MessageTemplate = "MethodWithMultipleAttributesOverride-Message2-RuleA", Ruleset = "RuleA")]
        public override object MethodWithMultipleAttributes()
        {
            return base.PropertyWithMultipleAttributes;
        }
    }
}
