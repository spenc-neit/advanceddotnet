namespace BlockbusterTest
{
    public class BlockbusterBasicFunctionsTest
    {
        [Fact]
        public void GetMovieByIdTest()
        {
            var result = BlockBuster.BlockbusterBasicFunctions.GetMovieById(11);
            Assert.NotNull(result);
            Assert.True(result.Title == "Vertigo", "Found movie's release date is not the expected result");
            Assert.True(result.ReleaseYear == 1958, "Found movie's title is not the expected result");
        }

        [Fact]
        public void GetAllMoviesTest()
        {
            var result = BlockBuster.BlockbusterBasicFunctions.GetAllMovies();
            Assert.NotNull(result);
            Assert.True(result.Count == 54);
        }

        [Fact] 
        public void GetAllCheckedOutMoviesTest()
        {
            var result = BlockBuster.BlockbusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.NotNull(result);
            Assert.True(result.Count == 3);
        }
    }
}