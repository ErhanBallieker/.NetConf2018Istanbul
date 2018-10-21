package md53a3fda0e8cc78eaa54012c6d27fee3a7;


public class SfTabViewRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Syncfusion.XForms.Android.TabView.SfTabViewRenderer, Syncfusion.SfTabView.XForms.Android", SfTabViewRenderer.class, __md_methods);
	}


	public SfTabViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SfTabViewRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.TabView.SfTabViewRenderer, Syncfusion.SfTabView.XForms.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SfTabViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfTabViewRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.TabView.SfTabViewRenderer, Syncfusion.SfTabView.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SfTabViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfTabViewRenderer.class)
			mono.android.TypeManager.Activate ("Syncfusion.XForms.Android.TabView.SfTabViewRenderer, Syncfusion.SfTabView.XForms.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
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
