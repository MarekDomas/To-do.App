namespace To_do;

public partial class MainPage : ContentPage
{
    List<Ukol.Pokrok> Prubehy = new List<Ukol.Pokrok>() { Ukol.Pokrok.Zadáno, Ukol.Pokrok.Rozpracováno, Ukol.Pokrok.Hotovo };
    List<Ukol> Ukoly = new List<Ukol>();
   // List<string> UkolyStr = new List<string>();
    public MainPage()
    {
        Ukol Ukol1 = new Ukol("Ukol1", DateTime.Now, Ukol.Pokrok.Hotovo);
        Ukol Ukol2 = new Ukol("Ukol2",DateTime.UtcNow,Ukol.Pokrok.Rozpracováno);

        Ukoly.Add(Ukol1);
        Ukoly.Add(Ukol2);

        InitializeComponent();

        PrubehPicker.ItemsSource = Prubehy;
        Seznam.ItemsSource = Ukoly;
    }

    private void NewBttn_Clicked(object sender, EventArgs e)
    {
        Ukol NewUkol = new Ukol($"{NameEntry.Text}",DPicker.Date, (Ukol.Pokrok)PrubehPicker.SelectedItem);
        Ukoly.Add(NewUkol);
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
        Seznam.ItemsSource = Ukoly;
    }
}

