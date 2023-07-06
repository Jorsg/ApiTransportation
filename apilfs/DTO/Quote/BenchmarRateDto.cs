using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;

namespace apilfs.DTO
{
    public class BenchmarRateDto
    {
        public int IdQuote { get; set; }
        public string BenchmarkPmLinehaulRate { get; set; }
        public string LowBenchmarkPmLinehaulRate { get; set; }
        public string HighBenchmarkPmLinehaulRate { get; set; }
        public string BenchmarkLinehaulRate { get; set; }
        public string LowBenchmarkLinehaulRate { get; set; }
        public string HighBenchmarkLinehaulRate { get; set; }
        public string BenchmarkPmFuelRate { get; set; }
        public string BenchmarkFuelRate { get; set; }
        public string BenchmarkPmAllInRate { get; set; }
        public string LowBenchmarkPmAllInRate { get; set; }
        public string HighBenchmarkPmAllInRate { get; set; }
        public string BenchmarkAllInRate { get; set; }
        public string LowBenchmarkAllInRate { get; set; }
        public string HighBenchmarkAllInRate { get; set; }
        public string ConfidenceLevel { get; set; }
        public decimal Contributors { get; set; }
        public decimal Moves { get; set; }
        public decimal DaysBack { get; set; }
        public string MetroLaneMileage { get; set; }
        public string RatedLaneOrig { get; set; }
        public string RatedLaneDest { get; set; }
        public string CostBasisPmLinehaulRate { get; set; }
        public string CostBasisLowPmLinehaulRate { get; set; }
        public string CostBasisHighPmLinehaulRate { get; set; }
        public string CostBasisLinehaulRate { get; set; }
        public string CostBasisLowLinehaulRate { get; set; }
        public string CostBasisHighLinehaulRate { get; set; }
        public string CostBasisPmFuelRate { get; set; }
        public string CostBasisFuelRate { get; set; }
        public string CostBasisPmAllInRate { get; set; }
        public string CostBasisLowPmAllInRate { get; set; }
        public string CostBasisHighPmAllInRate { get; set; }
        public string CostBasisAllInRate { get; set; }
        public string CostBasisLowAllInRate { get; set; }
        public string CostBasisHighAllInRate { get; set; }

    }

    public class MapinBenchmarRate
    {
        public BenchmarkRate MapinBenchmarkRate(BenchmarRateDto benchmarRateDto, int idQuote)
        {
            BenchmarkRate _benchmarkRate = new BenchmarkRate();
            _benchmarkRate.IdQuote = idQuote;
            _benchmarkRate.BenchmarkAllInRate = Convert.ToDecimal(benchmarRateDto.BenchmarkAllInRate);
            _benchmarkRate.BenchmarkFuelRate = Convert.ToDecimal(benchmarRateDto.BenchmarkFuelRate);
            _benchmarkRate.BenchmarkLinehaulRate = Convert.ToDecimal(benchmarRateDto.BenchmarkLinehaulRate);
            _benchmarkRate.BenchmarkPmAllInRate = Convert.ToDecimal(benchmarRateDto.BenchmarkPmAllInRate);
            _benchmarkRate.BenchmarkPmFuelRate = Convert.ToDecimal(benchmarRateDto.BenchmarkPmFuelRate);
            _benchmarkRate.BenchmarkPmLinehaulRate = Convert.ToDecimal(benchmarRateDto.BenchmarkPmLinehaulRate);
            _benchmarkRate.ConfidenceLevel = Convert.ToDecimal(benchmarRateDto.ConfidenceLevel);
            _benchmarkRate.Contributors = benchmarRateDto.Contributors;
            _benchmarkRate.CostBasisAllInRate = Convert.ToDecimal(benchmarRateDto.CostBasisAllInRate);
            _benchmarkRate.CostBasisFuelRate = Convert.ToDecimal(benchmarRateDto.CostBasisFuelRate);
            _benchmarkRate.CostBasisHighAllInRate = Convert.ToDecimal(benchmarRateDto.CostBasisHighAllInRate);
            _benchmarkRate.CostBasisHighLinehaulRate = Convert.ToDecimal(benchmarRateDto.CostBasisHighLinehaulRate);
            _benchmarkRate.CostBasisHighPmAllInRate = Convert.ToDecimal(benchmarRateDto.CostBasisHighPmAllInRate);
            _benchmarkRate.CostBasisHighPmLinehaulRate = Convert.ToDecimal(benchmarRateDto.CostBasisHighPmLinehaulRate);
            _benchmarkRate.CostBasisLinehaulRate = Convert.ToDecimal(benchmarRateDto.CostBasisLinehaulRate);
            _benchmarkRate.CostBasisLowAllInRate = Convert.ToDecimal(benchmarRateDto.CostBasisLowAllInRate);
            _benchmarkRate.CostBasisLowLinehaulRate = Convert.ToDecimal(benchmarRateDto.CostBasisLowLinehaulRate);
            _benchmarkRate.CostBasisLowPmAllInRate = Convert.ToDecimal(benchmarRateDto.CostBasisLowPmAllInRate);
            _benchmarkRate.CostBasisLowPmLinehaulRate = Convert.ToDecimal(benchmarRateDto.CostBasisLowPmLinehaulRate);
            _benchmarkRate.CostBasisPmAllInRate = Convert.ToDecimal(benchmarRateDto.CostBasisPmAllInRate);
            _benchmarkRate.CostBasisPmFuelRate = Convert.ToDecimal(benchmarRateDto.CostBasisPmFuelRate);
            _benchmarkRate.CostBasisPmLinehaulRate = Convert.ToDecimal(benchmarRateDto.CostBasisPmLinehaulRate);
            _benchmarkRate.DaysBack = benchmarRateDto.DaysBack;
            _benchmarkRate.HighBenchmarkAllInRate = Convert.ToDecimal(benchmarRateDto.HighBenchmarkAllInRate);
            _benchmarkRate.HighBenchmarkLinehaulRate = Convert.ToDecimal(benchmarRateDto.HighBenchmarkLinehaulRate);
            _benchmarkRate.HighBenchmarkPmAllInRate = Convert.ToDecimal(benchmarRateDto.HighBenchmarkPmAllInRate);
            _benchmarkRate.HighBenchmarkPmLinehaulRate = Convert.ToDecimal(benchmarRateDto.HighBenchmarkPmLinehaulRate);     
            _benchmarkRate.LowBenchmarkAllInRate = Convert.ToDecimal(benchmarRateDto.LowBenchmarkAllInRate);
            _benchmarkRate.LowBenchmarkLinehaulRate = Convert.ToDecimal(benchmarRateDto.LowBenchmarkLinehaulRate);
            _benchmarkRate.LowBenchmarkPmAllInRate = Convert.ToDecimal(benchmarRateDto.LowBenchmarkPmAllInRate);
            _benchmarkRate.LowBenchmarkPmLinehaulRate = Convert.ToDecimal(benchmarRateDto.LowBenchmarkPmLinehaulRate);
            _benchmarkRate.MetroLaneMileage = Convert.ToDecimal(benchmarRateDto.MetroLaneMileage);
            _benchmarkRate.Moves = benchmarRateDto.Moves;
            _benchmarkRate.RatedLaneDest = benchmarRateDto.RatedLaneDest;
            _benchmarkRate.RatedLaneOrig = benchmarRateDto.RatedLaneOrig;

            return _benchmarkRate;
        }
    }
}
