package md5f50c1c42355e4d90671bfc4292997460;


public class CatMonochromeView
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("iFashion_3.Views.CatMonochromeView, iFashion_3", CatMonochromeView.class, __md_methods);
	}


	public CatMonochromeView ()
	{
		super ();
		if (getClass () == CatMonochromeView.class)
			mono.android.TypeManager.Activate ("iFashion_3.Views.CatMonochromeView, iFashion_3", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
