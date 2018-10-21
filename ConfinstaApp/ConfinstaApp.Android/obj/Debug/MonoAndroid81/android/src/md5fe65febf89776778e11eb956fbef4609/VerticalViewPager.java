package md5fe65febf89776778e11eb956fbef4609;


public class VerticalViewPager
	extends android.support.v4.view.ViewPager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_canScrollHorizontally:(I)Z:GetCanScrollHorizontally_IHandler\n" +
			"n_canScrollVertically:(I)Z:GetCanScrollVertically_IHandler\n" +
			"n_onInterceptTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnInterceptTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Com.Android.DeskClock.VerticalViewPager, Com.Android.DeskClock", VerticalViewPager.class, __md_methods);
	}


	public VerticalViewPager (android.content.Context p0)
	{
		super (p0);
		if (getClass () == VerticalViewPager.class)
			mono.android.TypeManager.Activate ("Com.Android.DeskClock.VerticalViewPager, Com.Android.DeskClock", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public VerticalViewPager (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == VerticalViewPager.class)
			mono.android.TypeManager.Activate ("Com.Android.DeskClock.VerticalViewPager, Com.Android.DeskClock", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean canScrollHorizontally (int p0)
	{
		return n_canScrollHorizontally (p0);
	}

	private native boolean n_canScrollHorizontally (int p0);


	public boolean canScrollVertically (int p0)
	{
		return n_canScrollVertically (p0);
	}

	private native boolean n_canScrollVertically (int p0);


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
