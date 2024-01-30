/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatabasemanagementService.Requests;
using Oci.DatabasemanagementService.Responses;
using Oci.DatabasemanagementService.Models;
using Oci.Common.Model;

namespace Oci.DatabasemanagementService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabasemanagementSqlTuningAdvisorTasksList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabasemanagementService.Models.SqlTuningAdvisorTaskCollection), typeof(Oci.DatabasemanagementService.Responses.ListSqlTuningAdvisorTasksResponse) })]
    public class GetOCIDatabasemanagementSqlTuningAdvisorTasksList : OCISqlTuningCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.")]
        public string ManagedDatabaseId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The optional query parameter to filter the SQL Tuning Advisor task list by name.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The optional query parameter to filter the SQL Tuning Advisor task list by status.")]
        public System.Nullable<Oci.DatabasemanagementService.Requests.ListSqlTuningAdvisorTasksRequest.StatusEnum> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The optional greater than or equal to query parameter to filter the timestamp.")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The optional less than or equal to query parameter to filter the timestamp.")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page from where the next set of paginated results are retrieved. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of records returned in the paginated response.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The option to sort the SQL Tuning Advisor task summary data.")]
        public System.Nullable<Oci.DatabasemanagementService.Requests.ListSqlTuningAdvisorTasksRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The option to sort information in ascending ('ASC') or descending ('DESC') order. Descending order is the default order.")]
        public System.Nullable<Oci.DatabasemanagementService.Models.SortOrders> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the Named Credential.")]
        public string OpcNamedCredentialId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSqlTuningAdvisorTasksRequest request;

            try
            {
                request = new ListSqlTuningAdvisorTasksRequest
                {
                    ManagedDatabaseId = ManagedDatabaseId,
                    Name = Name,
                    Status = Status,
                    TimeGreaterThanOrEqualTo = TimeGreaterThanOrEqualTo,
                    TimeLessThanOrEqualTo = TimeLessThanOrEqualTo,
                    Page = Page,
                    Limit = Limit,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    OpcRequestId = OpcRequestId,
                    OpcNamedCredentialId = OpcNamedCredentialId
                };
                IEnumerable<ListSqlTuningAdvisorTasksResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.SqlTuningAdvisorTaskCollection, true);
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
            IEnumerable<ListSqlTuningAdvisorTasksResponse> DefaultRequest(ListSqlTuningAdvisorTasksRequest request) => Enumerable.Repeat(client.ListSqlTuningAdvisorTasks(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSqlTuningAdvisorTasksResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSqlTuningAdvisorTasksResponse response;
        private delegate IEnumerable<ListSqlTuningAdvisorTasksResponse> RequestDelegate(ListSqlTuningAdvisorTasksRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
