#if !NETSTANDARD13
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Paginators for the IoTWireless service
    ///</summary>
    public interface IIoTWirelessPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDestinations operation
        ///</summary>
        IListDestinationsPaginator ListDestinations(ListDestinationsRequest request);

        /// <summary>
        /// Paginator for ListDeviceProfiles operation
        ///</summary>
        IListDeviceProfilesPaginator ListDeviceProfiles(ListDeviceProfilesRequest request);

        /// <summary>
        /// Paginator for ListServiceProfiles operation
        ///</summary>
        IListServiceProfilesPaginator ListServiceProfiles(ListServiceProfilesRequest request);

        /// <summary>
        /// Paginator for ListWirelessDevices operation
        ///</summary>
        IListWirelessDevicesPaginator ListWirelessDevices(ListWirelessDevicesRequest request);

        /// <summary>
        /// Paginator for ListWirelessGateways operation
        ///</summary>
        IListWirelessGatewaysPaginator ListWirelessGateways(ListWirelessGatewaysRequest request);
    }
}
#endif