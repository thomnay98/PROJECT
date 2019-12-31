package md5bcade622865cf5910507145da52973f0;


public class ScrollViewer
	extends android.widget.ScrollView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_isNestedScrollingEnabled:()Z:GetIsNestedScrollingEnabledHandler\n" +
			"n_requestChildRectangleOnScreen:(Landroid/view/View;Landroid/graphics/Rect;Z)Z:GetRequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_ZHandler\n" +
			"n_onScrollChanged:(IIII)V:GetOnScrollChanged_IIIIHandler\n" +
			"n_measureChild:(Landroid/view/View;II)V:GetMeasureChild_Landroid_view_View_IIHandler\n" +
			"n_measureChildWithMargins:(Landroid/view/View;IIII)V:GetMeasureChildWithMargins_Landroid_view_View_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.Android.DataForm.ScrollViewer, Syncfusion.SfDataForm.XForms.Android", ScrollViewer.class, __md_methods);
	}


	public ScrollViewer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ScrollViewer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.ScrollViewer, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ScrollViewer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ScrollViewer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.ScrollViewer, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ScrollViewer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ScrollViewer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.ScrollViewer, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ScrollViewer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ScrollViewer.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.ScrollViewer, Syncfusion.SfDataForm.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean isNestedScrollingEnabled ()
	{
		return n_isNestedScrollingEnabled ();
	}

	private native boolean n_isNestedScrollingEnabled ();


	public boolean requestChildRectangleOnScreen (android.view.View p0, android.graphics.Rect p1, boolean p2)
	{
		return n_requestChildRectangleOnScreen (p0, p1, p2);
	}

	private native boolean n_requestChildRectangleOnScreen (android.view.View p0, android.graphics.Rect p1, boolean p2);


	public void onScrollChanged (int p0, int p1, int p2, int p3)
	{
		n_onScrollChanged (p0, p1, p2, p3);
	}

	private native void n_onScrollChanged (int p0, int p1, int p2, int p3);


	public void measureChild (android.view.View p0, int p1, int p2)
	{
		n_measureChild (p0, p1, p2);
	}

	private native void n_measureChild (android.view.View p0, int p1, int p2);


	public void measureChildWithMargins (android.view.View p0, int p1, int p2, int p3, int p4)
	{
		n_measureChildWithMargins (p0, p1, p2, p3, p4);
	}

	private native void n_measureChildWithMargins (android.view.View p0, int p1, int p2, int p3, int p4);

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
