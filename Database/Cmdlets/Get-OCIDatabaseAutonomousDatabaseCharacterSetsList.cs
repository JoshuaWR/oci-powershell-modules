/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;
using Oci.Common.Model;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabaseAutonomousDatabaseCharacterSetsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.AutonomousDatabaseCharacterSets), typeof(Oci.DatabaseService.Responses.ListAutonomousDatabaseCharacterSetsResponse) })]
    public class GetOCIDatabaseAutonomousDatabaseCharacterSetsList : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies whether this request is for an Autonomous Database Serverless instance. By default, this request will be for Autonomous Database on Dedicated Exadata Infrastructure.")]
        public System.Nullable<bool> IsShared { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies if the request is for an Autonomous Database Dedicated instance. The default request is for an Autonomous Database Dedicated instance.")]
        public System.Nullable<bool> IsDedicated { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies whether this request pertains to database character sets or national character sets.")]
        public System.Nullable<Oci.DatabaseService.Requests.ListAutonomousDatabaseCharacterSetsRequest.CharacterSetTypeEnum> CharacterSetType { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListAutonomousDatabaseCharacterSetsRequest request;

            try
            {
                request = new ListAutonomousDatabaseCharacterSetsRequest
                {
                    OpcRequestId = OpcRequestId,
                    IsShared = IsShared,
                    IsDedicated = IsDedicated,
                    CharacterSetType = CharacterSetType
                };

                response = client.ListAutonomousDatabaseCharacterSets(request).GetAwaiter().GetResult();
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

        private ListAutonomousDatabaseCharacterSetsResponse response;
    }
}
