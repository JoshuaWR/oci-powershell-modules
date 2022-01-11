/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;
using Oci.DnsService.Models;

namespace Oci.DnsService.Cmdlets
{
    [Cmdlet("New", "OCIDnsZone")]
    [OutputType(new System.Type[] { typeof(Oci.DnsService.Models.Zone), typeof(Oci.DnsService.Responses.CreateZoneResponse) })]
    public class NewOCIDnsZone : OCIDnsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for creating a new zone. This parameter also accepts subtypes <Oci.DnsService.Models.CreateZoneDetails>, <Oci.DnsService.Models.CreateMigratedDynectZoneDetails> of type <Oci.DnsService.Models.CreateZoneBaseDetails>.")]
        public CreateZoneBaseDetails CreateZoneDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment the resource belongs to.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.")]
        public System.Nullable<Oci.DnsService.Models.Scope> Scope { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the view the resource is associated with.")]
        public string ViewId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateZoneRequest request;

            try
            {
                request = new CreateZoneRequest
                {
                    CreateZoneDetails = CreateZoneDetails,
                    OpcRequestId = OpcRequestId,
                    CompartmentId = CompartmentId,
                    Scope = Scope,
                    ViewId = ViewId
                };

                response = client.CreateZone(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Zone);
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

        private CreateZoneResponse response;
    }
}
