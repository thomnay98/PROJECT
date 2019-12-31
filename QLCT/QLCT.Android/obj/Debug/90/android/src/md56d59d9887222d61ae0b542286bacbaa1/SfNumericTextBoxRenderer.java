package md56d59d9887222d61ae0b542286bacbaa1;


public class SfNumericTextBoxRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer,
		android.widget.TextView.OnEditorActionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onEditorAction:(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z:GetOnEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_Handler:Android.Widget.TextView/IOnEditorActionListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.SfNumericTextBox.XForms.Droid.SfNumericTextBoxRenderer, Syncfusion.SfNumericTextBox.XForms.Android", SfNumericTextBoxRenderer.class, __md_methods);
	}


	public SfNumericTextBoxRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfNumericTextBoxRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfNumericTextBox.XForms.Droid.SfNumericTextBoxRenderer, Syncfusion.SfNumericTextBox.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SfNumericTextBoxRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfNumericTextBoxRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfNumericTextBox.XForms.Droid.SfNumericTextBoxRenderer, Syncfusion.SfNumericTextBox.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfNumericTextBoxRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfNumericTextBoxRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfNumericTextBox.XForms.Droid.SfNumericTextBoxRenderer, Syncfusion.SfNumericTextBox.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public boolean onEditorAction (android.widget.TextView p0, int p1, android.view.KeyEvent p2)
	{
		return n_onEditorAction (p0, p1, p2);
	}

	private native boolean n_onEditorAction (android.widget.TextView p0, int p1, android.view.KeyEvent p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
