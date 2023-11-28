namespace To_do;

public partial class MainPage : ContentPage
{
    List<Ukol.Pokrok> Prubehy = new List<Ukol.Pokrok>() { Ukol.Pokrok.Zadáno, Ukol.Pokrok.Rozpracováno, Ukol.Pokrok.Hotovo };
    //List<Ukol> Ukoly = new List<Ukol>();
    List<string> UkolyStr = new List<string>();
    public MainPage()
    {
        InitializeComponent();
        Ukol Ukol1 = new Ukol("Ukol1", DateTime.MaxValue, Ukol.Pokrok.Hotovo);
        Ukol Ukol2 = new Ukol("Ukol2",DateTime.MinValue,Ukol.Pokrok.Rozpracováno);
        //Ukoly.Add(Ukol1);
        UkolyStr.Add(Ukol1.ToString());
        UkolyStr.Add(Ukol2.ToString());
        PrubehPicker.ItemsSource = Prubehy;
        Seznam.ItemsSource = UkolyStr;
    }

    private void NewBttn_Clicked(object sender, EventArgs e)
    {
        Ukol NewUkol = new Ukol($"{NameEntry.Text}",DPicker.Date, (Ukol.Pokrok)PrubehPicker.SelectedItem);
        UkolyStr.Add(NewUkol.ToString());
        refresh();
    }

    private void EditBttn_Clicked(object sender, EventArgs e)
    {

    }

    private void DeleteBttn_Clicked(object sender, EventArgs e)
    {

    }

    private void refresh()
    {
        Seznam.ItemsSource = null;
        Seznam.ItemsSource = UkolyStr;
    }
}

