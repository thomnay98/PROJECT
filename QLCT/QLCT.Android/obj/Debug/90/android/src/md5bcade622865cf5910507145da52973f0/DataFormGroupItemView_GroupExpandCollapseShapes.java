package md5bcade622865cf5910507145da52973f0;


public class DataFormGroupItemView_GroupExpandCollapseShapes
	extends android.graphics.drawable.shapes.Shape
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V:GetDraw_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler\n" +
			"";
		mono.android.Runtime.register ("Syncfusion.Android.DataForm.DataFormGroupItemView+GroupExpandCollapseShapes, Syncfusion.SfDataForm.XForms.Android", DataFormGroupItemView_GroupExpandCollapseShapes.class, __md_methods);
	}


	public DataFormGroupItemView_GroupExpandCollapseShapes ()
	{
		super ();
		if (getClass () == DataFormGroupItemView_GroupExpandCollapseShapes.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.DataFormGroupItemView+GroupExpandCollapseShapes, Syncfusion.SfDataForm.XForms.Android", "", this, new java.lang.Object[] {  });
	}

	public DataFormGroupItemView_GroupExpandCollapseShapes (md5bcade622865cf5910507145da52973f0.DataFormGroupItemView p0)
	{
		super ();
		if (getClass () == DataFormGroupItemView_GroupExpandCollapseShapes.class)
			mono.android.TypeManager.Activate ("Syncfusion.Android.DataForm.DataFormGroupItemView+GroupExpandCollapseShapes, Syncfusion.SfDataForm.XForms.Android", "Syncfusion.Android.DataForm.DataFormGroupItemView, Syncfusion.SfDataForm.XForms.Android", this, new java.lang.Object[] { p0 });
	}


	public void draw (android.graphics.Canvas p0, android.graphics.Paint p1)
	{
		n_draw (p0, p1);
	}

	private native void n_draw (android.graphics.Canvas p0, android.graphics.Paint p1);

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
