using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        new cButton();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}

class cButton : Window
{
    public static int i = 0;
    Button clickerButton = new Button();
    public cButton() : base("clicker")
    {
        SetDefaultSize(100, 100); 
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); };
        clickerButton.Label = "Click me!";
        clickerButton.Clicked += new global::System.EventHandler(clickEvent);
        Add(clickerButton);
        ShowAll();
    }

    void clickEvent(object sender, EventArgs e)
    {
        i = i + 1; 
        clickerButton.Label = Convert.ToString(i);

    }

}