using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Youtube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailView']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeThumbnailView", DoNotGenerateAcw=true)]
	public sealed partial class YouTubeThumbnailView : global::Android.Widget.ImageView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailView.OnInitializedListener']"
		[Register ("com/google/android/youtube/player/YouTubeThumbnailView$OnInitializedListener", "", "Com.Google.Android.Youtube.Player.YouTubeThumbnailView/IOnInitializedListenerInvoker")]
		public partial interface IOnInitializedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailView.OnInitializedListener']/method[@name='onInitializationFailure' and count(parameter)=2 and parameter[1][@type='com.google.android.youtube.player.YouTubeThumbnailView'] and parameter[2][@type='com.google.android.youtube.player.YouTubeInitializationResult']]"
			[Register ("onInitializationFailure", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeInitializationResult;)V", "GetOnInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_Handler:Com.Google.Android.Youtube.Player.YouTubeThumbnailView/IOnInitializedListenerInvoker, YoutubePlayer")]
			void OnInitializationFailure (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailView.OnInitializedListener']/method[@name='onInitializationSuccess' and count(parameter)=2 and parameter[1][@type='com.google.android.youtube.player.YouTubeThumbnailView'] and parameter[2][@type='com.google.android.youtube.player.YouTubeThumbnailLoader']]"
			[Register ("onInitializationSuccess", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeThumbnailLoader;)V", "GetOnInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_Handler:Com.Google.Android.Youtube.Player.YouTubeThumbnailView/IOnInitializedListenerInvoker, YoutubePlayer")]
			void OnInitializationSuccess (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader p1);

		}

		[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeThumbnailView$OnInitializedListener", DoNotGenerateAcw=true)]
		internal class IOnInitializedListenerInvoker : global::Java.Lang.Object, IOnInitializedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeThumbnailView$OnInitializedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnInitializedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnInitializedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInitializedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubeThumbnailView.OnInitializedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInitializedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_;
#pragma warning disable 0169
			static Delegate GetOnInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_Handler ()
			{
				if (cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_ == null)
					cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_);
				return cb_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_;
			}

			static void n_OnInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView.IOnInitializedListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView.IOnInitializedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInitializationFailure (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_;
			public unsafe void OnInitializationFailure (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult p1)
			{
				if (id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_ == IntPtr.Zero)
					id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_ = JNIEnv.GetMethodID (class_ref, "onInitializationFailure", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeInitializationResult;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onInitializationFailure_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeInitializationResult_, __args);
			}

			static Delegate cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_;
#pragma warning disable 0169
			static Delegate GetOnInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_Handler ()
			{
				if (cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ == null)
					cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_);
				return cb_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_;
			}

			static void n_OnInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView.IOnInitializedListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView.IOnInitializedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader p1 = (global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInitializationSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_;
			public unsafe void OnInitializationSuccess (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader p1)
			{
				if (id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ == IntPtr.Zero)
					id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ = JNIEnv.GetMethodID (class_ref, "onInitializationSuccess", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeThumbnailLoader;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onInitializationSuccess_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_, __args);
			}

		}

		public partial class InitializationFailureEventArgs : global::System.EventArgs {

			public InitializationFailureEventArgs (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0;
			public global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView P0 {
				get { return p0; }
			}

			global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult p1;
			public global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult P1 {
				get { return p1; }
			}
		}

		public partial class InitializationSuccessEventArgs : global::System.EventArgs {

			public InitializationSuccessEventArgs (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0;
			public global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView P0 {
				get { return p0; }
			}

			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader p1;
			public global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubeThumbnailView_OnInitializedListenerImplementor")]
		internal sealed partial class IOnInitializedListenerImplementor : global::Java.Lang.Object, IOnInitializedListener {

			object sender;

			public IOnInitializedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubeThumbnailView_OnInitializedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InitializationFailureEventArgs> OnInitializationFailureHandler;
#pragma warning restore 0649

			public void OnInitializationFailure (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult p1)
			{
				var __h = OnInitializationFailureHandler;
				if (__h != null)
					__h (sender, new InitializationFailureEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<InitializationSuccessEventArgs> OnInitializationSuccessHandler;
#pragma warning restore 0649

			public void OnInitializationSuccess (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader p1)
			{
				var __h = OnInitializationSuccessHandler;
				if (__h != null)
					__h (sender, new InitializationSuccessEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnInitializedListenerImplementor value)
			{
				return value.OnInitializationFailureHandler == null && value.OnInitializationSuccessHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeThumbnailView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubeThumbnailView); }
		}

		internal YouTubeThumbnailView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailView']/constructor[@name='YouTubeThumbnailView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe YouTubeThumbnailView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (YouTubeThumbnailView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailView']/constructor[@name='YouTubeThumbnailView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe YouTubeThumbnailView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (YouTubeThumbnailView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailView']/constructor[@name='YouTubeThumbnailView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe YouTubeThumbnailView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (YouTubeThumbnailView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubeThumbnailView_OnInitializedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailView']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.youtube.player.YouTubeThumbnailView.OnInitializedListener']]"
		[Register ("initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubeThumbnailView$OnInitializedListener;)V", "")]
		public unsafe void Initialize (string p0, global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView.IOnInitializedListener p1)
		{
			if (id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubeThumbnailView_OnInitializedListener_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubeThumbnailView_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubeThumbnailView$OnInitializedListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubeThumbnailView_OnInitializedListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
