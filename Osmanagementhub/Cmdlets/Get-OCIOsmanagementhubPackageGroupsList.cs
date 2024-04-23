/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220901
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OsmanagementhubService.Requests;
using Oci.OsmanagementhubService.Responses;
using Oci.OsmanagementhubService.Models;
using Oci.Common.Model;

namespace Oci.OsmanagementhubService.Cmdlets
{
    [Cmdlet("Get", "OCIOsmanagementhubPackageGroupsList")]
    [OutputType(new System.Type[] { typeof(Oci.OsmanagementhubService.Models.PackageGroupCollection), typeof(Oci.OsmanagementhubService.Responses.ListPackageGroupsResponse) })]
    public class GetOCIOsmanagementhubPackageGroupsList : OCISoftwareSourceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the software source.")]
        public string SoftwareSourceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment that contains the resources to list. This filter returns only resources contained within the specified compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the entity to be queried.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return resources that may partially match the name given.")]
        public string NameContains { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only package groups of the specified type.")]
        public System.Collections.Generic.List<Oci.OsmanagementhubService.Models.PackageGroup.GroupTypeEnum> GroupType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `50`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).

Example: `3`")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.OsmanagementhubService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending.")]
        public System.Nullable<Oci.OsmanagementhubService.Requests.ListPackageGroupsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListPackageGroupsRequest request;

            try
            {
                request = new ListPackageGroupsRequest
                {
                    SoftwareSourceId = SoftwareSourceId,
                    CompartmentId = CompartmentId,
                    Name = Name,
                    NameContains = NameContains,
                    GroupType = GroupType,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListPackageGroupsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.PackageGroupCollection, true);
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
            IEnumerable<ListPackageGroupsResponse> DefaultRequest(ListPackageGroupsRequest request) => Enumerable.Repeat(client.ListPackageGroups(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListPackageGroupsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListPackageGroupsResponse response;
        private delegate IEnumerable<ListPackageGroupsResponse> RequestDelegate(ListPackageGroupsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
