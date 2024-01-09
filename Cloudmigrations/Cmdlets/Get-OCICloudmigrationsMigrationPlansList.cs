/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220919
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.CloudmigrationsService.Requests;
using Oci.CloudmigrationsService.Responses;
using Oci.CloudmigrationsService.Models;
using Oci.Common.Model;

namespace Oci.CloudmigrationsService.Cmdlets
{
    [Cmdlet("Get", "OCICloudmigrationsMigrationPlansList")]
    [OutputType(new System.Type[] { typeof(Oci.CloudmigrationsService.Models.MigrationPlanCollection), typeof(Oci.CloudmigrationsService.Responses.ListMigrationPlansResponse) })]
    public class GetOCICloudmigrationsMigrationPlansList : OCIMigrationCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique migration identifier")]
        public string MigrationId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire given display name.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique migration plan identifier")]
        public string MigrationPlanId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of the previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The current state of the migration plan.")]
        public System.Nullable<Oci.CloudmigrationsService.Models.MigrationPlan.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.CloudmigrationsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order can be provided. The default order for 'timeCreated' is descending. The default order for 'displayName' is ascending.")]
        public System.Nullable<Oci.CloudmigrationsService.Requests.ListMigrationPlansRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListMigrationPlansRequest request;

            try
            {
                request = new ListMigrationPlansRequest
                {
                    CompartmentId = CompartmentId,
                    MigrationId = MigrationId,
                    DisplayName = DisplayName,
                    MigrationPlanId = MigrationPlanId,
                    Limit = Limit,
                    Page = Page,
                    LifecycleState = LifecycleState,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListMigrationPlansResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.MigrationPlanCollection, true);
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
            IEnumerable<ListMigrationPlansResponse> DefaultRequest(ListMigrationPlansRequest request) => Enumerable.Repeat(client.ListMigrationPlans(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListMigrationPlansResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListMigrationPlansResponse response;
        private delegate IEnumerable<ListMigrationPlansResponse> RequestDelegate(ListMigrationPlansRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
