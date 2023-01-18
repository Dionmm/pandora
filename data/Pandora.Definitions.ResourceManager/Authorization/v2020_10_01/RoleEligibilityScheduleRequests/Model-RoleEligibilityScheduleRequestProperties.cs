using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization.v2020_10_01.RoleEligibilityScheduleRequests;


internal class RoleEligibilityScheduleRequestPropertiesModel
{
    [JsonPropertyName("approvalId")]
    public string? ApprovalId { get; set; }

    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    [JsonPropertyName("conditionVersion")]
    public string? ConditionVersion { get; set; }

    [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
    [JsonPropertyName("createdOn")]
    public DateTime? CreatedOn { get; set; }

    [JsonPropertyName("expandedProperties")]
    public ExpandedPropertiesModel? ExpandedProperties { get; set; }

    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    [JsonPropertyName("principalId")]
    [Required]
    public string PrincipalId { get; set; }

    [JsonPropertyName("principalType")]
    public PrincipalTypeConstant? PrincipalType { get; set; }

    [JsonPropertyName("requestType")]
    [Required]
    public RequestTypeConstant RequestType { get; set; }

    [JsonPropertyName("requestorId")]
    public string? RequestorId { get; set; }

    [JsonPropertyName("roleDefinitionId")]
    [Required]
    public string RoleDefinitionId { get; set; }

    [JsonPropertyName("scheduleInfo")]
    public RoleEligibilityScheduleRequestPropertiesScheduleInfoModel? ScheduleInfo { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("status")]
    public StatusConstant? Status { get; set; }

    [JsonPropertyName("targetRoleEligibilityScheduleId")]
    public string? TargetRoleEligibilityScheduleId { get; set; }

    [JsonPropertyName("targetRoleEligibilityScheduleInstanceId")]
    public string? TargetRoleEligibilityScheduleInstanceId { get; set; }

    [JsonPropertyName("ticketInfo")]
    public RoleEligibilityScheduleRequestPropertiesTicketInfoModel? TicketInfo { get; set; }
}
