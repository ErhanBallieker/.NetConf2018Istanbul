package md5b025ea164c3f5791375e74ed6ef9accd;


public class MediaServiceBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Plugin.MediaManager.MediaServiceBinder, Plugin.MediaManager", MediaServiceBinder.class, __md_methods);
	}


	public MediaServiceBinder ()
	{
		super ();
		if (getClass () == MediaServiceBinder.class)
			mono.android.TypeManager.Activate ("Plugin.MediaManager.MediaServiceBinder, Plugin.MediaManager", "", this, new java.lang.Object[] {  });
	}

	public MediaServiceBinder (md5b025ea164c3f5791375e74ed6ef9accd.MediaServiceBase p0)
	{
		super ();
		if (getClass () == MediaServiceBinder.class)
			mono.android.TypeManager.Activate ("Plugin.MediaManager.MediaServiceBinder, Plugin.MediaManager", "Plugin.MediaManager.MediaServiceBase, Plugin.MediaManager", this, new java.lang.Object[] { p0 });
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
