using Microsoft.ML.Data;

namespace TaxiFarePrediction
{
    public class TaxiTrip
    {        
        [LoadColumn(0)]
        public string VendorId { get; set; }
        [LoadColumn(1)]
        public string RateCode { get; set; }
        [LoadColumn(2)]
        public float Passengers { get; set; }
        [LoadColumn(3)]
        public float TripTime { get; set; }
        [LoadColumn(4)]
        public float Distance { get; set; }
        [LoadColumn(5)]
        public string PaymentType { get; set; }
        [LoadColumn(6), ColumnName("Label")]
        public float Fare { get; set; }
    }

    public class TaxiTripPrediction
    {
        [ColumnName("Score")]
        public float Fare { get; set; }   
    }
}