using System;
using Gtk;
using GuiLite;

public partial class MainWindow: Gtk.Window
{	
	private object zamek=new object();

	private GuiLite.Node a, b;
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		a = new Node ("A");
		b = new Node ("B");
		a.LinkedTo = b;
		b.LinkedTo = a;
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void btnAclicked (object sender, EventArgs e)
	{
		GuiLite.NodeParam apar = new GuiLite.NodeParam (a);
		apar.Show ();
	}

	protected void btnBclicked (object sender, EventArgs e)
	{
		GuiLite.NodeParam bpar = new GuiLite.NodeParam (b);
		bpar.Show ();
	}

	protected void OnButton7Clicked (object sender, EventArgs e)
	{
		lock (zamek) {
			Node bak_a = a.Clone (), bak_b = b.Clone ();
			Model m = new Model (new Node[] { a, b }, spinbutton1.ValueAsInt);
			m.Simulace ();
			a = bak_a;
			a.LinkedTo = b;
			b = bak_b;
			b.LinkedTo = a;
			m = null;
		}
	}

	protected void OnButton69Clicked (object sender, EventArgs e)
	{
		Application.Quit ();
	}
}
