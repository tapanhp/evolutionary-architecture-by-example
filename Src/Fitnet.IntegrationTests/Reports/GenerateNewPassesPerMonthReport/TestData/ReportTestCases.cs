namespace SuperSimpleArchitecture.Fitnet.IntegrationTests.Reports.GenerateNewPassesPerMonthReport.TestData;

using System.Collections;

internal sealed class ReportTestCases : IEnumerable<object[]>
{
    internal static DateTimeOffset FakeNowDate = new(2021, 1, 1, 0, 0, 0, TimeSpan.Zero);

    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new List<PassRegistrationDateRange>
            {
                new(new DateTimeOffset(FakeNowDate.Year, 1, 3, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 1, 10 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 2, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 2, 28 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 3, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 3, 31 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 4, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 4, 30 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 5, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 5, 31 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 6, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 6, 30 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 7, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 7, 31 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 8, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 8, 31 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 9, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 9, 30 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 10, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 10, 31 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 11, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 11, 30 ,1, 1, 1,1, TimeSpan.Zero)),
                new(new DateTimeOffset(FakeNowDate.Year, 12, 1, 1, 1,1, TimeSpan.Zero), new DateTimeOffset(2021, 12, 31 ,1, 1, 1,1, TimeSpan.Zero))
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}