/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180917
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.ResourcemanagerService.Requests;
using Oci.ResourcemanagerService.Responses;
using Oci.ResourcemanagerService.Models;
using Oci.Common.Model;

namespace Oci.ResourcemanagerService.Cmdlets
{
    [Cmdlet("Get", "OCIResourcemanagerTemplatesList")]
    [OutputType(new System.Type[] { typeof(Oci.ResourcemanagerService.Models.TemplateSummaryCollection), typeof(Oci.ResourcemanagerService.Responses.ListTemplatesResponse) })]
    public class GetOCIResourcemanagerTemplatesList : OCIResourceManagerCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that exist in the compartment, identified by [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the template category. Possible values are `0` (Quickstarts), `1` (Service), `2` (Architecture), and `3` (Private). Template category labels are displayed in the Console page listing templates. Quickstarts, Service, and Architecture templates (categories 0, 1, and 2) are available in all compartments. Each private template (category 3) is available in the compartment where it was created.")]
        public string TemplateCategoryId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the template.")]
        public string TemplateId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given display name exactly. Use this filter to list a resource by name. Requires `sortBy` set to `DISPLAYNAME`. Alternatively, when you know the resource OCID, use the related Get operation.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to use when sorting returned resources. By default, `TIMECREATED` is ordered descending. By default, `DISPLAYNAME` is ordered ascending. Note that you can sort only on one field.")]
        public System.Nullable<Oci.ResourcemanagerService.Requests.ListTemplatesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use when sorting returned resources. Ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.ResourcemanagerService.Requests.ListTemplatesRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The number of items returned in a paginated `List` call. For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the preceding `List` call. For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListTemplatesRequest request;

            try
            {
                request = new ListTemplatesRequest
                {
                    OpcRequestId = OpcRequestId,
                    CompartmentId = CompartmentId,
                    TemplateCategoryId = TemplateCategoryId,
                    TemplateId = TemplateId,
                    DisplayName = DisplayName,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListTemplatesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.TemplateSummaryCollection, true);
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
            IEnumerable<ListTemplatesResponse> DefaultRequest(ListTemplatesRequest request) => Enumerable.Repeat(client.ListTemplates(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListTemplatesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListTemplatesResponse response;
        private delegate IEnumerable<ListTemplatesResponse> RequestDelegate(ListTemplatesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
