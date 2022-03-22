
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action ExitAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action OpenAction;
	
	private global::Gtk.Action SaveAction;
	
	private global::Gtk.Action SaveAsAction;
	
	private global::Gtk.VBox vboxMenuMain;
	
	private global::Gtk.HBox hboxMenu;
	
	private global::Gtk.Alignment alignment2;
	
	private global::Gtk.MenuBar menuMain;
	
	private global::Gtk.VSeparator menuSeparator;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.ComboBoxEntry cbListen;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Entry txtPort;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.ComboBoxEntry cbLoginURL;
	
	private global::Gtk.Button btnStart;
	
	private global::Gtk.HPaned mainSplit;
	
	private global::Gtk.VBox vboxSessions;
	
	private global::Gtk.ScrolledWindow sessionLogScroller;
	
	private global::Gtk.HBox hboxSessionBottom;
	
	private global::Gtk.CheckButton cbAutoScroll;
	
	private global::Gtk.Notebook tabsMain;
	
	private global::Gtk.VBox vboxLog;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Alignment GtkAlignment2;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Label lblUDPIn;
	
	private global::Gtk.Label lblUDPOut;
	
	private global::Gtk.Label lblUDPTotal;
	
	private global::Gtk.Label GtkLabel5;
	
	private global::Gtk.Frame frame2;
	
	private global::Gtk.Alignment GtkAlignment3;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Label lblCapIn;
	
	private global::Gtk.Label lblCapOut;
	
	private global::Gtk.Label lblCapTotal;
	
	private global::Gtk.Label GtkLabel12;
	
	private global::Gtk.ScrolledWindow logFileScroller;
	
	private global::Gtk.TextView txtSummary;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.VBox hboxFilter;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Button btnLoadFilters;
	
	private global::Gtk.Button btnSaveFilters;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Frame frameFilterUDP;
	
	private global::Gtk.Alignment containerFilterUDP;
	
	private global::Gtk.Label GtkLabel8;
	
	private global::Gtk.Frame frameFilterCap;
	
	private global::Gtk.Alignment containerFilterCap;
	
	private global::Gtk.Label GtkLabel9;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.CheckButton cbSelectAllUDP;
	
	private global::Gtk.CheckButton cbSelectAllCap;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.VBox vboxInspector;
	
	private global::Gtk.Notebook tabsRequst;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView txtRequest;
	
	private global::Gtk.Label label7;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TextView txtRequestRaw;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow2;
	
	private global::Gtk.TextView txtRequestNotation;
	
	private global::Gtk.Label label8;
	
	private global::Gtk.Notebook tabsRequst1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow3;
	
	private global::Gtk.TextView txtResponse;
	
	private global::Gtk.Label label9;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow4;
	
	private global::Gtk.TextView txtResponseRaw;
	
	private global::Gtk.Label label11;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow5;
	
	private global::Gtk.TextView txtResponseNotation;
	
	private global::Gtk.Label label12;
	
	private global::Gtk.Label label10;
	
	private global::Gtk.VBox vboxPlugins;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Button btnLoadPlugin;
	
	private global::Gtk.ScrolledWindow scrolledwindowPlugin;
	
	private global::Gtk.Label label13;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, "<Alt>f");
		this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.ExitAction, "<Control>q");
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), global::Mono.Unix.Catalog.GetString ("Shows the wonderful creator info"), null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.OpenAction = new global::Gtk.Action ("OpenAction", global::Mono.Unix.Catalog.GetString ("Open.."), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Session...");
		w1.Add (this.OpenAction, "<Control>o");
		this.SaveAction = new global::Gtk.Action ("SaveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, null);
		this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Session");
		w1.Add (this.SaveAction, "<Control>s");
		this.SaveAsAction = new global::Gtk.Action ("SaveAsAction", global::Mono.Unix.Catalog.GetString ("Save As..."), null, null);
		this.SaveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Session As...");
		w1.Add (this.SaveAsAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Grid Proxy");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource ("GridProxyGUI.libomv.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.AllowShrink = true;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vboxMenuMain = new global::Gtk.VBox ();
		this.vboxMenuMain.Name = "vboxMenuMain";
		this.vboxMenuMain.Spacing = 6;
		// Container child vboxMenuMain.Gtk.Box+BoxChild
		this.hboxMenu = new global::Gtk.HBox ();
		this.hboxMenu.Name = "hboxMenu";
		this.hboxMenu.Spacing = 6;
		this.hboxMenu.BorderWidth = ((uint)(3));
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment2.Name = "alignment2";
		// Container child alignment2.Gtk.Container+ContainerChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menuMain'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction' action='SaveAction'/><menuitem name='SaveAsAction' action='SaveAsAction'/><separator/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menuMain = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menuMain")));
		this.menuMain.Name = "menuMain";
		this.alignment2.Add (this.menuMain);
		this.hboxMenu.Add (this.alignment2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.alignment2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.menuSeparator = new global::Gtk.VSeparator ();
		this.menuSeparator.Name = "menuSeparator";
		this.hboxMenu.Add (this.menuSeparator);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.menuSeparator]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Listen IP Address:");
		this.hboxMenu.Add (this.label1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.label1]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.cbListen = global::Gtk.ComboBoxEntry.NewText ();
		this.cbListen.WidthRequest = 120;
		this.cbListen.Name = "cbListen";
		this.hboxMenu.Add (this.cbListen);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.cbListen]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Port");
		this.hboxMenu.Add (this.label2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.label2]));
		w7.Position = 4;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.txtPort = new global::Gtk.Entry ();
		this.txtPort.WidthRequest = 50;
		this.txtPort.CanFocus = true;
		this.txtPort.Name = "txtPort";
		this.txtPort.Text = global::Mono.Unix.Catalog.GetString ("8080");
		this.txtPort.IsEditable = true;
		this.txtPort.MaxLength = 5;
		this.txtPort.InvisibleChar = '●';
		this.hboxMenu.Add (this.txtPort);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.txtPort]));
		w8.Position = 5;
		w8.Expand = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Login URL");
		this.hboxMenu.Add (this.label3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.label3]));
		w9.Position = 6;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.cbLoginURL = global::Gtk.ComboBoxEntry.NewText ();
		this.cbLoginURL.WidthRequest = 300;
		this.cbLoginURL.Name = "cbLoginURL";
		this.hboxMenu.Add (this.cbLoginURL);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.cbLoginURL]));
		w10.Position = 7;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hboxMenu.Gtk.Box+BoxChild
		this.btnStart = new global::Gtk.Button ();
		this.btnStart.CanFocus = true;
		this.btnStart.Name = "btnStart";
		this.btnStart.UseUnderline = true;
		this.btnStart.Label = global::Mono.Unix.Catalog.GetString ("Start Proxy");
		this.hboxMenu.Add (this.btnStart);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxMenu [this.btnStart]));
		w11.Position = 8;
		w11.Expand = false;
		w11.Fill = false;
		this.vboxMenuMain.Add (this.hboxMenu);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxMenuMain [this.hboxMenu]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vboxMenuMain.Gtk.Box+BoxChild
		this.mainSplit = new global::Gtk.HPaned ();
		this.mainSplit.CanFocus = true;
		this.mainSplit.Name = "mainSplit";
		this.mainSplit.Position = 600;
		// Container child mainSplit.Gtk.Paned+PanedChild
		this.vboxSessions = new global::Gtk.VBox ();
		this.vboxSessions.Name = "vboxSessions";
		this.vboxSessions.Spacing = 6;
		// Container child vboxSessions.Gtk.Box+BoxChild
		this.sessionLogScroller = new global::Gtk.ScrolledWindow ();
		this.sessionLogScroller.CanFocus = true;
		this.sessionLogScroller.Name = "sessionLogScroller";
		this.sessionLogScroller.ShadowType = ((global::Gtk.ShadowType)(1));
		this.vboxSessions.Add (this.sessionLogScroller);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxSessions [this.sessionLogScroller]));
		w13.Position = 0;
		// Container child vboxSessions.Gtk.Box+BoxChild
		this.hboxSessionBottom = new global::Gtk.HBox ();
		this.hboxSessionBottom.Name = "hboxSessionBottom";
		this.hboxSessionBottom.Spacing = 6;
		// Container child hboxSessionBottom.Gtk.Box+BoxChild
		this.cbAutoScroll = new global::Gtk.CheckButton ();
		this.cbAutoScroll.CanFocus = true;
		this.cbAutoScroll.Name = "cbAutoScroll";
		this.cbAutoScroll.Label = global::Mono.Unix.Catalog.GetString ("Auto Scroll");
		this.cbAutoScroll.Active = true;
		this.cbAutoScroll.DrawIndicator = true;
		this.cbAutoScroll.UseUnderline = true;
		this.hboxSessionBottom.Add (this.cbAutoScroll);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hboxSessionBottom [this.cbAutoScroll]));
		w14.Position = 0;
		this.vboxSessions.Add (this.hboxSessionBottom);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxSessions [this.hboxSessionBottom]));
		w15.Position = 1;
		w15.Expand = false;
		w15.Fill = false;
		this.mainSplit.Add (this.vboxSessions);
		global::Gtk.Paned.PanedChild w16 = ((global::Gtk.Paned.PanedChild)(this.mainSplit [this.vboxSessions]));
		w16.Resize = false;
		// Container child mainSplit.Gtk.Paned+PanedChild
		this.tabsMain = new global::Gtk.Notebook ();
		this.tabsMain.CanFocus = true;
		this.tabsMain.Name = "tabsMain";
		this.tabsMain.CurrentPage = 3;
		// Container child tabsMain.Gtk.Notebook+NotebookChild
		this.vboxLog = new global::Gtk.VBox ();
		this.vboxLog.Name = "vboxLog";
		this.vboxLog.Spacing = 6;
		// Container child vboxLog.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Homogeneous = true;
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.lblUDPIn = new global::Gtk.Label ();
		this.lblUDPIn.Name = "lblUDPIn";
		this.lblUDPIn.LabelProp = global::Mono.Unix.Catalog.GetString ("Packets In 0 (0 bytes)");
		this.vbox1.Add (this.lblUDPIn);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.lblUDPIn]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.lblUDPOut = new global::Gtk.Label ();
		this.lblUDPOut.Name = "lblUDPOut";
		this.lblUDPOut.LabelProp = global::Mono.Unix.Catalog.GetString ("Packets Out 0 (0 bytes)");
		this.vbox1.Add (this.lblUDPOut);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.lblUDPOut]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.lblUDPTotal = new global::Gtk.Label ();
		this.lblUDPTotal.Name = "lblUDPTotal";
		this.lblUDPTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Packets Total 0 (0 bytes)");
		this.vbox1.Add (this.lblUDPTotal);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.lblUDPTotal]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.GtkAlignment2.Add (this.vbox1);
		this.frame1.Add (this.GtkAlignment2);
		this.GtkLabel5 = new global::Gtk.Label ();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("UDP Packets");
		this.frame1.LabelWidget = this.GtkLabel5;
		this.hbox5.Add (this.frame1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.frame1]));
		w22.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lblCapIn = new global::Gtk.Label ();
		this.lblCapIn.Name = "lblCapIn";
		this.lblCapIn.LabelProp = global::Mono.Unix.Catalog.GetString ("Caps In 0 (0 bytes)");
		this.vbox2.Add (this.lblCapIn);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lblCapIn]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lblCapOut = new global::Gtk.Label ();
		this.lblCapOut.Name = "lblCapOut";
		this.lblCapOut.LabelProp = global::Mono.Unix.Catalog.GetString ("Caps Out 0 (0 bytes)");
		this.vbox2.Add (this.lblCapOut);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lblCapOut]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lblCapTotal = new global::Gtk.Label ();
		this.lblCapTotal.Name = "lblCapTotal";
		this.lblCapTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Caps Total 0 (0 bytes)");
		this.vbox2.Add (this.lblCapTotal);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lblCapTotal]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		this.GtkAlignment3.Add (this.vbox2);
		this.frame2.Add (this.GtkAlignment3);
		this.GtkLabel12 = new global::Gtk.Label ();
		this.GtkLabel12.Name = "GtkLabel12";
		this.GtkLabel12.LabelProp = global::Mono.Unix.Catalog.GetString ("Caps Messages");
		this.frame2.LabelWidget = this.GtkLabel12;
		this.hbox5.Add (this.frame2);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.frame2]));
		w28.Position = 1;
		this.vboxLog.Add (this.hbox5);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vboxLog [this.hbox5]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vboxLog.Gtk.Box+BoxChild
		this.logFileScroller = new global::Gtk.ScrolledWindow ();
		this.logFileScroller.Name = "logFileScroller";
		this.logFileScroller.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child logFileScroller.Gtk.Container+ContainerChild
		this.txtSummary = new global::Gtk.TextView ();
		this.txtSummary.CanFocus = true;
		this.txtSummary.Name = "txtSummary";
		this.txtSummary.Editable = false;
		this.txtSummary.WrapMode = ((global::Gtk.WrapMode)(2));
		this.logFileScroller.Add (this.txtSummary);
		this.vboxLog.Add (this.logFileScroller);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vboxLog [this.logFileScroller]));
		w31.Position = 1;
		this.tabsMain.Add (this.vboxLog);
		// Notebook tab
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Summary");
		this.tabsMain.SetTabLabel (this.vboxLog, this.label4);
		this.label4.ShowAll ();
		// Container child tabsMain.Gtk.Notebook+NotebookChild
		this.hboxFilter = new global::Gtk.VBox ();
		this.hboxFilter.Name = "hboxFilter";
		this.hboxFilter.Spacing = 6;
		// Container child hboxFilter.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnLoadFilters = new global::Gtk.Button ();
		this.btnLoadFilters.CanFocus = true;
		this.btnLoadFilters.Name = "btnLoadFilters";
		this.btnLoadFilters.UseUnderline = true;
		this.btnLoadFilters.Label = global::Mono.Unix.Catalog.GetString ("Load");
		global::Gtk.Image w33 = new global::Gtk.Image ();
		w33.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
		this.btnLoadFilters.Image = w33;
		this.hbox2.Add (this.btnLoadFilters);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnLoadFilters]));
		w34.Position = 0;
		w34.Expand = false;
		w34.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnSaveFilters = new global::Gtk.Button ();
		this.btnSaveFilters.CanFocus = true;
		this.btnSaveFilters.Name = "btnSaveFilters";
		this.btnSaveFilters.UseUnderline = true;
		this.btnSaveFilters.Label = global::Mono.Unix.Catalog.GetString ("Save");
		global::Gtk.Image w35 = new global::Gtk.Image ();
		w35.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
		this.btnSaveFilters.Image = w35;
		this.hbox2.Add (this.btnSaveFilters);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnSaveFilters]));
		w36.Position = 1;
		w36.Expand = false;
		w36.Fill = false;
		this.hboxFilter.Add (this.hbox2);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hboxFilter [this.hbox2]));
		w37.Position = 0;
		w37.Expand = false;
		w37.Fill = false;
		// Container child hboxFilter.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Homogeneous = true;
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.frameFilterUDP = new global::Gtk.Frame ();
		this.frameFilterUDP.Name = "frameFilterUDP";
		this.frameFilterUDP.ShadowType = ((global::Gtk.ShadowType)(0));
		this.frameFilterUDP.LabelYalign = 0F;
		// Container child frameFilterUDP.Gtk.Container+ContainerChild
		this.containerFilterUDP = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.containerFilterUDP.Name = "containerFilterUDP";
		this.containerFilterUDP.LeftPadding = ((uint)(12));
		this.frameFilterUDP.Add (this.containerFilterUDP);
		this.GtkLabel8 = new global::Gtk.Label ();
		this.GtkLabel8.Name = "GtkLabel8";
		this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("UDP Packets & Login");
		this.frameFilterUDP.LabelWidget = this.GtkLabel8;
		this.hbox3.Add (this.frameFilterUDP);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frameFilterUDP]));
		w39.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.frameFilterCap = new global::Gtk.Frame ();
		this.frameFilterCap.Name = "frameFilterCap";
		this.frameFilterCap.ShadowType = ((global::Gtk.ShadowType)(0));
		this.frameFilterCap.LabelYalign = 0F;
		// Container child frameFilterCap.Gtk.Container+ContainerChild
		this.containerFilterCap = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.containerFilterCap.Name = "containerFilterCap";
		this.containerFilterCap.LeftPadding = ((uint)(12));
		this.frameFilterCap.Add (this.containerFilterCap);
		this.GtkLabel9 = new global::Gtk.Label ();
		this.GtkLabel9.Name = "GtkLabel9";
		this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("Capabilities & EventQueue Messages");
		this.frameFilterCap.LabelWidget = this.GtkLabel9;
		this.hbox3.Add (this.frameFilterCap);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frameFilterCap]));
		w41.Position = 1;
		this.hboxFilter.Add (this.hbox3);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hboxFilter [this.hbox3]));
		w42.Position = 1;
		// Container child hboxFilter.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Homogeneous = true;
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.cbSelectAllUDP = new global::Gtk.CheckButton ();
		this.cbSelectAllUDP.CanFocus = true;
		this.cbSelectAllUDP.Name = "cbSelectAllUDP";
		this.cbSelectAllUDP.Label = global::Mono.Unix.Catalog.GetString ("Select/Uncheck All");
		this.cbSelectAllUDP.DrawIndicator = true;
		this.cbSelectAllUDP.UseUnderline = true;
		this.hbox4.Add (this.cbSelectAllUDP);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.cbSelectAllUDP]));
		w43.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.cbSelectAllCap = new global::Gtk.CheckButton ();
		this.cbSelectAllCap.CanFocus = true;
		this.cbSelectAllCap.Name = "cbSelectAllCap";
		this.cbSelectAllCap.Label = global::Mono.Unix.Catalog.GetString ("Select/Uncheck All");
		this.cbSelectAllCap.DrawIndicator = true;
		this.cbSelectAllCap.UseUnderline = true;
		this.hbox4.Add (this.cbSelectAllCap);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.cbSelectAllCap]));
		w44.Position = 1;
		this.hboxFilter.Add (this.hbox4);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hboxFilter [this.hbox4]));
		w45.PackType = ((global::Gtk.PackType)(1));
		w45.Position = 2;
		w45.Expand = false;
		w45.Fill = false;
		this.tabsMain.Add (this.hboxFilter);
		global::Gtk.Notebook.NotebookChild w46 = ((global::Gtk.Notebook.NotebookChild)(this.tabsMain [this.hboxFilter]));
		w46.Position = 1;
		// Notebook tab
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Filters");
		this.tabsMain.SetTabLabel (this.hboxFilter, this.label5);
		this.label5.ShowAll ();
		// Container child tabsMain.Gtk.Notebook+NotebookChild
		this.vboxInspector = new global::Gtk.VBox ();
		this.vboxInspector.Name = "vboxInspector";
		this.vboxInspector.Spacing = 6;
		// Container child vboxInspector.Gtk.Box+BoxChild
		this.tabsRequst = new global::Gtk.Notebook ();
		this.tabsRequst.CanFocus = true;
		this.tabsRequst.Name = "tabsRequst";
		this.tabsRequst.CurrentPage = 2;
		// Container child tabsRequst.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.txtRequest = new global::Gtk.TextView ();
		this.txtRequest.CanFocus = true;
		this.txtRequest.Name = "txtRequest";
		this.txtRequest.Editable = false;
		this.GtkScrolledWindow.Add (this.txtRequest);
		this.tabsRequst.Add (this.GtkScrolledWindow);
		// Notebook tab
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Request");
		this.tabsRequst.SetTabLabel (this.GtkScrolledWindow, this.label7);
		this.label7.ShowAll ();
		// Container child tabsRequst.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.txtRequestRaw = new global::Gtk.TextView ();
		this.txtRequestRaw.CanFocus = true;
		this.txtRequestRaw.Name = "txtRequestRaw";
		this.txtRequestRaw.Editable = false;
		this.GtkScrolledWindow1.Add (this.txtRequestRaw);
		this.tabsRequst.Add (this.GtkScrolledWindow1);
		global::Gtk.Notebook.NotebookChild w50 = ((global::Gtk.Notebook.NotebookChild)(this.tabsRequst [this.GtkScrolledWindow1]));
		w50.Position = 1;
		// Notebook tab
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Raw");
		this.tabsRequst.SetTabLabel (this.GtkScrolledWindow1, this.label6);
		this.label6.ShowAll ();
		// Container child tabsRequst.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.txtRequestNotation = new global::Gtk.TextView ();
		this.txtRequestNotation.CanFocus = true;
		this.txtRequestNotation.Name = "txtRequestNotation";
		this.txtRequestNotation.Editable = false;
		this.GtkScrolledWindow2.Add (this.txtRequestNotation);
		this.tabsRequst.Add (this.GtkScrolledWindow2);
		global::Gtk.Notebook.NotebookChild w52 = ((global::Gtk.Notebook.NotebookChild)(this.tabsRequst [this.GtkScrolledWindow2]));
		w52.Position = 2;
		// Notebook tab
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Notation");
		this.tabsRequst.SetTabLabel (this.GtkScrolledWindow2, this.label8);
		this.label8.ShowAll ();
		this.vboxInspector.Add (this.tabsRequst);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vboxInspector [this.tabsRequst]));
		w53.Position = 0;
		// Container child vboxInspector.Gtk.Box+BoxChild
		this.tabsRequst1 = new global::Gtk.Notebook ();
		this.tabsRequst1.CanFocus = true;
		this.tabsRequst1.Name = "tabsRequst1";
		this.tabsRequst1.CurrentPage = 0;
		// Container child tabsRequst1.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
		this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
		this.txtResponse = new global::Gtk.TextView ();
		this.txtResponse.CanFocus = true;
		this.txtResponse.Name = "txtResponse";
		this.txtResponse.Editable = false;
		this.GtkScrolledWindow3.Add (this.txtResponse);
		this.tabsRequst1.Add (this.GtkScrolledWindow3);
		// Notebook tab
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Response");
		this.tabsRequst1.SetTabLabel (this.GtkScrolledWindow3, this.label9);
		this.label9.ShowAll ();
		// Container child tabsRequst1.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
		this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
		this.txtResponseRaw = new global::Gtk.TextView ();
		this.txtResponseRaw.CanFocus = true;
		this.txtResponseRaw.Name = "txtResponseRaw";
		this.txtResponseRaw.Editable = false;
		this.GtkScrolledWindow4.Add (this.txtResponseRaw);
		this.tabsRequst1.Add (this.GtkScrolledWindow4);
		global::Gtk.Notebook.NotebookChild w57 = ((global::Gtk.Notebook.NotebookChild)(this.tabsRequst1 [this.GtkScrolledWindow4]));
		w57.Position = 1;
		// Notebook tab
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Raw");
		this.tabsRequst1.SetTabLabel (this.GtkScrolledWindow4, this.label11);
		this.label11.ShowAll ();
		// Container child tabsRequst1.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow5 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow5.Name = "GtkScrolledWindow5";
		this.GtkScrolledWindow5.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow5.Gtk.Container+ContainerChild
		this.txtResponseNotation = new global::Gtk.TextView ();
		this.txtResponseNotation.CanFocus = true;
		this.txtResponseNotation.Name = "txtResponseNotation";
		this.txtResponseNotation.Editable = false;
		this.GtkScrolledWindow5.Add (this.txtResponseNotation);
		this.tabsRequst1.Add (this.GtkScrolledWindow5);
		global::Gtk.Notebook.NotebookChild w59 = ((global::Gtk.Notebook.NotebookChild)(this.tabsRequst1 [this.GtkScrolledWindow5]));
		w59.Position = 2;
		// Notebook tab
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Notation");
		this.tabsRequst1.SetTabLabel (this.GtkScrolledWindow5, this.label12);
		this.label12.ShowAll ();
		this.vboxInspector.Add (this.tabsRequst1);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vboxInspector [this.tabsRequst1]));
		w60.Position = 1;
		this.tabsMain.Add (this.vboxInspector);
		global::Gtk.Notebook.NotebookChild w61 = ((global::Gtk.Notebook.NotebookChild)(this.tabsMain [this.vboxInspector]));
		w61.Position = 2;
		// Notebook tab
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Inspector");
		this.tabsMain.SetTabLabel (this.vboxInspector, this.label10);
		this.label10.ShowAll ();
		// Container child tabsMain.Gtk.Notebook+NotebookChild
		this.vboxPlugins = new global::Gtk.VBox ();
		this.vboxPlugins.Name = "vboxPlugins";
		this.vboxPlugins.Spacing = 6;
		// Container child vboxPlugins.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnLoadPlugin = new global::Gtk.Button ();
		this.btnLoadPlugin.CanFocus = true;
		this.btnLoadPlugin.Name = "btnLoadPlugin";
		this.btnLoadPlugin.UseUnderline = true;
		this.btnLoadPlugin.Label = global::Mono.Unix.Catalog.GetString ("Load Plugin...");
		this.hbox1.Add (this.btnLoadPlugin);
		global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnLoadPlugin]));
		w62.Position = 0;
		w62.Expand = false;
		w62.Fill = false;
		this.vboxPlugins.Add (this.hbox1);
		global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.vboxPlugins [this.hbox1]));
		w63.Position = 0;
		w63.Expand = false;
		w63.Fill = false;
		// Container child vboxPlugins.Gtk.Box+BoxChild
		this.scrolledwindowPlugin = new global::Gtk.ScrolledWindow ();
		this.scrolledwindowPlugin.CanFocus = true;
		this.scrolledwindowPlugin.Name = "scrolledwindowPlugin";
		this.scrolledwindowPlugin.ShadowType = ((global::Gtk.ShadowType)(1));
		this.vboxPlugins.Add (this.scrolledwindowPlugin);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vboxPlugins [this.scrolledwindowPlugin]));
		w64.Position = 1;
		this.tabsMain.Add (this.vboxPlugins);
		global::Gtk.Notebook.NotebookChild w65 = ((global::Gtk.Notebook.NotebookChild)(this.tabsMain [this.vboxPlugins]));
		w65.Position = 3;
		// Notebook tab
		this.label13 = new global::Gtk.Label ();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Plugins");
		this.tabsMain.SetTabLabel (this.vboxPlugins, this.label13);
		this.label13.ShowAll ();
		this.mainSplit.Add (this.tabsMain);
		this.vboxMenuMain.Add (this.mainSplit);
		global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.vboxMenuMain [this.mainSplit]));
		w67.Position = 1;
		this.Add (this.vboxMenuMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1211;
		this.DefaultHeight = 650;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.ExitAction.Activated += new global::System.EventHandler (this.OnExitActionActivated);
		this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.OpenAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.SaveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.SaveAsAction.Activated += new global::System.EventHandler (this.OnSaveAsActionActivated);
		this.btnStart.Clicked += new global::System.EventHandler (this.OnBtnStartClicked);
		this.cbAutoScroll.Toggled += new global::System.EventHandler (this.OnCbAutoScrollToggled);
		this.cbSelectAllUDP.Toggled += new global::System.EventHandler (this.OnCbSelectAllUDPToggled);
		this.cbSelectAllCap.Toggled += new global::System.EventHandler (this.OnCbSelectAllCapToggled);
		this.btnLoadPlugin.Clicked += new global::System.EventHandler (this.OnBtnLoadPluginClicked);
	}
}
