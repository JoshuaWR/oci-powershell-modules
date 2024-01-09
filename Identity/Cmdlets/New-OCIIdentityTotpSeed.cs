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
    [Cmdlet("New", "OCIIdentityTotpSeed")]
    [OutputType(new System.Type[] { typeof(Oci.IdentityService.Models.MfaTotpDevice), typeof(Oci.IdentityService.Responses.GenerateTotpSeedResponse) })]
    public class NewOCIIdentityTotpSeed : OCIIdentityCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the user.")]
        public string UserId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the MFA TOTP device.")]
        public string MfaTotpDeviceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource.  The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GenerateTotpSeedRequest request;

            try
            {
                request = new GenerateTotpSeedRequest
                {
                    UserId = UserId,
                    MfaTotpDeviceId = MfaTotpDeviceId,
                    IfMatch = IfMatch
                };

                response = client.GenerateTotpSeed(request).GetAwaiter().GetResult();
                WriteOutput(response, response.MfaTotpDevice);
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

        private GenerateTotpSeedResponse response;
    }
}
