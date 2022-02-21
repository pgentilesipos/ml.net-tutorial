﻿using Microsoft.ML.Data;

namespace Placement.Models;

public class CandidatePrediction
{
    [ColumnName("PredictedLabel")]
    public bool PredictedLabel { get; set; }
    
    [ColumnName("Score")]
    public float Score { get; set; }
}