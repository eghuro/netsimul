
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button button4;
	private global::Gtk.HSeparator hseparator1;
	private global::Gtk.Button button5;
	private global::Gtk.HBox hbox5;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button button7;
	private global::Gtk.Fixed fixed6;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Fixed fixed5;
	private global::Gtk.Label label1;
	private global::Gtk.SpinButton spinbutton1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 1200;
		this.HeightRequest = 400;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Simulator");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.WidthRequest = 300;
		this.button4.HeightRequest = 300;
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("A");
		this.hbox1.Add (this.button4);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button4]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.WidthRequest = 600;
		this.hseparator1.Name = "hseparator1";
		this.hbox1.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hseparator1]));
		w2.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button ();
		this.button5.WidthRequest = 300;
		this.button5.HeightRequest = 300;
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("B");
		this.hbox1.Add (this.button5);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button5]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		this.vbox1.Add (this.hbox5);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
		w5.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button7 = new global::Gtk.Button ();
		this.button7.WidthRequest = 300;
		this.button7.HeightRequest = 100;
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString ("Spustit simulaci");
		this.hbox2.Add (this.button7);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button7]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.fixed6 = new global::Gtk.Fixed ();
		this.fixed6.Name = "fixed6";
		this.fixed6.HasWindow = false;
		this.hbox2.Add (this.fixed6);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed6]));
		w7.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.fixed5 = new global::Gtk.Fixed ();
		this.fixed5.Name = "fixed5";
		this.fixed5.HasWindow = false;
		this.hbox3.Add (this.fixed5);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fixed5]));
		w8.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Time to run");
		this.hbox3.Add (this.label1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label1]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.spinbutton1 = new global::Gtk.SpinButton (0, 100, 1);
		this.spinbutton1.CanFocus = true;
		this.spinbutton1.Name = "spinbutton1";
		this.spinbutton1.Adjustment.PageIncrement = 10;
		this.spinbutton1.ClimbRate = 1;
		this.spinbutton1.Numeric = true;
		this.hbox3.Add (this.spinbutton1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.spinbutton1]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.hbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hbox3]));
		w11.Position = 2;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1375;
		this.DefaultHeight = 800;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button4.Clicked += new global::System.EventHandler (this.btnAclicked);
		this.button5.Clicked += new global::System.EventHandler (this.btnBclicked);
	}
}
