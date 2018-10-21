package md507edd78cce29aa8c0cfeca29adf1bea8;


public class SlidePopupViewRendererDroid
	extends md51558244f76c53b6aeda52c8a337f2c37.VisualElementRenderer_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SlideOverKit.Droid.SlidePopupViewRendererDroid, SlideOverKit.Droid", SlidePopupViewRendererDroid.class, __md_methods);
	}


	public SlidePopupViewRendererDroid (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SlidePopupViewRendererDroid.class)
			mono.android.TypeManager.Activate ("SlideOverKit.Droid.SlidePopupViewRendererDroid, SlideOverKit.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public SlidePopupViewRendererDroid (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SlidePopupViewRendererDroid.class)
			mono.android.TypeManager.Activate ("SlideOverKit.Droid.SlidePopupViewRendererDroid, SlideOverKit.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SlidePopupViewRendererDroid (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SlidePopupViewRendererDroid.class)
			mono.android.TypeManager.Activate ("SlideOverKit.Droid.SlidePopupViewRendererDroid, SlideOverKit.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
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
