using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_Taxi_Fare.Models
{
    public class TaxiFarePredictionModel
    {
        [ColumnName("vendor_id"), LoadColumn(0)]
        public string Vendor_id { get; set; }


        [ColumnName("rate_code"), LoadColumn(1)]
        public float Rate_code { get; set; }


        [ColumnName("passenger_count"), LoadColumn(2)]
        public float Passenger_count { get; set; }


        [ColumnName("trip_time_in_secs"), LoadColumn(3)]
        public float Trip_time_in_secs { get; set; }


        [ColumnName("trip_distance"), LoadColumn(4)]
        public float Trip_distance { get; set; }


        [ColumnName("payment_type"), LoadColumn(5)]
        public string Payment_type { get; set; }


        [ColumnName("fare_amount"), LoadColumn(6)]
        public float Fare_amount { get; set; }

    }
}
