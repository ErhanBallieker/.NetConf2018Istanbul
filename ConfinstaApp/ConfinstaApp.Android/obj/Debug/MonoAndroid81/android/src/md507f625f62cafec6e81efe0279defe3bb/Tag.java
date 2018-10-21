package md507f625f62cafec6e81efe0279defe3bb;


public class Tag
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CarouselView.FormsPlugin.Android.Tag, CarouselView.FormsPlugin.Android", Tag.class, __md_methods);
	}


	public Tag ()
	{
		super ();
		if (getClass () == Tag.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.Tag, CarouselView.FormsPlugin.Android", "", this, new java.lang.Object[] {  });
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
