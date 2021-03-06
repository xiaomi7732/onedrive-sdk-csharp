// ------------------------------------------------------------------------------
//  Copyright (c) 2015 Microsoft Corporation
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    /// <summary>
    /// The type ThumbnailSetRequest.
    /// </summary>
    public partial class ThumbnailSetRequest : BaseRequest, IThumbnailSetRequest
    {
        /// <summary>
        /// Constructs a new ThumbnailSetRequest.
        /// </summary>
        /// <param name="requestUrl">The request URL.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query option name value pairs for the request.</param>
        public ThumbnailSetRequest(
            string requestUrl,
            IBaseClient client,
            IList<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ThumbnailSet using PUT.
        /// </summary>
        /// <param name="thumbnailSet">The ThumbnailSet to create.</param>
        /// <returns>The created ThumbnailSet.</returns>
        public async Task<ThumbnailSet> CreateAsync(ThumbnailSet thumbnailSet)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var entity = await this.SendAsync<ThumbnailSet>(thumbnailSet);
            this.InitializeCollectionProperties(entity);
            return entity;
        }

        /// <summary>
        /// Deletes the specified ThumbnailSet.
        /// </summary>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync()
        {
            this.Method = "DELETE";
            await this.SendAsync<ThumbnailSet>(null);
        }

        /// <summary>
        /// Gets the ThumbnailSet.
        /// </summary>
        /// <returns>The ThumbnailSet.</returns>
        public async Task<ThumbnailSet> GetAsync()
        {
            this.Method = "GET";
            var entity = await this.SendAsync<ThumbnailSet>(null);
            this.InitializeCollectionProperties(entity);
            return entity;
        }

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH.
        /// </summary>
        /// <param name="thumbnailSet">The ThumbnailSet to update.</param>
        /// <returns>The updated ThumbnailSet.</returns>
        public async Task<ThumbnailSet> UpdateAsync(ThumbnailSet thumbnailSet)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var entity = await this.SendAsync<ThumbnailSet>(thumbnailSet);
            this.InitializeCollectionProperties(entity);
            return entity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IThumbnailSetRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IThumbnailSetRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
        
        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IThumbnailSetRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="thumbnailSet">The <see cref="ThumbnailSet"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ThumbnailSet thumbnailSet)
        {
        
        }
    }
}
