using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Compute.v2021_07_01.CommunityGalleryImages;


internal class CommunityGalleryImageModel
{
    [JsonPropertyName("identifier")]
    public CommunityGalleryIdentifierModel? Identifier { get; set; }

    [JsonPropertyName("location")]
    public CustomTypes.Location? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties")]
    public CommunityGalleryImagePropertiesModel? Properties { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
