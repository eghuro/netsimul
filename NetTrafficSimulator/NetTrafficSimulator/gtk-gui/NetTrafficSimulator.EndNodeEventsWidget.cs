
// This file has been generated by the GUI designer. Do not modify.
namespace NetTrafficSimulator
{
	public partial class EndNodeEventsWidget
	{
		private global::Gtk.VBox vbox7;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView nodeview3;
		private global::Gtk.HBox hbox17;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Button button2;
		private global::Gtk.Button button1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget NetTrafficSimulator.EndNodeEventsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "NetTrafficSimulator.EndNodeEventsWidget";
			// Container child NetTrafficSimulator.EndNodeEventsWidget.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview3 = new global::Gtk.NodeView ();
			this.nodeview3.CanFocus = true;
			this.nodeview3.Name = "nodeview3";
			this.GtkScrolledWindow.Add (this.nodeview3);
			this.vbox7.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox17 = new global::Gtk.HBox ();
			this.hbox17.Name = "hbox17";
			this.hbox17.Spacing = 6;
			// Container child hbox17.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox17.Add (this.fixed1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.fixed1]));
			w3.Position = 0;
			// Container child hbox17.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.hbox17.Add (this.button2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.button2]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox17.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button ();
			this.button1.Sensitive = false;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.hbox17.Add (this.button1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.button1]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox7.Add (this.hbox17);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox17]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox7);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
