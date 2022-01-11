/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210610
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.JmsService.Requests;
using Oci.JmsService.Responses;
using Oci.JmsService.Models;

namespace Oci.JmsService.Cmdlets
{
    [Cmdlet("Invoke", "OCIJmsSummarizeInstallationUsage")]
    [OutputType(new System.Type[] { typeof(Oci.JmsService.Models.InstallationUsageCollection), typeof(Oci.JmsService.Responses.SummarizeInstallationUsageResponse) })]
    public class InvokeOCIJmsSummarizeInstallationUsage : OCIJavaManagementServiceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Fleet.")]
        public string FleetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The vendor of the related Java Runtime.")]
        public string JreVendor { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The distribution of the related Java Runtime.")]
        public string JreDistribution { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version of the related Java Runtime.")]
        public string JreVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The file system path of the installation.")]
        public string InstallationPath { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Fleet-unique identifier of the related application.")]
        public string ApplicationId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The Fleet-unique identifier of the related managed instance.")]
        public string ManagedInstanceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Additional fields to include into the returned model on top of the required ones. This parameter can also include 'approximateApplicationCount' and 'approximateManagedInstanceCount'. For example 'approximateApplicationCount,approximateManagedInstanceCount'.")]
        public System.Collections.Generic.List<Oci.JmsService.Models.SummarizeInstallationUsageFields> Fields { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The start of the time period during which resources are searched (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The end of the time period during which resources are searched (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.")]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. The token is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.JmsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort installation views. Only one sort order may be provided. Default order for _timeFirstSeen_, _timeLastSeen_, and _jreVersion_, _approximateApplicationCount_ and _approximateManagedInstanceCount_  is **descending**. Default order for _jreDistribution_ and _jreVendor_ is **ascending**. If no value is specified _timeLastSeen_ is default.")]
        public System.Nullable<Oci.JmsService.Models.InstallationSortBy> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The operating system type.")]
        public System.Collections.Generic.List<Oci.JmsService.Models.OsFamily> OsFamily { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            SummarizeInstallationUsageRequest request;

            try
            {
                request = new SummarizeInstallationUsageRequest
                {
                    FleetId = FleetId,
                    JreVendor = JreVendor,
                    JreDistribution = JreDistribution,
                    JreVersion = JreVersion,
                    InstallationPath = InstallationPath,
                    ApplicationId = ApplicationId,
                    ManagedInstanceId = ManagedInstanceId,
                    Fields = Fields,
                    TimeStart = TimeStart,
                    TimeEnd = TimeEnd,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId,
                    OsFamily = OsFamily
                };

                response = client.SummarizeInstallationUsage(request).GetAwaiter().GetResult();
                WriteOutput(response, response.InstallationUsageCollection);
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

        private SummarizeInstallationUsageResponse response;
    }
}
