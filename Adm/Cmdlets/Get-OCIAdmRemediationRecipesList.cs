/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20220421
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.AdmService.Requests;
using Oci.AdmService.Responses;
using Oci.AdmService.Models;
using Oci.Common.Model;

namespace Oci.AdmService.Cmdlets
{
    [Cmdlet("Get", "OCIAdmRemediationRecipesList")]
    [OutputType(new System.Type[] { typeof(Oci.AdmService.Models.RemediationRecipeCollection), typeof(Oci.AdmService.Responses.ListRemediationRecipesResponse) })]
    public class GetOCIAdmRemediationRecipesList : OCIApplicationDependencyManagementCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the specified identifier. Required only if the compartmentId query parameter is not specified.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field used to sort Remediation Recipes. Only one sort order is allowed. Default order for _displayName_ is **ascending alphabetical order**. Default order for _lifecyleState_ is the following sequence: **CREATING, ACTIVE, UPDATING, INACTIVE, FAILED, DELETING, and DELETED**. Default order for _timeCreated_ is **descending**. Default order for _timeUpdated_ is **descending**. Default order for _type_ is the following sequence: **ADM**.")]
        public System.Nullable<Oci.AdmService.Requests.ListRemediationRecipesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only Remediation Recipes that match the specified lifecycleState.")]
        public System.Nullable<Oci.AdmService.Models.RemediationRecipe.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'ASC' or 'DESC'.")]
        public System.Nullable<Oci.AdmService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire display name given.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that belong to the specified compartment identifier. Required only if the id query param is not specified.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListRemediationRecipesRequest request;

            try
            {
                request = new ListRemediationRecipesRequest
                {
                    Id = Id,
                    SortBy = SortBy,
                    LifecycleState = LifecycleState,
                    SortOrder = SortOrder,
                    DisplayName = DisplayName,
                    Limit = Limit,
                    Page = Page,
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListRemediationRecipesResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.RemediationRecipeCollection, true);
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
            IEnumerable<ListRemediationRecipesResponse> DefaultRequest(ListRemediationRecipesRequest request) => Enumerable.Repeat(client.ListRemediationRecipes(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListRemediationRecipesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListRemediationRecipesResponse response;
        private delegate IEnumerable<ListRemediationRecipesResponse> RequestDelegate(ListRemediationRecipesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
