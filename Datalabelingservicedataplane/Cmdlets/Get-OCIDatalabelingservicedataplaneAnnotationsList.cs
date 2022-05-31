/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatalabelingservicedataplaneService.Requests;
using Oci.DatalabelingservicedataplaneService.Responses;
using Oci.DatalabelingservicedataplaneService.Models;
using Oci.Common.Model;

namespace Oci.DatalabelingservicedataplaneService.Cmdlets
{
    [Cmdlet("Get", "OCIDatalabelingservicedataplaneAnnotationsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatalabelingservicedataplaneService.Models.AnnotationCollection), typeof(Oci.DatalabelingservicedataplaneService.Responses.ListAnnotationsResponse) })]
    public class GetOCIDatalabelingservicedataplaneAnnotationsList : OCIDataLabelingCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filter the results by the OCID of the dataset.")]
        public string DatasetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources whose lifecycleState matches the given lifecycleState.")]
        public System.Nullable<Oci.DatalabelingservicedataplaneService.Models.Annotation.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique OCID identifier.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the principal which updated the annotation.")]
        public string UpdatedBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the record annotated.")]
        public string RecordId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The date and time the resource was created, in the timestamp format defined by RFC3339.")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The date and time the resource was created, in the timestamp format defined by RFC3339.")]
        public System.Nullable<System.DateTime> TimeCreatedLessThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.DatalabelingservicedataplaneService.Models.SortOrders> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. The default order for timeCreated is descending. If no value is specified timeCreated is used by default.")]
        public System.Nullable<Oci.DatalabelingservicedataplaneService.Requests.ListAnnotationsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAnnotationsRequest request;

            try
            {
                request = new ListAnnotationsRequest
                {
                    CompartmentId = CompartmentId,
                    DatasetId = DatasetId,
                    LifecycleState = LifecycleState,
                    Id = Id,
                    UpdatedBy = UpdatedBy,
                    RecordId = RecordId,
                    TimeCreatedGreaterThanOrEqualTo = TimeCreatedGreaterThanOrEqualTo,
                    TimeCreatedLessThanOrEqualTo = TimeCreatedLessThanOrEqualTo,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListAnnotationsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.AnnotationCollection, true);
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
            IEnumerable<ListAnnotationsResponse> DefaultRequest(ListAnnotationsRequest request) => Enumerable.Repeat(client.ListAnnotations(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListAnnotationsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListAnnotationsResponse response;
        private delegate IEnumerable<ListAnnotationsResponse> RequestDelegate(ListAnnotationsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
