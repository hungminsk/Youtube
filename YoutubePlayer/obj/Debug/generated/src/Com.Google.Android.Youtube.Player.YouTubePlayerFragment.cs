using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Youtube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubePlayerFragment", DoNotGenerateAcw=true)]
	public partial class YouTubePlayerFragment : global::Android.App.Fragment, global::Com.Google.Android.Youtube.Player.IYouTubePlayerProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubePlayerFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubePlayerFragment); }
		}

		protected YouTubePlayerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']/constructor[@name='YouTubePlayerFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe YouTubePlayerFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (YouTubePlayerFragment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ == null)
				cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_);
			return cb_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
		}

		static void n_Initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Youtube.Player.YouTubePlayerFragment __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubePlayerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Youtube.Player.IYouTubePlayerOnInitializedListener p1 = (global::Com.Google.Android.Youtube.Player.IYouTubePlayerOnInitializedListener)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubePlayerOnInitializedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.youtube.player.YouTubePlayer.OnInitializedListener']]"
		[Register ("initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V", "GetInitialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_Handler")]
		public virtual unsafe void Initialize (string p0, global::Com.Google.Android.Youtube.Player.IYouTubePlayerOnInitializedListener p1)
		{
			if (id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ == IntPtr.Zero)
				id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initialize_Ljava_lang_String_Lcom_google_android_youtube_player_YouTubePlayer_OnInitializedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Ljava/lang/String;Lcom/google/android/youtube/player/YouTubePlayer$OnInitializedListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubePlayerFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/google/android/youtube/player/YouTubePlayerFragment;", "")]
		public static unsafe global::Com.Google.Android.Youtube.Player.YouTubePlayerFragment NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/google/android/youtube/player/YouTubePlayerFragment;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubePlayerFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
