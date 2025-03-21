namespace ChatGPT.Views.Templates;

public partial class BotMessageItemTemplate : Grid
{
    public BotMessageItemTemplate()
    {
        InitializeComponent();

        // Remove this line:
        // borderText.SizeChanged += BorderText_SizeChanged;
    }

    private void ParentGrid_SizeChanged(object sender, EventArgs e)
    {
        var parentGrid = (Grid)sender;

        // Example logic: enforce a max width on the border
        double widthMaxBorderText = parentGrid.Width - 45;

        if (borderText.Width > widthMaxBorderText)
        {
            Dispatcher.Dispatch(() =>
            {
                borderText.WidthRequest = widthMaxBorderText;
            });
        }
    }
}
