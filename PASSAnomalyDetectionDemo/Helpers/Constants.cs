namespace PASSAnomalyDetectionDemo.Helpers
{
    public static class Constants
    {
        public static readonly string SubscriptionKey = "";
        public static readonly string Endpoint = "https://dtsanomalydetector.cognitiveservices.azure.com/";
        public static readonly string DetectAnomaliesServiceURL = "/anomalydetector/v1.0/timeseries/entire/detect";
        public static readonly string DetectStatusServiceURL = "/anomalydetector/v1.0/timeseries/last/detect";
        public static readonly string ProjectName = "PASSAnomalyDetectionDemo";
    }
}
