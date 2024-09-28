using System;
internal static class Program
{
    
        private static void Main(string[] args)
        { 
            var sampleValuesList = new List<double> { 9, 6, 8, 5, 7 };
            var sampleStdDev = Statistics.COMPUTE_SAMPLE_STANDARD_DEVIATION(sampleValuesList);
            System.Console.WriteLine($"Sample StdDev = {sampleStdDev} ({sampleStdDevInterpretation})");
    //Writes "Sample StdDev=1.5811388300841898"
    //From https://www.cuemath.com/sample-standard-deviation-formula/

            var populationValuesList = new List<double>
             {
              9, 2, 5, 4, 12, 7, 8, 11, 9, 3, 7, 4, 12, 5, 4, 10, 9, 6, 9, 4
             };
            var popStdDev = Statistics.COMPUTE_SAMPLE_STANDARD_DEVIATION(populationValuesList);
            var popStdDevInterpretation = sampleStdDevInterpretation.InterpretStandardDeviation
            System.Console.WriteLine("Population StdDev =" + popStdDev);
            //Writes "Population StdDev=2.9832867780352594"
    }
        
}