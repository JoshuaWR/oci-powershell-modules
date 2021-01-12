/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190901
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.AuditService.Requests;
using Oci.AuditService.Responses;
using Oci.AuditService.Models;

namespace Oci.AuditService.Cmdlets
{
    [Cmdlet("Get", "OCIAuditEventsList")]
    [OutputType(new System.Type[] { typeof(Oci.AuditService.Models.AuditEvent), typeof(Oci.AuditService.Responses.ListEventsResponse) })]
    public class GetOCIAuditEventsList : OCIAuditCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Returns events that were processed at or after this start date and time, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.

For example, a start value of `2017-01-15T11:30:00Z` will retrieve a list of all events processed since 30 minutes after the 11th hour of January 15, 2017, in Coordinated Universal Time (UTC). You can specify a value with granularity to the minute. Seconds (and milliseconds, if included) must be set to `0`.")]
        public System.Nullable<System.DateTime> StartTime { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Returns events that were processed before this end date and time, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.

For example, a start value of `2017-01-01T00:00:00Z` and an end value of `2017-01-02T00:00:00Z` will retrieve a list of all events processed on January 1, 2017. Similarly, a start value of `2017-01-01T00:00:00Z` and an end value of `2017-02-01T00:00:00Z` will result in a list of all events processed between January 1, 2017 and January 31, 2017. You can specify a value with granularity to the minute. Seconds (and milliseconds, if included) must be set to `0`.")]
        public System.Nullable<System.DateTime> EndTime { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call. For important details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListEventsRequest request;

            try
            {
                request = new ListEventsRequest
                {
                    CompartmentId = CompartmentId,
                    StartTime = StartTime,
                    EndTime = EndTime,
                    Page = Page,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListEventsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
                }
                FinishProcessing(response);
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
            IEnumerable<ListEventsResponse> DefaultRequest(ListEventsRequest request) => Enumerable.Repeat(client.ListEvents(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListEventsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListEventsResponse response;
        private delegate IEnumerable<ListEventsResponse> RequestDelegate(ListEventsRequest request);
        private const string AllPageSet = "AllPages";
    }
}
