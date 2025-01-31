// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ML;
using Test1_serviceML.Model;

namespace Test1_serviceML.Model
{
    public class ConsumeModel
    {
        // For more info on consuming ML.NET models, visit https://aka.ms/model-builder-consume
        // Method for consuming model in your app
        public static ModelOutput Predict(ModelInput input)
        {

            // Create new MLContext
            MLContext mlContext = new MLContext();


            // Load model & create prediction engine
            // string modelPath = @"C:\Users\avina\AppData\Local\Temp\MLVSTools\test1_serviceML\test1_serviceML.Model\MLModel.zip";
            string modelPath = @"C:\Users\sachi\AppData\Local\Temp\MLVSTools\secondtryML\secondtryML.Model\MLModel.zip";
            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            // Use model to make prediction on input data
            ModelOutput result = predEngine.Predict(input);
            return result;
        }
    }
}
