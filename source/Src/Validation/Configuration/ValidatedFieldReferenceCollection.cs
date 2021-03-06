﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Configuration
{
    /// <summary>
    /// Represents a collection of validated fields.
    /// </summary>
    /// <seealso cref="ValidatedFieldReference"/>
    [ConfigurationCollection(typeof(ValidatedFieldReference), AddItemName = "field", ClearItemsName = "clear", RemoveItemName = "remove")]
    public class ValidatedFieldReferenceCollection : NamedElementCollection<ValidatedFieldReference>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ValidatedFieldReferenceCollection"/> class.</para>
        /// </summary>
        public ValidatedFieldReferenceCollection()
        {
            this.AddElementName = "field";
        }
    }
}
