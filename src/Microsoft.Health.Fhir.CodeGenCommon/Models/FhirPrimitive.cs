﻿// <copyright file="FhirPrimitive.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Health.Fhir.CodeGenCommon.Models;

/// <summary>A class representing a FHIR primitive (r2:simple) type.</summary>
public class FhirPrimitive : FhirTypeBase, ICloneable
{
    /// <summary>Initializes a new instance of the <see cref="FhirPrimitive"/> class.</summary>
    /// <param name="id">              The identifier.</param>
    /// <param name="path">            Full pathname of the file.</param>
    /// <param name="baseTypeName">    The base type name for this primitive type.</param>
    /// <param name="url">             URL of the resource.</param>
    /// <param name="standardStatus">  The standard status.</param>
    /// <param name="isExperimental">  If this primitive type is marked experimental.</param>
    /// <param name="shortDescription">Information describing the short.</param>
    /// <param name="purpose">         The purpose of this definition.</param>
    /// <param name="comment">         The comment.</param>
    /// <param name="validationRegEx"> The validation RegEx.</param>
    public FhirPrimitive(
        string id,
        string path,
        string baseTypeName,
        Uri url,
        string standardStatus,
        bool isExperimental,
        string shortDescription,
        string purpose,
        string comment,
        string validationRegEx)
        : base(
            id,
            path,
            url,
            standardStatus,
            isExperimental,
            shortDescription,
            purpose,
            comment,
            validationRegEx,
            baseTypeName)
    {
    }

    /// <summary>Deep copy.</summary>
    /// <returns>A FhirPrimitive.</returns>
    public object Clone()
    {
        // generate the base object
        FhirPrimitive primitive = new FhirPrimitive(
            Id,
            Path,
            BaseTypeName,
            URL,
            StandardStatus,
            IsExperimental,
            ShortDescription,
            Purpose,
            Comment,
            ValidationRegEx);

        return primitive;
    }
}
