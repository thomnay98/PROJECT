package md5339388b5d95a855db923bd1d521f12e8;


public class MaterialSfAutoCompleteRenderer
	extends md5339388b5d95a855db923bd1d521f12e8.SfAutoCompleteRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Syncfusion.SfAutoComplete.XForms.Droid.MaterialSfAutoCompleteRenderer, Syncfusion.SfAutoComplete.XForms.Android", MaterialSfAutoCompleteRenderer.class, __md_methods);
	}


	public MaterialSfAutoCompleteRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialSfAutoCompleteRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfAutoComplete.XForms.Droid.MaterialSfAutoCompleteRenderer, Syncfusion.SfAutoComplete.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MaterialSfAutoCompleteRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialSfAutoCompleteRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfAutoComplete.XForms.Droid.MaterialSfAutoCompleteRenderer, Syncfusion.SfAutoComplete.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialSfAutoCompleteRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialSfAutoCompleteRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.SfAutoComplete.XForms.Droid.MaterialSfAutoCompleteRenderer, Syncfusion.SfAutoComplete.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
