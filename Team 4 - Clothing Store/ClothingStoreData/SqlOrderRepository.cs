using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ClothingStoreData
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly string connectionString;

        public SqlOrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Orders GetOrder(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Orders.GetOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("OrderID", id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateOrder(reader);
                }
            }
        }

        public Orders GetOrderId(string shipmentAddress)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Orders.GetOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Shipment Address", shipmentAddress);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateOrder(reader);
                }
            }
        }

        private Orders TranslateOrder(SqlDataReader reader)
        {
            var orderIdOrdinal = reader.GetOrdinal("OrderID");
            var memberIdOrdinal = reader.GetOrdinal("MemberID");
            var employeeIdOrdinal = reader.GetOrdinal("EmployeeID");
            var shipmentIdOrdinal = reader.GetOrdinal("ShipmentID");
            var orderDateOrdinal = reader.GetOrdinal("OrderDate");
            var shipmentAddressIdOrdinal = reader.GetOrdinal("Shipment Address");

            if (!reader.Read())
                return null;

            return new Orders(
               reader.GetInt32(orderIdOrdinal),
                   reader.GetInt32(memberIdOrdinal),
                   reader.GetInt32(employeeIdOrdinal),
                   reader.GetInt32(shipmentIdOrdinal),
                    reader.GetDateTimeOffset(orderDateOrdinal),
                     reader.GetString(shipmentAddressIdOrdinal));
        }

        private IReadOnlyList<Orders> TranslateOrders(SqlDataReader reader)
        {
            var orders = new List<Orders>();

            var orderIdOrdinal = reader.GetOrdinal("OrderID");
            var memberIdOrdinal = reader.GetOrdinal("MemberID");
            var employeeIdOrdinal = reader.GetOrdinal("EmployeeID");
            var shipmentIdOrdinal = reader.GetOrdinal("ShipmentID");
            var orderDateOrdinal = reader.GetOrdinal("OrderDate");
            var shipmentAddressIdOrdinal = reader.GetOrdinal("Shipment Address");

            while (reader.Read())
            {
                orders.Add(new Orders(
                   reader.GetInt32(orderIdOrdinal),
                   reader.GetInt32(memberIdOrdinal),
                   reader.GetInt32(employeeIdOrdinal),
                   reader.GetInt32(shipmentIdOrdinal),
                    reader.GetDateTimeOffset(orderDateOrdinal),
                     reader.GetString(shipmentAddressIdOrdinal)));
            }

            return orders;
        }
    }
}
