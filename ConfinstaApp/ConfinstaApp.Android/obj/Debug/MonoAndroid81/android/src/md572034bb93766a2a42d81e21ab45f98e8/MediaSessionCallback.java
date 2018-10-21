package md572034bb93766a2a42d81e21ab45f98e8;


public class MediaSessionCallback
	extends android.support.v4.media.session.MediaSessionCompat.Callback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPlay:()V:GetOnPlayHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onSkipToNext:()V:GetOnSkipToNextHandler\n" +
			"n_onSkipToPrevious:()V:GetOnSkipToPreviousHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"n_onFastForward:()V:GetOnFastForwardHandler\n" +
			"n_onMediaButtonEvent:(Landroid/content/Intent;)Z:GetOnMediaButtonEvent_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("Plugin.MediaManager.MediaSession.MediaSessionCallback, Plugin.MediaManager", MediaSessionCallback.class, __md_methods);
	}


	public MediaSessionCallback ()
	{
		super ();
		if (getClass () == MediaSessionCallback.class)
			mono.android.TypeManager.Activate ("Plugin.MediaManager.MediaSession.MediaSessionCallback, Plugin.MediaManager", "", this, new java.lang.Object[] {  });
	}


	public void onPlay ()
	{
		n_onPlay ();
	}

	private native void n_onPlay ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onSkipToNext ()
	{
		n_onSkipToNext ();
	}

	private native void n_onSkipToNext ();


	public void onSkipToPrevious ()
	{
		n_onSkipToPrevious ();
	}

	private native void n_onSkipToPrevious ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();


	public void onFastForward ()
	{
		n_onFastForward ();
	}

	private native void n_onFastForward ();


	public boolean onMediaButtonEvent (android.content.Intent p0)
	{
		return n_onMediaButtonEvent (p0);
	}

	private native boolean n_onMediaButtonEvent (android.content.Intent p0);

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
