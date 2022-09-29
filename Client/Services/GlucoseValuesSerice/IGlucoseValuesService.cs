namespace DiabetesBlazorApp.Client.Services.GlucoseValuesSerice
{
    public interface IGlucoseValuesService
    {
        List<GlucoseValue> glucoseValues { get; set; }

        Task GetGlusoeValues();

    }
}
