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
    [Cmdlet("Get", "OCIResourcemanagerStackAssociatedResourcesList")]
    [OutputType(new System.Type[] { typeof(Oci.ResourcemanagerService.Models.AssociatedResourcesCollection), typeof(Oci.ResourcemanagerService.Responses.ListStackAssociatedResourcesResponse) })]
    public class GetOCIResourcemanagerStackAssociatedResourcesList : OCIResourceManagerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the stack.")]
        public string StackId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only specified resource types. For more information about resource types supported for the Oracle Cloud Infrastructure [OCI] provider, see [Oracle Cloud Infrastructure Provider](https://registry.terraform.io/providers/oracle/oci/latest/docs).")]
        public string TerraformResourceType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that exist in the compartment, identified by [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The number of items returned in a paginated `List` call. For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the preceding `List` call. For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListStackAssociatedResourcesRequest request;

            try
            {
                request = new ListStackAssociatedResourcesRequest
                {
                    StackId = StackId,
                    OpcRequestId = OpcRequestId,
                    TerraformResourceType = TerraformResourceType,
                    CompartmentId = CompartmentId,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListStackAssociatedResourcesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.AssociatedResourcesCollection, true);
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
            IEnumerable<ListStackAssociatedResourcesResponse> DefaultRequest(ListStackAssociatedResourcesRequest request) => Enumerable.Repeat(client.ListStackAssociatedResources(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListStackAssociatedResourcesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListStackAssociatedResourcesResponse response;
        private delegate IEnumerable<ListStackAssociatedResourcesResponse> RequestDelegate(ListStackAssociatedResourcesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
