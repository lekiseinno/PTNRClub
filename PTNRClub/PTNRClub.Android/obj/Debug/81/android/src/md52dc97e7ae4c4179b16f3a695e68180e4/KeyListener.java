package md52dc97e7ae4c4179b16f3a695e68180e4;


public class KeyListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnKeyListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onKey:(Landroid/view/View;ILandroid/view/KeyEvent;)Z:GetOnKey_Landroid_view_View_ILandroid_view_KeyEvent_Handler:Android.Views.View/IOnKeyListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("C1.Android.Core.KeyListener, C1.Android.Core", KeyListener.class, __md_methods);
	}


	public KeyListener ()
	{
		super ();
		if (getClass () == KeyListener.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.KeyListener, C1.Android.Core", "", this, new java.lang.Object[] {  });
	}


	public boolean onKey (android.view.View p0, int p1, android.view.KeyEvent p2)
	{
		return n_onKey (p0, p1, p2);
	}

	private native boolean n_onKey (android.view.View p0, int p1, android.view.KeyEvent p2);

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
