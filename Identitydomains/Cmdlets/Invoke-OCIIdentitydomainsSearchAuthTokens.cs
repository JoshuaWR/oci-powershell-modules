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
    [Cmdlet("Invoke", "OCIIdentitydomainsSearchAuthTokens")]
    [OutputType(new System.Type[] { typeof(Oci.IdentitydomainsService.Models.AuthTokens), typeof(Oci.IdentitydomainsService.Responses.SearchAuthTokensResponse) })]
    public class InvokeOCIIdentitydomainsSearchAuthTokens : OCIIdentityDomainsCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Authorization field value consists of credentials containing the authentication information of the user agent for the realm of the resource being requested.")]
        public string Authorization { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"An endpoint-specific schema version number to use in the Request. Allowed version values are Earliest Version or Latest Version as specified in each REST API endpoint description, or any sequential number inbetween. All schema attributes/body parameters are a part of version 1. After version 1, any attributes added or deprecated will be tagged with the version that they were added to or deprecated in. If no version is provided, the latest schema version is returned.")]
        public string ResourceTypeSchemaVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Parameters for searching AuthTokens")]
        public AuthTokenSearchRequest AuthTokenSearchRequest { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token you supply to uniquely identify the request and provide idempotency if the request is retried. Idempotency tokens expire after 24 hours.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous 'List' call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated 'List' call.")]
        public System.Nullable<int> Limit { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            SearchAuthTokensRequest request;

            try
            {
                request = new SearchAuthTokensRequest
                {
                    Authorization = Authorization,
                    ResourceTypeSchemaVersion = ResourceTypeSchemaVersion,
                    AuthTokenSearchRequest = AuthTokenSearchRequest,
                    OpcRetryToken = OpcRetryToken,
                    Page = Page,
                    Limit = Limit
                };

                response = client.SearchAuthTokens(request).GetAwaiter().GetResult();
                WriteOutput(response, response.AuthTokens);
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

        private SearchAuthTokensResponse response;
    }
}
