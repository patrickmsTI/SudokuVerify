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
      

        [Fact]
        public void IsSudokuOk()
        {
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

            Assert.True(_sudokuCheckedService.IsSudokuOk(sudoku, 3, 3, 8));
        }
    }
}