package md5a0edc2015195b8342d5cb2f8148cb606;


public class SfPicker
	extends android.view.ViewGroup
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isEnabled:()Z:GetIsEnabledHandler\n" +
			"n_setEnabled:(Z)V:GetSetEnabled_ZHandler\n" +
			"n_setPadding:(IIII)V:GetSetPadding_IIIIHandler\n" +
			"n_findFocus:()Landroid/view/View;:GetFindFocusHandler\n" +
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_onAttachedToWindow:()V:GetOnAttachedToWindowHandler\n" +
			"n_onDetachedFromWindow:()V:GetOnDetachedFromWindowHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.Android.DataForm.Editors.SfPicker, Syncfusion.SfDataForm.XForms.Android", SfPicker.class, __md_methods);
	}


	public SfPicker (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfPicker.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.Editors.SfPicker, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SfPicker (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfPicker.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.Editors.SfPicker, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SfPicker (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfPicker.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.Editors.SfPicker, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SfPicker (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == SfPicker.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.Editors.SfPicker, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean isEnabled ()
	{
		return n_isEnabled ();
	}

	private native boolean n_isEnabled ();


	public void setEnabled (boolean p0)
	{
		n_setEnabled (p0);
	}

	private native void n_setEnabled (boolean p0);


	public void setPadding (int p0, int p1, int p2, int p3)
	{
		n_setPadding (p0, p1, p2, p3);
	}

	private native void n_setPadding (int p0, int p1, int p2, int p3);


	public android.view.View findFocus ()
	{
		return n_findFocus ();
	}

	private native android.view.View n_findFocus ();


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void onAttachedToWindow ()
	{
		n_onAttachedToWindow ();
	}

	private native void n_onAttachedToWindow ();


	public void onDetachedFromWindow ()
	{
		n_onDetachedFromWindow ();
	}

	private native void n_onDetachedFromWindow ();

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
