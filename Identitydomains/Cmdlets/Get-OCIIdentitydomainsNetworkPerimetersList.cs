/*
 * NOTE: Generated using OracleSDKGenerator, API Version: v1
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.IdentitydomainsService.Requests;
using Oci.IdentitydomainsService.Responses;
using Oci.IdentitydomainsService.Models;
using Oci.Common.Model;

namespace Oci.IdentitydomainsService.Cmdlets
{
    [Cmdlet("Get", "OCIIdentitydomainsNetworkPerimetersList")]
    [OutputType(new System.Type[] { typeof(Oci.IdentitydomainsService.Models.NetworkPerimeters), typeof(Oci.IdentitydomainsService.Responses.ListNetworkPerimetersResponse) })]
    public class GetOCIIdentitydomainsNetworkPerimetersList : OCIIdentityDomainsCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"OPTIONAL. The filter string that is used to request a subset of resources. The filter string MUST be a valid filter expression. See the Filtering section of the SCIM specification for more information (Section 3.4.2.2). The string should contain at least one condition that each item must match in order to be returned in the search results. Each condition specifies an attribute, an operator, and a value. Conditions within a filter can be connected by logical operators (such as AND and OR). Sets of conditions can be grouped together using parentheses.")]
        public string Filter { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"OPTIONAL. A string that indicates the attribute whose value SHALL be used to order the returned responses. The sortBy attribute MUST be in standard attribute notation form. See the Attribute Notation section of the SCIM specification for more information (Section 3.10). Also, see the Sorting section of the SCIM specification for more information (Section 3.4.2.3).")]
        public string SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A string that indicates the order in which the sortBy parameter is applied. Allowed values are 'ascending' and 'descending'. See ([Sorting Section](https://tools.ietf.org/html/draft-ietf-scim-api-19#section-3.4.2.3)). OPTIONAL.")]
        public System.Nullable<Oci.IdentitydomainsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"OPTIONAL. An integer that indicates the 1-based index of the first query result. See the Pagination section of the SCIM specification for more information. (Section 3.4.2.4). The number of results pages to return. The first page is 1. Specify 2 to access the second page of results, and so on.")]
        public System.Nullable<int> StartIndex { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"OPTIONAL. An integer that indicates the desired maximum number of query results per page. 1000 is the largest value that you can use. See the Pagination section of the System for Cross-Domain Identity Management Protocol specification for more information. (Section 3.4.2.4).")]
        public System.Nullable<int> Count { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A comma-delimited string that specifies the names of resource attributes that should be returned in the response. By default, a response that contains resource attributes contains only attributes that are defined in the schema for that resource type as returned=always or returned=default. An attribute that is defined as returned=request is returned in a response only if the request specifies its name in the value of this query parameter. If a request specifies this query parameter, the response contains the attributes that this query parameter specifies, as well as any attribute that is defined as returned=always.")]
        public string Attributes { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A multi-valued list of strings indicating the return type of attribute definition. The specified set of attributes can be fetched by the return type of the attribute. One or more values can be given together to fetch more than one group of attributes. If 'attributes' query parameter is also available, union of the two is fetched. Valid values - all, always, never, request, default. Values are case-insensitive.")]
        public System.Collections.Generic.List<Oci.IdentitydomainsService.Models.AttributeSets> AttributeSets { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Authorization field value consists of credentials containing the authentication information of the user agent for the realm of the resource being requested.")]
        public string Authorization { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"An endpoint-specific schema version number to use in the Request. Allowed version values are Earliest Version or Latest Version as specified in each REST API endpoint description, or any sequential number inbetween. All schema attributes/body parameters are a part of version 1. After version 1, any attributes added or deprecated will be tagged with the version that they were added to or deprecated in. If no version is provided, the latest schema version is returned.")]
        public string ResourceTypeSchemaVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token you supply to uniquely identify the request and provide idempotency if the request is retried. Idempotency tokens expire after 24 hours.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous 'List' call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated 'List' call.")]
        public System.Nullable<int> Limit { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListNetworkPerimetersRequest request;

            try
            {
                request = new ListNetworkPerimetersRequest
                {
                    Filter = Filter,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    StartIndex = StartIndex,
                    Count = Count,
                    Attributes = Attributes,
                    AttributeSets = AttributeSets,
                    Authorization = Authorization,
                    ResourceTypeSchemaVersion = ResourceTypeSchemaVersion,
                    OpcRetryToken = OpcRetryToken,
                    Page = Page,
                    Limit = Limit
                };

                response = client.ListNetworkPerimeters(request).GetAwaiter().GetResult();
                WriteOutput(response, response.NetworkPerimeters);
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

        private ListNetworkPerimetersResponse response;
    }
}
