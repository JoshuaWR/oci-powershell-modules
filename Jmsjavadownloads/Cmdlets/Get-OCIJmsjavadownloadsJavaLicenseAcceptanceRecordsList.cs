/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20230601
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.JmsjavadownloadsService.Requests;
using Oci.JmsjavadownloadsService.Responses;
using Oci.JmsjavadownloadsService.Models;
using Oci.Common.Model;

namespace Oci.JmsjavadownloadsService.Cmdlets
{
    [Cmdlet("Get", "OCIJmsjavadownloadsJavaLicenseAcceptanceRecordsList")]
    [OutputType(new System.Type[] { typeof(Oci.JmsjavadownloadsService.Models.JavaLicenseAcceptanceRecordCollection), typeof(Oci.JmsjavadownloadsService.Responses.ListJavaLicenseAcceptanceRecordsResponse) })]
    public class GetOCIJmsjavadownloadsJavaLicenseAcceptanceRecordsList : OCIJavaDownloadCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the tenancy.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the user principal detail. The search string can be any of the property values from the Principal object. This object is used as a response datatype for the `createdBy` and `lastUpdatedBy` fields in applicable resource.")]
        public string SearchByUser { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Java license acceptance record identifier.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Java license type.")]
        public System.Nullable<Oci.JmsjavadownloadsService.Models.LicenseType> LicenseType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The status of license acceptance.")]
        public System.Nullable<Oci.JmsjavadownloadsService.Models.LicenseAcceptanceStatus> Status { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. The token is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.JmsjavadownloadsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. If no value is specified, _timeAccepted_ is the default.")]
        public System.Nullable<Oci.JmsjavadownloadsService.Models.LicenseAcceptanceSortBy> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListJavaLicenseAcceptanceRecordsRequest request;

            try
            {
                request = new ListJavaLicenseAcceptanceRecordsRequest
                {
                    CompartmentId = CompartmentId,
                    SearchByUser = SearchByUser,
                    Id = Id,
                    LicenseType = LicenseType,
                    Status = Status,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListJavaLicenseAcceptanceRecordsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.JavaLicenseAcceptanceRecordCollection, true);
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
            IEnumerable<ListJavaLicenseAcceptanceRecordsResponse> DefaultRequest(ListJavaLicenseAcceptanceRecordsRequest request) => Enumerable.Repeat(client.ListJavaLicenseAcceptanceRecords(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListJavaLicenseAcceptanceRecordsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListJavaLicenseAcceptanceRecordsResponse response;
        private delegate IEnumerable<ListJavaLicenseAcceptanceRecordsResponse> RequestDelegate(ListJavaLicenseAcceptanceRecordsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
