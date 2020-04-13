using Microsoft.ML.Data;

namespace ML_Taxi_Fare.Controllers
{
    internal class FarePrediction
    {
        [ColumnName("Score")]
        public float PredictedFare { get; set; }
    }
}