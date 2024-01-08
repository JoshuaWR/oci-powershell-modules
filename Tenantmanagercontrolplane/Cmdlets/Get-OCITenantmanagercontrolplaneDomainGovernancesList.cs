/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20230401
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.TenantmanagercontrolplaneService.Requests;
using Oci.TenantmanagercontrolplaneService.Responses;
using Oci.TenantmanagercontrolplaneService.Models;
using Oci.Common.Model;

namespace Oci.TenantmanagercontrolplaneService.Cmdlets
{
    [Cmdlet("Get", "OCITenantmanagercontrolplaneDomainGovernancesList")]
    [OutputType(new System.Type[] { typeof(Oci.TenantmanagercontrolplaneService.Models.DomainGovernanceCollection), typeof(Oci.TenantmanagercontrolplaneService.Responses.ListDomainGovernancesResponse) })]
    public class GetOCITenantmanagercontrolplaneDomainGovernancesList : OCIDomainGovernanceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The domain OCID.")]
        public string DomainId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The domain governance OCID.")]
        public string DomainGovernanceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The lifecycle state of the resource.")]
        public System.Nullable<Oci.TenantmanagercontrolplaneService.Models.LifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that exactly match the name given.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order can be provided. * The default order for timeCreated is descending. * The default order for displayName is ascending. * If no value is specified, timeCreated is the default.")]
        public System.Nullable<Oci.TenantmanagercontrolplaneService.Requests.ListDomainGovernancesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, whether 'asc' or 'desc'.")]
        public System.Nullable<Oci.TenantmanagercontrolplaneService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListDomainGovernancesRequest request;

            try
            {
                request = new ListDomainGovernancesRequest
                {
                    CompartmentId = CompartmentId,
                    DomainId = DomainId,
                    DomainGovernanceId = DomainGovernanceId,
                    LifecycleState = LifecycleState,
                    Name = Name,
                    OpcRequestId = OpcRequestId,
                    Page = Page,
                    Limit = Limit,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };
                IEnumerable<ListDomainGovernancesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.DomainGovernanceCollection, true);
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
            IEnumerable<ListDomainGovernancesResponse> DefaultRequest(ListDomainGovernancesRequest request) => Enumerable.Repeat(client.ListDomainGovernances(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListDomainGovernancesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListDomainGovernancesResponse response;
        private delegate IEnumerable<ListDomainGovernancesResponse> RequestDelegate(ListDomainGovernancesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
