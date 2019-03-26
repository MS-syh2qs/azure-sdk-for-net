// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingManagementClient.
    /// </summary>
    public static partial class BillingManagementClientExtensions
    {
            /// <summary>
            /// Lists the transactions by billingProfileName for given start date and end
            /// date.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='startDate'>
            /// Start date
            /// </param>
            /// <param name='endDate'>
            /// End date
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by transaction kind. The filter supports 'eq', 'lt',
            /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or
            /// 'not'. Tag filter is a key value pair string where key and value is
            /// separated by a colon (:).
            /// </param>
            public static TransactionsListResult TransactionsByBillingProfile(this IBillingManagementClient operations, string billingAccountName, string billingProfileName, string startDate, string endDate, string filter = default(string))
            {
                return operations.TransactionsByBillingProfileAsync(billingAccountName, billingProfileName, startDate, endDate, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transactions by billingProfileName for given start date and end
            /// date.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='startDate'>
            /// Start date
            /// </param>
            /// <param name='endDate'>
            /// End date
            /// </param>
            /// <param name='filter'>
            /// May be used to filter by transaction kind. The filter supports 'eq', 'lt',
            /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or
            /// 'not'. Tag filter is a key value pair string where key and value is
            /// separated by a colon (:).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransactionsListResult> TransactionsByBillingProfileAsync(this IBillingManagementClient operations, string billingAccountName, string billingProfileName, string startDate, string endDate, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TransactionsByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, startDate, endDate, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel product by product id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='productName'>
            /// Invoice Id.
            /// </param>
            /// <param name='body'>
            /// Update auto renew request parameters.
            /// </param>
            public static UpdateAutoRenewOperationSummary UpdateAutoRenewForBillingAccount(this IBillingManagementClient operations, string billingAccountName, string productName, UpdateAutoRenewRequest body)
            {
                return operations.UpdateAutoRenewForBillingAccountAsync(billingAccountName, productName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel product by product id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='productName'>
            /// Invoice Id.
            /// </param>
            /// <param name='body'>
            /// Update auto renew request parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpdateAutoRenewOperationSummary> UpdateAutoRenewForBillingAccountAsync(this IBillingManagementClient operations, string billingAccountName, string productName, UpdateAutoRenewRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAutoRenewForBillingAccountWithHttpMessagesAsync(billingAccountName, productName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel auto renew for product by product id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='productName'>
            /// Invoice Id.
            /// </param>
            /// <param name='body'>
            /// Update auto renew request parameters.
            /// </param>
            public static UpdateAutoRenewOperationSummary UpdateAutoRenewForInvoiceSection(this IBillingManagementClient operations, string billingAccountName, string invoiceSectionName, string productName, UpdateAutoRenewRequest body)
            {
                return operations.UpdateAutoRenewForInvoiceSectionAsync(billingAccountName, invoiceSectionName, productName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel auto renew for product by product id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='productName'>
            /// Invoice Id.
            /// </param>
            /// <param name='body'>
            /// Update auto renew request parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpdateAutoRenewOperationSummary> UpdateAutoRenewForInvoiceSectionAsync(this IBillingManagementClient operations, string billingAccountName, string invoiceSectionName, string productName, UpdateAutoRenewRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateAutoRenewForInvoiceSectionWithHttpMessagesAsync(billingAccountName, invoiceSectionName, productName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
