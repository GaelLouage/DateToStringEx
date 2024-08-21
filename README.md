DateStringFormatterExercise
Description

DateStringFormatterExercise is a C# project designed to format date strings into a user-friendly format. It demonstrates the use of extension methods and basic date manipulation to convert DateTime and DateOnly objects into readable strings, such as "21 August 2024".
Features

    Date Formatting: Converts DateTime and DateOnly objects into a human-readable format.
    Extension Methods: Provides custom extension methods for formatting months and days.
    Error Handling: Includes basic error handling for invalid month inputs.

Installation

    Clone the repository to your local machine:

    bash

git clone https://github.com/yourusername/DateStringFormatterExercise.git

Navigate to the project directory:

bash

cd DateStringFormatterExercise

Restore the project dependencies:

bash

    dotnet restore

Usage
Formatting Dates

The TimeConvert class provides methods to convert DateTime and DateOnly objects into a formatted string.

Example:

csharp

using DateStringFormatterExercise.Helpers;

var formattedDate = TimeConvert.CurrentDateToString(DateTime.Now);
// Output: "21 August 2024"

Extension Methods

The DateExtensions class includes methods to extend the int type:

    ToMonthName(int month): Converts a month number (1-12) to its full name.

    csharp

int month = 8;
string monthName = month.ToMonthName();
// Output: "August"

ToDayWithoutLeadingZero(int day): Removes leading zeros from the day.

csharp

    int day = 05;
    string dayWithoutLeadingZero = day.ToDayWithoutLeadingZero();
    // Output: "5"

Running the Project

    Build and run the project:

    bash

    dotnet run

    Open a browser and navigate to http://localhost:5000 to see the formatted date output.

Contributing

Contributions are welcome! Please follow these steps to contribute:

    Fork the repository.
    Create a new branch for your feature or bug fix.
    Commit your changes with descriptive messages.
    Push your changes to your fork.
    Submit a pull request to the main repository.

