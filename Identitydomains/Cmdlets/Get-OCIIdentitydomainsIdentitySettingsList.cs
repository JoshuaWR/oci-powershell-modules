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
    [Cmdlet("Get", "OCIIdentitydomainsIdentitySettingsList")]
    [OutputType(new System.Type[] { typeof(Oci.IdentitydomainsService.Models.IdentitySettings), typeof(Oci.IdentitydomainsService.Responses.ListIdentitySettingsResponse) })]
    public class GetOCIIdentitydomainsIdentitySettingsList : OCIIdentityDomainsCmdlet
    {
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
            ListIdentitySettingsRequest request;

            try
            {
                request = new ListIdentitySettingsRequest
                {
                    Attributes = Attributes,
                    AttributeSets = AttributeSets,
                    Authorization = Authorization,
                    ResourceTypeSchemaVersion = ResourceTypeSchemaVersion,
                    OpcRetryToken = OpcRetryToken,
                    Page = Page,
                    Limit = Limit
                };

                response = client.ListIdentitySettings(request).GetAwaiter().GetResult();
                WriteOutput(response, response.IdentitySettings);
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

        private ListIdentitySettingsResponse response;
    }
}
