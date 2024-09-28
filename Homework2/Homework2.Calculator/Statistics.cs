namespace Homework2;

public class Statistics
{
   //Function to compute the mean (average) of a list of values
    static double COMPUTE_MEAN(int[] valuesList)
    {

        if (valuesList.Length == 0)
        {
            throw new ArgumentException("valuesList parameter cannot be null or empty");
        }

        double sumAccumulator = 0;
        foreach (int value in valuesList)
        {
            sumAccumulator += value; //original code: sumAccumulator = sumAccumulator + value;
        }

        //Return the average (sum divided by the number of values we accumulated)
        return sumAccumulator / valuesList.Length;
    }



//Function to compute the sum of squared differences from the mean
    static double COMPUTE_SQUARE_OF_DIFFERENCES(int[] valuesList, double mean)
    {
        if (valuesList.Length == 0)
        {
            throw new ArgumentException("valuesList parameter cannot be null or empty");
        }

        double squareAccumulator = 0;
        foreach (int value in valuesList)
        {
            double difference = value - mean;
            double squareOfDifference = difference * difference;
            squareAccumulator += squareOfDifference; //original code: squareAccumulator = squareAccumulator + squareOfDifference
        }

        return squareAccumulator;
    }

//Function to compute the variance based on squared differences
//Set isPopulation to true to compute a population standard deviation in COMPUTE_VARIANCE
//Set isPopulation to false, to compute a sample standard deviation in COMPUTE_VARIANCE
    static double COMPUTE_VARIANCE(double squareOfDifferences, int numValues, bool isPopulation)
    {
        //Adjust number of values by minus one if sample where sample is indicated by (not isPopulation)
        //https://www.quora.com/On-the-sample-standard-deviation-why-do-we-subtract-N-by-1

        if (!isPopulation)
        {
            numValues--; //original code: numvalues = numvalues - 1
        }

        //Test numValues after adjusting for change to numValues 
        //We cannot allow numValues to be a 0 denominator (division by zero / undefined)
        if (numValues < 1)
        {
            throw new ArgumentException(
                "numValues is too low (sample size must be >= 2, population size must be >= 1)");
        }

        return squareOfDifferences / numValues;

    }

//Function to compute the population or sample standard deviation from a list of values
    static double COMPUTE_STANDARD_DEVIATION(int[] valuesList, bool isPopulation)
    {
        if (valuesList.Length == 0)
        {
            throw new ArgumentException("valuesList parameter cannot be null or empty");
        }

        double mean = COMPUTE_MEAN(valuesList);
        double squareOfDifferences = COMPUTE_SQUARE_OF_DIFFERENCES(valuesList, mean);
        double variance = COMPUTE_VARIANCE(squareOfDifferences, valuesList.Length, isPopulation);

        return Math.Sqrt(variance);
        //where SquareRoot is a math function to compute the square root of the variance

    }

//Function to compute the sample standard deviation from a list of values
            static double COMPUTE_SAMPLE_STANDARD_DEVIATION(int[] valuesList)
            {
//(false) in the following statement indicates we are computing a sample variance
                return COMPUTE_STANDARD_DEVIATION(valuesList, false);
            }

//Function to compute the population standard deviation from a list of values
            static double COMPUTE_POPULATION_STANDARD_DEVIATION(int[] valuesList)
            {
                //(true) in the following statement indicates we are computing a population variance
                return COMPUTE_STANDARD_DEVIATION(valuesList, true);
            }
        }
    