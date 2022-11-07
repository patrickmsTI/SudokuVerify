# SudokuVerify
API to verify if Sudoku is valid or not a Sudoku.

## Build Setup

``` bash
# Download the project from the github repository
# Define the SudokuVerify project as the startup project
# Build the application
# Run the application in the desired browser
# For your convenience, the swagger application will be open for testing the api
```

#Example
The API will receive a array of string with 9 positions with 9 numbers, the row position, colum position, and the value to validate.

  Board Example
	-------------------
	|7 9 2|1 5 4|3 8 6|
	|6 4 3|8 2 7|1 5 9|
	|8 5 1|3 9 6|7 2 4|
	-------------------
	|2 6 5|9 7 3|8 4 1|
	|4 8 9|5 6 1|2 7 3|
	|3 1 7|4 8 2|9 6 5|
	-------------------
	|1 3 6|7 4 8|5 9 2|
	|9 7 4|2 1 5|6 3 8|
	|5 2 8|6 3 9|4 1 7|
	-------------------

Will be represented by the array 
["792154386","643827159","851396724","265973841","489561273","317482965","136748592","974215638","528639417"]

If verify this array on row position 3 and column position 3 the value '2', the return will be Forbidden, 
because in this row there is already a column with the value '2'

If verify this array on on row position 2 an column position 4 the value '8', the return will be Ok, because 
there is no other '8' in the same row, in the same column or inside the box
