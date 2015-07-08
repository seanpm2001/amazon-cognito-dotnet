//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using System.Globalization;
namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// Metadata information representing a dataset
    /// </summary>
    public sealed class DatasetMetadata
    {
        private string _datasetName;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedBy;
        private long _storageSizeBytes;
        private long _recordCount;

        /// <summary>
        /// Non empty String name of the dataset
        /// </summary>
        /// <value>The name of the dataset.</value>
        public string DatasetName
        {
            get { return this._datasetName; }
        }

        /// <summary>
        /// Date when the dataset is created
        /// </summary>
        /// <value>The creation date.</value>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
        }

        /// <summary>
        /// Date when the dataset is last modified
        /// </summary>
        /// <value>The last modified date.</value>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
        }

        /// <summary>
        /// The device that made the last modification
        /// </summary>
        /// <value>The last modified by.</value>
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
        }

        /// <summary>
        /// The storage size in bytes of the dataset
        /// </summary>
        /// <value>The storage size bytes.</value>
        public long StorageSizeBytes
        {
            get { return this._storageSizeBytes; }
        }

        /// <summary>
        /// Number of records in the dataset
        /// </summary>
        /// <value>The record count.</value>
        public long RecordCount
        {
            get { return this._recordCount; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="creationDate"></param>
        /// <param name="lastModifiedDate"></param>
        /// <param name="lastModifiedBy"></param>
        /// <param name="storageSizeBytes"></param>
        /// <param name="recordCount"></param>
        public DatasetMetadata(string datasetName, DateTime? creationDate, DateTime? lastModifiedDate, string lastModifiedBy, long storageSizeBytes, long recordCount)
        {
            this._datasetName = datasetName;
            this._creationDate = creationDate;
            this._lastModifiedDate = lastModifiedDate;
            this._lastModifiedBy = lastModifiedBy;
            this._storageSizeBytes = storageSizeBytes;
            this._recordCount = recordCount;
        }


        /// <summary>
        /// A string representation of DatasetMetadata
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "DatasetName:[{0}], CreationDate:[{1}], LastModifiedDate:[{2}], LastModifiedBy:[{3}], StorageSizeBytes:[{4}], RecordCount:[{5}]",
                DatasetName, CreationDate, LastModifiedDate, LastModifiedBy, StorageSizeBytes, RecordCount);
        }
    }
}

