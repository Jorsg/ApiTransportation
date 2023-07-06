using System;
using System.Collections.Generic;

#nullable disable

namespace apilfs.Models
{
    public partial class BenchmarkRate
    {
        public int Id { get; set; }
        public int IdQuote { get; set; }
        public decimal? BenchmarkPmLinehaulRate { get; set; }
        public decimal? LowBenchmarkPmLinehaulRate { get; set; }
        public decimal? HighBenchmarkPmLinehaulRate { get; set; }
        public decimal? BenchmarkLinehaulRate { get; set; }
        public decimal? LowBenchmarkLinehaulRate { get; set; }
        public decimal? HighBenchmarkLinehaulRate { get; set; }
        public decimal? BenchmarkPmFuelRate { get; set; }
        public decimal? BenchmarkFuelRate { get; set; }
        public decimal? BenchmarkPmAllInRate { get; set; }
        public decimal? LowBenchmarkPmAllInRate { get; set; }
        public decimal? HighBenchmarkPmAllInRate { get; set; }
        public decimal? BenchmarkAllInRate { get; set; }
        public decimal? LowBenchmarkAllInRate { get; set; }
        public decimal? HighBenchmarkAllInRate { get; set; }
        public decimal? ConfidenceLevel { get; set; }
        public decimal? Contributors { get; set; }
        public decimal? Moves { get; set; }
        public decimal? DaysBack { get; set; }
        public decimal? MetroLaneMileage { get; set; }
        public string RatedLaneOrig { get; set; }
        public string RatedLaneDest { get; set; }
        public decimal? CostBasisPmLinehaulRate { get; set; }
        public decimal? CostBasisLowPmLinehaulRate { get; set; }
        public decimal? CostBasisHighPmLinehaulRate { get; set; }
        public decimal? CostBasisLinehaulRate { get; set; }
        public decimal? CostBasisLowLinehaulRate { get; set; }
        public decimal? CostBasisHighLinehaulRate { get; set; }
        public decimal? CostBasisPmFuelRate { get; set; }
        public decimal? CostBasisFuelRate { get; set; }
        public decimal? CostBasisPmAllInRate { get; set; }
        public decimal? CostBasisLowPmAllInRate { get; set; }
        public decimal? CostBasisHighPmAllInRate { get; set; }
        public decimal? CostBasisAllInRate { get; set; }
        public decimal? CostBasisLowAllInRate { get; set; }
        public decimal? CostBasisHighAllInRate { get; set; }

        public virtual Quote IdQuoteNavigation { get; set; }
    }
}
