package md5b025ea164c3f5791375e74ed6ef9accd;


public class VolumeManagerImplementation
	extends android.support.v4.media.VolumeProviderCompat.Callback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onVolumeChanged:(Landroid/support/v4/media/VolumeProviderCompat;)V:GetOnVolumeChanged_Landroid_support_v4_media_VolumeProviderCompat_Handler\n" +
			"";
		mono.android.Runtime.register ("Plugin.MediaManager.VolumeManagerImplementation, Plugin.MediaManager", VolumeManagerImplementation.class, __md_methods);
	}


	public VolumeManagerImplementation ()
	{
		super ();
		if (getClass () == VolumeManagerImplementation.class)
			mono.android.TypeManager.Activate ("Plugin.MediaManager.VolumeManagerImplementation, Plugin.MediaManager", "", this, new java.lang.Object[] {  });
	}


	public void onVolumeChanged (android.support.v4.media.VolumeProviderCompat p0)
	{
		n_onVolumeChanged (p0);
	}

	private native void n_onVolumeChanged (android.support.v4.media.VolumeProviderCompat p0);

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
