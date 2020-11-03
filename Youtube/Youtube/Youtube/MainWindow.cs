using System;
using Gtk;
using Youtube;


public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

 
    protected void Click(object sender, EventArgs e)
    
    {     
        Usuario var01=new Usuario(entry1.Text,entry2.Text,entry3.Text,entry4.Text);
    }
}
