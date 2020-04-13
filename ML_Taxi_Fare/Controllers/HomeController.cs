using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ML_Taxi_Fare.Models;
using System.IO;
using Microsoft.ML;


namespace ML_Taxi_Fare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TaxiFarePredictionModel customerDetails)
        {

            DataViewSchema modelInputSchema;

            var context = new MLContext();
           
            ITransformer model = context.Model.Load("C:/Users/Mike/OneDrive/Desktop/Taxi_Predict/ML_Taxi_Fare/ML_Taxi_Fare/MLModel.zip", out modelInputSchema);

            var predictionEngine = context.Model.CreatePredictionEngine<TaxiFarePredictionModel, FarePrediction>(model);

            var prediction = predictionEngine.Predict(customerDetails);

           // System.Diagnostics.Debug.WriteLine($"Predicted Fare:  ${prediction.PredictedFare}");

            ViewBag.Price = prediction.PredictedFare;

    
            return View();
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}