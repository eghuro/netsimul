
// This file has been generated by the GUI designer. Do not modify.
namespace NetTrafficSimulator
{
	public partial class LinkParamWidget
	{
		private global::Gtk.VBox vbox6;
		private global::Gtk.HBox hbox12;
		private global::Gtk.Label label12;
		private global::Gtk.Entry entry5;
		private global::Gtk.HBox hbox13;
		private global::Gtk.Label label13;
		private global::Gtk.ComboBox combobox4;
		private global::Gtk.HBox hbox14;
		private global::Gtk.Label label14;
		private global::Gtk.ComboBox combobox5;
		private global::Gtk.HBox hbox15;
		private global::Gtk.Label label15;
		private global::Gtk.SpinButton spinbutton4;
		private global::Gtk.HBox hbox16;
		private global::Gtk.Label label16;
		private global::Gtk.SpinButton spinbutton5;
		private global::Gtk.Button button618;
		private global::Gtk.Fixed fixed4;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget NetTrafficSimulator.LinkParamWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "NetTrafficSimulator.LinkParamWidget";
			// Container child NetTrafficSimulator.LinkParamWidget.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox ();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.WidthRequest = 130;
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.hbox12.Add (this.label12);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label12]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '●';
			this.hbox12.Add (this.entry5);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.entry5]));
			w2.Position = 1;
			this.vbox6.Add (this.hbox12);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox12]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.WidthRequest = 130;
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Node");
			this.hbox13.Add (this.label13);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.label13]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.combobox4 = global::Gtk.ComboBox.NewText ();
			this.combobox4.Name = "combobox4";
			this.hbox13.Add (this.combobox4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.combobox4]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox6.Add (this.hbox13);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox13]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox ();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label ();
			this.label14.WidthRequest = 130;
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Node");
			this.hbox14.Add (this.label14);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.label14]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.combobox5 = global::Gtk.ComboBox.NewText ();
			this.combobox5.Name = "combobox5";
			this.hbox14.Add (this.combobox5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.combobox5]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox6.Add (this.hbox14);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox14]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label ();
			this.label15.WidthRequest = 130;
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Capacity");
			this.hbox15.Add (this.label15);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.label15]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.spinbutton4 = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbutton4.CanFocus = true;
			this.spinbutton4.Name = "spinbutton4";
			this.spinbutton4.Adjustment.PageIncrement = 10;
			this.spinbutton4.ClimbRate = 1;
			this.spinbutton4.Numeric = true;
			this.hbox15.Add (this.spinbutton4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.spinbutton4]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox6.Add (this.hbox15);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox15]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox16 = new global::Gtk.HBox ();
			this.hbox16.Name = "hbox16";
			this.hbox16.Spacing = 6;
			// Container child hbox16.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label ();
			this.label16.WidthRequest = 130;
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("Toggle probability");
			this.hbox16.Add (this.label16);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox16 [this.label16]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox16.Gtk.Box+BoxChild
			this.spinbutton5 = new global::Gtk.SpinButton (0, 1, 0.01);
			this.spinbutton5.CanFocus = true;
			this.spinbutton5.Name = "spinbutton5";
			this.spinbutton5.Adjustment.PageIncrement = 0.1;
			this.spinbutton5.ClimbRate = 0.1;
			this.spinbutton5.Numeric = true;
			this.hbox16.Add (this.spinbutton5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox16 [this.spinbutton5]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox16.Gtk.Box+BoxChild
			this.button618 = new global::Gtk.Button ();
			this.button618.CanFocus = true;
			this.button618.Name = "button618";
			this.button618.UseUnderline = true;
			this.button618.Label = global::Mono.Unix.Catalog.GetString ("Change");
			this.hbox16.Add (this.button618);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox16 [this.button618]));
			w15.PackType = ((global::Gtk.PackType)(1));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox16.Gtk.Box+BoxChild
			this.fixed4 = new global::Gtk.Fixed ();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			this.hbox16.Add (this.fixed4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox16 [this.fixed4]));
			w16.PackType = ((global::Gtk.PackType)(1));
			w16.Position = 3;
			this.vbox6.Add (this.hbox16);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox16]));
			w17.Position = 4;
			w17.Expand = false;
			w17.Fill = false;
			this.Add (this.vbox6);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.button618.Clicked += new global::System.EventHandler (this.OnButton618Clicked);
		}
	}
}
