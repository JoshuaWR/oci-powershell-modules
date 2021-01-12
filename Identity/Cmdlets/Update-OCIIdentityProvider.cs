/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;
using Oci.IdentityService.Models;

namespace Oci.IdentityService.Cmdlets
{
    [Cmdlet("Update", "OCIIdentityProvider")]
    [OutputType(new System.Type[] { typeof(Oci.IdentityService.Models.IdentityProvider), typeof(Oci.IdentityService.Responses.UpdateIdentityProviderResponse) })]
    public class UpdateOCIIdentityProvider : OCIIdentityCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the identity provider.")]
        public string IdentityProviderId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Request object for updating a identity provider. This parameter also accepts subtype <Oci.IdentityService.Models.UpdateSaml2IdentityProviderDetails> of type <Oci.IdentityService.Models.UpdateIdentityProviderDetails>.")]
        public UpdateIdentityProviderDetails UpdateIdentityProviderDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateIdentityProviderRequest request;

            try
            {
                request = new UpdateIdentityProviderRequest
                {
                    IdentityProviderId = IdentityProviderId,
                    UpdateIdentityProviderDetails = UpdateIdentityProviderDetails,
                    IfMatch = IfMatch
                };

                response = client.UpdateIdentityProvider(request).GetAwaiter().GetResult();
                WriteOutput(response, response.IdentityProvider);
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

        private UpdateIdentityProviderResponse response;
    }
}
