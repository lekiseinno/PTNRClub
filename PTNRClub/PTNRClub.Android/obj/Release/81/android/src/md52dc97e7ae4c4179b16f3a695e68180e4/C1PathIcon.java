package md52dc97e7ae4c4179b16f3a695e68180e4;


public class C1PathIcon
	extends md52dc97e7ae4c4179b16f3a695e68180e4.C1VectorIcon
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("C1.Android.Core.C1PathIcon, C1.Android.Core", C1PathIcon.class, __md_methods);
	}


	public C1PathIcon (android.content.Context p0)
	{
		super (p0);
		if (getClass () == C1PathIcon.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1PathIcon, C1.Android.Core", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public C1PathIcon (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == C1PathIcon.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1PathIcon, C1.Android.Core", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public C1PathIcon (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == C1PathIcon.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1PathIcon, C1.Android.Core", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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