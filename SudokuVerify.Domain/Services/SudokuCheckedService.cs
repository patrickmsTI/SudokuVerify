using SudokuVerify.Domain.Entities;
using SudokuVerify.Domain.Interfaces.Repositories;
using SudokuVerify.Domain.Interfaces.Services;

namespace SudokuVerify.Domain.Services
{
    public class SudokuCheckedService : ServiceBase<SudokuChecked>, ISudokuCheckedService
    {
        private ISudokuCheckedRepository _sudokuChecked;

        public SudokuCheckedService(ISudokuCheckedRepository sudokuCheckedRepository) : base(sudokuCheckedRepository)
        {
            _sudokuChecked = sudokuCheckedRepository;
        }

        public bool IsSudokuOk(string[] sudoku, int positionRow, int positionCol, int value)
        {
           
            var valChar = char.Parse(value.ToString());
            var row = positionRow - 1;
            var col = positionCol - 1;

            var check = sudoku[row].ToCharArray();
            check[col] = valChar;
            sudoku[row] = new string(check);

            string concact = string.Join("", sudoku);
            
            var response =  NotInRow(sudoku, row, valChar) &&
                   NotInCol(sudoku, col, valChar) &&
                   NotInBox(sudoku, row, col, valChar);          

            if (response)
            {
                if(!_sudokuChecked.GetByFilter(c => c.ValueSudokuChecked.Equals(concact)).Any())
                {
                    var sudokoChecked = new SudokuChecked
                    {
                        ValueSudokuChecked = concact
                    };
                    _sudokuChecked.Add(sudokoChecked);
                }
            }
            return response;
        }

        // Checks whether there is any duplicate
        // in current row or not
        public static bool NotInRow(string[] arr, int row, char value)
        {         
            if (arr[row].ToCharArray().Count(c => c.Equals(value)) > 1)
                return false;
            return true;
        }

        // Checks whether there is any duplicate
        // in current column or not.
        public static bool NotInCol(string[] arr, int col, char value)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (item.ToCharArray()[col].Equals(value))
                    count++;
                if (count > 1)
                    return false;
            }
            return true;
        }

        // Checks whether there is any duplicate
        //// in current 3x3 box or not.
        public static bool NotInBox(string[] arr, int row, int col, char value)
        {
            int r = row - row % 3;
            int c = col - col % 3;
            int count = 0;

            for (int i = r; i < r + 3; i++)
            {
                var x = arr[i].ToCharArray();
                for (int j = c; j < c + 3; j++)
                {
                    if (x[j].Equals(value))
                        count++;
                    if (count > 1)
                        return false;
                }
            }
            return true;
        }

    }
}
