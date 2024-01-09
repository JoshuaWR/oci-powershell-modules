/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20230701
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.OcvpService.Requests;
using Oci.OcvpService.Responses;
using Oci.OcvpService.Models;
using Oci.Common.Model;

namespace Oci.OcvpService.Cmdlets
{
    [Cmdlet("Get", "OCIOcvpSupportedVmwareSoftwareVersionsList")]
    [OutputType(new System.Type[] { typeof(Oci.OcvpService.Models.SupportedVmwareSoftwareVersionCollection), typeof(Oci.OcvpService.Responses.ListSupportedVmwareSoftwareVersionsResponse) })]
    public class GetOCIOcvpSupportedVmwareSoftwareVersionsList : OCISddcCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the given VMware software version exactly.")]
        public string Version { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match or support the given ESXi host shape.")]
        public string HostShapeName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSupportedVmwareSoftwareVersionsRequest request;

            try
            {
                request = new ListSupportedVmwareSoftwareVersionsRequest
                {
                    CompartmentId = CompartmentId,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId,
                    Version = Version,
                    HostShapeName = HostShapeName
                };
                IEnumerable<ListSupportedVmwareSoftwareVersionsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.SupportedVmwareSoftwareVersionCollection, true);
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
            IEnumerable<ListSupportedVmwareSoftwareVersionsResponse> DefaultRequest(ListSupportedVmwareSoftwareVersionsRequest request) => Enumerable.Repeat(client.ListSupportedVmwareSoftwareVersions(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSupportedVmwareSoftwareVersionsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSupportedVmwareSoftwareVersionsResponse response;
        private delegate IEnumerable<ListSupportedVmwareSoftwareVersionsResponse> RequestDelegate(ListSupportedVmwareSoftwareVersionsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
