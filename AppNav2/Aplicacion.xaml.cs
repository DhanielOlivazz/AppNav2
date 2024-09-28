namespace AppNav2;
public partial class Aplicacion : FlyoutPage
{
    public Aplicacion()
    {
        InitializeComponent();

        FlyoutLoL.collectionview.SelectionChanged += CollectionView_SelectionChanged;
    }

    private void CollectionView_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as Data.FlyoutPageItem;
        if (item != null && item.TargetType != null)
        {
            var pageInstance = Activator.CreateInstance(item.TargetType) as Page;
            if (pageInstance != null)
            {
                Detail = new NavigationPage(pageInstance);
                if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                {
                    IsPresented = false;
                }
            }
        }
    }
}
