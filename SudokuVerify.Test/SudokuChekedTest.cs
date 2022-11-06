using Moq;
using SudokuVerify.Domain.Interfaces.Repositories;
using SudokuVerify.Domain.Interfaces.Services;
using SudokuVerify.Domain.Services;
using Xunit;

namespace SudokuVerify.Test
{
    public class SudokuChekedTest
    {
        private readonly ISudokuCheckedService _sudokuCheckedService;
        private readonly Mock<ISudokuCheckedRepository> _repository;

        public SudokuChekedTest()
        {
            _repository = new Mock<ISudokuCheckedRepository>();
            _sudokuCheckedService = new SudokuCheckedService(_repository.Object);
        }

        [Theory]
        [InlineData(3,3,8, true)]
        [InlineData(1,5,7, true)]     
        [InlineData(3,4,3, true)]     
        public void IsSudokuOk_SudokuVerify_ReturnTrue(int row, int col, int value, bool expected)
        {
            //Arrange
            string[] sudoku = {
                 "534678912",
                 "672195348",
                 "198342567",
                 "859761423",
                 "426853791",
                 "713924856",
                 "961537284",
                 "287419635",
                 "345286179"};

            //Act
            var validation = _sudokuCheckedService.IsSudokuOk(sudoku, row, col, value);

            //Assert
            Assert.Equal(expected, validation);
        }

        [Theory]
        [InlineData(3, 3, 2, false)]
        [InlineData(1, 5, 4, false)]
        [InlineData(3, 4, 9, false)]
        public void IsSudokuOk_SudokuVerify_ReturnFalse(int row, int col, int value, bool expected)
        {
            //Arrange
            string[] sudoku = {
                 "534678912",
                 "672195348",
                 "198342567",
                 "859761423",
                 "426853791",
                 "713924856",
                 "961537284",
                 "287419635",
                 "345286179"};

            //Act
            var validation = _sudokuCheckedService.IsSudokuOk(sudoku, row, col, value);

            //Assert
            Assert.Equal(expected, validation);
        }
    }
}