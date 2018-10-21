package md507f625f62cafec6e81efe0279defe3bb;


public class VerticalViewPager
	extends md5fe65febf89776778e11eb956fbef4609.VerticalViewPager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInterceptTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnInterceptTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("CarouselView.FormsPlugin.Android.VerticalViewPager, CarouselView.FormsPlugin.Android", VerticalViewPager.class, __md_methods);
	}


	public VerticalViewPager (android.content.Context p0)
	{
		super (p0);
		if (getClass () == VerticalViewPager.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.VerticalViewPager, CarouselView.FormsPlugin.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public VerticalViewPager (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == VerticalViewPager.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.VerticalViewPager, CarouselView.FormsPlugin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onInterceptTouchEvent (android.view.MotionEvent p0)
	{
		return n_onInterceptTouchEvent (p0);
	}

	private native boolean n_onInterceptTouchEvent (android.view.MotionEvent p0);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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
