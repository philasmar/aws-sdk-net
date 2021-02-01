using System;
using System.Collections.Generic;

using Amazon.Lambda.Model;

namespace Amazon.Lambda
{
    /// <summary>
    /// Interface for accessing Lambda
    ///
    /// 
    /// </summary>
    public partial interface IAmazonLambda : IDisposable
    {
#if BCL
        /// <summary>
        /// Submits an invocation request to Lambda. Upon receiving the request, Lambda executes
        /// the specified cloud function asynchronously. To see the logs generated by the cloud
        /// function execution, see the CloudWatch logs console.
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeAsync</code> action.
        /// </para>
        /// <para>
        /// The InvokeArgs will be set to an empty json document.
        /// </para>
        /// </summary>
        /// <param name="functionName">The cloud function to invoke.</param>
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="InvalidRequestContentException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ServiceException"/>
        InvokeAsyncResponse InvokeAsync(string functionName);

        /// <summary>
        /// Submits an invocation request to Lambda. Upon receiving the request, Lambda executes
        /// the specified cloud function asynchronously. To see the logs generated by the cloud
        /// function execution, see the CloudWatch logs console.
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeAsync</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The cloud function to invoke.</param>
        /// <param name="invokeArgs">A Json document that will be passed to the cloud function.</param>
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="InvalidRequestContentException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ServiceException"/>
        InvokeAsyncResponse InvokeAsync(string functionName, string invokeArgs);
#endif
    }
}