/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210216
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.RecoveryService.Requests;
using Oci.RecoveryService.Responses;
using Oci.RecoveryService.Models;
using Oci.Common.Model;

namespace Oci.RecoveryService.Cmdlets
{
    [Cmdlet("Get", "OCIRecoveryServiceSubnetsList")]
    [OutputType(new System.Type[] { typeof(Oci.RecoveryService.Models.RecoveryServiceSubnetCollection), typeof(Oci.RecoveryService.Responses.ListRecoveryServiceSubnetsResponse) })]
    public class GetOCIRecoveryServiceSubnetsList : OCIDatabaseRecoveryCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The compartment OCID.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resources that match the specified lifecycle state. Allowed values are:   - CREATING   - UPDATING   - ACTIVE   - DELETING   - DELETED   - FAILED")]
        public System.Nullable<Oci.RecoveryService.Models.LifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire 'displayname' given.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The recovery service subnet OCID.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the virtual cloud network (VCN) associated with the recovery service subnet.")]
        public string VcnId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return per page.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (ASC) or descending (DESC). Allowed values are:   - ASC   - DESC")]
        public System.Nullable<Oci.RecoveryService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order (sortOrder). Default order for TIMECREATED is descending. Default order for DISPLAYNAME is ascending. If you do not specify a value, then TIMECREATED is used as the default sort order. Allowed values are:   - TIMECREATED   - DISPLAYNAME")]
        public System.Nullable<Oci.RecoveryService.Requests.ListRecoveryServiceSubnetsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListRecoveryServiceSubnetsRequest request;

            try
            {
                request = new ListRecoveryServiceSubnetsRequest
                {
                    CompartmentId = CompartmentId,
                    LifecycleState = LifecycleState,
                    DisplayName = DisplayName,
                    Id = Id,
                    VcnId = VcnId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListRecoveryServiceSubnetsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.RecoveryServiceSubnetCollection, true);
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
            IEnumerable<ListRecoveryServiceSubnetsResponse> DefaultRequest(ListRecoveryServiceSubnetsRequest request) => Enumerable.Repeat(client.ListRecoveryServiceSubnets(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListRecoveryServiceSubnetsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListRecoveryServiceSubnetsResponse response;
        private delegate IEnumerable<ListRecoveryServiceSubnetsResponse> RequestDelegate(ListRecoveryServiceSubnetsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
