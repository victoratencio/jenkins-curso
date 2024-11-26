namespace XUnitTest
{
	public class XUnitTest
	{
		[Fact]
		public void SumValuesTest()
		{
			Jenkins_training_app.Services.Sum Sum = new  Jenkins_training_app.Services.Sum();

			var result = Sum.SumValues(5, 2);

			Assert.Equal(7, result);
		}

		[Fact]
		public void RestValuesTest()
		{
			Jenkins_training_app.Services.Sum Rest = new Jenkins_training_app.Services.Sum();

			var result = Rest.RestValues(5, 2);

			Assert.Equal(1, result);
		}
	}
}