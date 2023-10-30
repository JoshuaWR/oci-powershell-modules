/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatasafeService.Requests;
using Oci.DatasafeService.Responses;
using Oci.DatasafeService.Models;
using Oci.Common.Model;

namespace Oci.DatasafeService.Cmdlets
{
    [Cmdlet("Get", "OCIDatasafeSensitiveColumnsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatasafeService.Models.SensitiveColumnCollection), typeof(Oci.DatasafeService.Responses.ListSensitiveColumnsResponse) })]
    public class GetOCIDatasafeSensitiveColumnsList : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the sensitive data model.")]
        public string SensitiveDataModelId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that were created after the specified date and time, as defined by [RFC3339](https://tools.ietf.org/html/rfc3339). Using TimeCreatedGreaterThanOrEqualToQueryParam parameter retrieves all resources created after that date.

**Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search for resources that were created before a specific date. Specifying this parameter corresponding `timeCreatedLessThan` parameter will retrieve all resources created before the specified created date, in ""YYYY-MM-ddThh:mmZ"" format with a Z offset, as defined by RFC 3339.

**Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search for resources that were updated after a specific date. Specifying this parameter corresponding `timeUpdatedGreaterThanOrEqualTo` parameter will retrieve all resources updated after the specified created date, in ""YYYY-MM-ddThh:mmZ"" format with a Z offset, as defined by RFC 3339.")]
        public System.Nullable<System.DateTime> TimeUpdatedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search for resources that were updated before a specific date. Specifying this parameter corresponding `timeUpdatedLessThan` parameter will retrieve all resources updated before the specified created date, in ""YYYY-MM-ddThh:mmZ"" format with a Z offset, as defined by RFC 3339.")]
        public System.Nullable<System.DateTime> TimeUpdatedLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filters the sensitive column resources with the given lifecycle state values.")]
        public System.Nullable<Oci.DatasafeService.Models.SensitiveColumnLifecycleState> SensitiveColumnLifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items related to specific schema name.")]
        public System.Collections.Generic.List<string> SchemaName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items related to a specific object name.")]
        public System.Collections.Generic.List<string> ObjectName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only a specific column based on column name.")]
        public System.Collections.Generic.List<string> ColumnName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items related to a specific object type.")]
        public System.Collections.Generic.List<Oci.DatasafeService.Requests.ListSensitiveColumnsRequest.ObjectTypeEnum> ObjectType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the specified data types.")]
        public System.Collections.Generic.List<string> DataType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the sensitive columns that match the specified status.")]
        public System.Collections.Generic.List<Oci.DatasafeService.Requests.ListSensitiveColumnsRequest.StatusEnum> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the sensitive columns that are associated with one of the sensitive types identified by the specified OCIDs.")]
        public System.Collections.Generic.List<string> SensitiveTypeId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the sensitive columns that are children of one of the columns identified by the specified keys.")]
        public System.Collections.Generic.List<string> ParentColumnKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return sensitive columns based on their relationship with their parent columns. If set to NONE, it returns the sensitive columns that do not have any parent. The response includes the parent columns as well as the independent columns that are not in any relationship. If set to APP_DEFINED, it returns all the child columns that have application-level (non-dictionary) relationship with their parents. If set to DB_DEFINED, it returns all the child columns that have database-level (dictionary-defined) relationship with their parents.")]
        public System.Collections.Generic.List<Oci.DatasafeService.Requests.ListSensitiveColumnsRequest.RelationTypeEnum> RelationType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the sensitive columns that belong to the specified column group.")]
        public string ColumnGroup { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of items to return per page in a paginated ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (ASC) or descending (DESC).")]
        public System.Nullable<Oci.DatasafeService.Requests.ListSensitiveColumnsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can specify only one sorting parameter (sortOrder). The default order for timeCreated is descending. The default order for schemaName, objectName, and columnName is ascending.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListSensitiveColumnsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A boolean flag indicating whether the search should be case-insensitive. The search is case-sensitive by default. Set this parameter to true to do case-insensitive search.")]
        public System.Nullable<bool> IsCaseInSensitive { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSensitiveColumnsRequest request;

            try
            {
                request = new ListSensitiveColumnsRequest
                {
                    SensitiveDataModelId = SensitiveDataModelId,
                    TimeCreatedGreaterThanOrEqualTo = TimeCreatedGreaterThanOrEqualTo,
                    TimeCreatedLessThan = TimeCreatedLessThan,
                    TimeUpdatedGreaterThanOrEqualTo = TimeUpdatedGreaterThanOrEqualTo,
                    TimeUpdatedLessThan = TimeUpdatedLessThan,
                    SensitiveColumnLifecycleState = SensitiveColumnLifecycleState,
                    SchemaName = SchemaName,
                    ObjectName = ObjectName,
                    ColumnName = ColumnName,
                    ObjectType = ObjectType,
                    DataType = DataType,
                    Status = Status,
                    SensitiveTypeId = SensitiveTypeId,
                    ParentColumnKey = ParentColumnKey,
                    RelationType = RelationType,
                    ColumnGroup = ColumnGroup,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId,
                    IsCaseInSensitive = IsCaseInSensitive
                };
                IEnumerable<ListSensitiveColumnsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.SensitiveColumnCollection, true);
                }
                if(!ParameterSetName.Equals(AllPageSet) && !ParameterSetName.Equals(LimitSet) && response.OpcNextPage != null)
                {
                    WriteWarning("This operation supports pagination and not all resources were returned. Re-run using the -All option to auto paginate and list all resources.");
                }
                FinishProcessing(response);
            }
            catch (OciException ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
            TerminatingErrorDuringExecution(new OperationCanceledException("Cmdlet execution interrupted"));
        }

        private RequestDelegate GetRequestDelegate()
        {
            IEnumerable<ListSensitiveColumnsResponse> DefaultRequest(ListSensitiveColumnsRequest request) => Enumerable.Repeat(client.ListSensitiveColumns(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSensitiveColumnsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSensitiveColumnsResponse response;
        private delegate IEnumerable<ListSensitiveColumnsResponse> RequestDelegate(ListSensitiveColumnsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
