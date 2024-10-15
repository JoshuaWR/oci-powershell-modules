/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;
using Oci.DnsService.Models;
using Oci.Common.Model;

namespace Oci.DnsService.Cmdlets
{
    [Cmdlet("Get", "OCIDnsZonesList")]
    [OutputType(new System.Type[] { typeof(Oci.DnsService.Models.ZoneSummary), typeof(Oci.DnsService.Responses.ListZonesResponse) })]
    public class GetOCIDnsZonesList : OCIDnsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment the resource belongs to.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a page of the collection.", ParameterSetName = LimitSet)]
        public System.Nullable<long> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A case-sensitive filter for zone names. Will match any zone with a name that equals the provided value.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search by zone name. Will match any zone whose name (case-insensitive) contains the provided value.")]
        public string NameContains { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search by zone type, `PRIMARY` or `SECONDARY`. Will match any zone whose type equals the provided value.")]
        public System.Nullable<Oci.DnsService.Requests.ListZonesRequest.ZoneTypeEnum> ZoneType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states all returned resources were created on or after the indicated time.")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states all returned resources were created before the indicated time.")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The state of a resource.")]
        public System.Nullable<Oci.DnsService.Requests.ListZonesRequest.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field by which to sort zones.")]
        public System.Nullable<Oci.DnsService.Requests.ListZonesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The order to sort the resources.")]
        public System.Nullable<Oci.DnsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.")]
        public System.Nullable<Oci.DnsService.Models.Scope> Scope { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the view the resource is associated with.")]
        public string ViewId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search for zones that are associated with a TSIG key.")]
        public string TsigKeyId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search for zones that have the given `DnssecState`.")]
        public System.Nullable<Oci.DnsService.Models.ZoneDnssecState> DnssecState { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListZonesRequest request;

            try
            {
                request = new ListZonesRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    Name = Name,
                    NameContains = NameContains,
                    ZoneType = ZoneType,
                    TimeCreatedGreaterThanOrEqualTo = TimeCreatedGreaterThanOrEqualTo,
                    TimeCreatedLessThan = TimeCreatedLessThan,
                    LifecycleState = LifecycleState,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    Scope = Scope,
                    ViewId = ViewId,
                    TsigKeyId = TsigKeyId,
                    DnssecState = DnssecState
                };
                IEnumerable<ListZonesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
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
            IEnumerable<ListZonesResponse> DefaultRequest(ListZonesRequest request) => Enumerable.Repeat(client.ListZones(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListZonesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListZonesResponse response;
        private delegate IEnumerable<ListZonesResponse> RequestDelegate(ListZonesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
