/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;
using Oci.IdentityService.Models;
using Oci.Common.Model;

namespace Oci.IdentityService.Cmdlets
{
    [Cmdlet("Get", "OCIIdentityAllowedDomainLicenseTypesList")]
    [OutputType(new System.Type[] { typeof(Oci.IdentityService.Models.AllowedDomainLicenseTypeSummary), typeof(Oci.IdentityService.Responses.ListAllowedDomainLicenseTypesResponse) })]
    public class GetOCIIdentityAllowedDomainLicenseTypesList : OCIIdentityCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The license type of the identity domain.")]
        public string CurrentLicenseTypeName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAllowedDomainLicenseTypesRequest request;

            try
            {
                request = new ListAllowedDomainLicenseTypesRequest
                {
                    CurrentLicenseTypeName = CurrentLicenseTypeName,
                    OpcRequestId = OpcRequestId
                };

                response = client.ListAllowedDomainLicenseTypes(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Items, true);
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

        private ListAllowedDomainLicenseTypesResponse response;
    }
}
