using System;

class TemperatureComparison {
  public static void Main (string[] args) {
// initialize variables for temperature range and the number of temperatures to be inputted
const int minimumTemperature = -30;
const int maximumTemperature = 130; 
const int numberTemperature = 5;

    int [] temperature = new int [numberTemperature];

// loop through 5 times in order to collect 5 temperatures, assign the user inputted value into the temperature array. call a method getTemperature method for each itteration
    for(int i = 0; i < numberTemperature; i++){
      temperature[i] = getTemperature(i + 1, minimumTemperature, maximumTemperature);
    }// close for loop
// validate the order of the teperatures by setting 2 variables to true
  bool gettingWarmer = true;
  bool gettingCooler = true;

// loop through and find the lengths of the temputure range
    for(int i = 1; i < temperature.Length; i++){
      if (temperature [i] <= temperature[i - 1]){
        gettingWarmer = false;
      }// close 1st if
      if (temperature [i] >= temperature [i - 1]){
        gettingCooler = false;
      }// close 2nd if
    }// close 2nd for loop

// display the message to the user
string userMessage;
    if(gettingWarmer){
      userMessage = "Getting warmer";
    }// end 1st "message if"

    else if (gettingCooler){
      userMessage = "Getting cooler";
    }// end else If

    else{
      userMessage = "It's a mixed bag";
    }// end else

  // display the message and the results
  // find the average, create a loop that iterates through the inputted values and is added to a variable called sum. then claclulate the average of the inputted values
    int sum = 0;
    for (int i = 0; i < temperature.Length; i++) {
      sum += temperature[i];
    }
    double averageTemperature = (double)sum / temperature.Length;
// display the message, concatanate the 5 user input values and finally display the average temperature.
  Console.WriteLine(userMessage);
  Console.WriteLine("5 day temperature: [" + string.Join(",", temperature) + "]");
    Console.WriteLine("Average Temperature is " + averageTemperature + " degrees");


// create a method with parameters for the days, minumum temperature and maximum temperature create a loop that runs until a valid temperature is inputted. accept the user input and parse it into an interger and stor it in a variable temp
    static int getTemperature (int day , int minimumTemperature, int maximumTemperature){

    while(true){
      Console.WriteLine($"Enter the temperature for the day {day}: ");
      if(int.TryParse(Console.ReadLine(), out int temp)){
        if (temp >= minimumTemperature && temp <= maximumTemperature){
          return temp;
        }// close 2nd if
        else{
          Console.WriteLine($"Exception Temperature {temp} is invalid. Please enter a valid temperature between {minimumTemperature} and {maximumTemperature} ");
        }// close else
      }// close if
    }// close while loop
    }// close method getTemperature
  }// close main method
}// close class temperatureComparison