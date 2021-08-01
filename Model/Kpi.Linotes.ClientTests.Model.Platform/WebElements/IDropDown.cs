namespace Kpi.Linotes.ClientTests.Model.Platform.WebElements
{
    public interface IDropDown
    {
        string[] GetOptions();

        void Choose(string option);
    }
}
