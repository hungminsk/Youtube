using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Youtube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeApiServiceUtil']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeApiServiceUtil", DoNotGenerateAcw=true)]
	public sealed partial class YouTubeApiServiceUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeApiServiceUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubeApiServiceUtil); }
		}

		internal YouTubeApiServiceUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isYouTubeApiServiceAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeApiServiceUtil']/method[@name='isYouTubeApiServiceAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isYouTubeApiServiceAvailable", "(Landroid/content/Context;)Lcom/google/android/youtube/player/YouTubeInitializationResult;", "")]
		public static unsafe global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult IsYouTubeApiServiceAvailable (global::Android.Content.Context p0)
		{
			if (id_isYouTubeApiServiceAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isYouTubeApiServiceAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isYouTubeApiServiceAvailable", "(Landroid/content/Context;)Lcom/google/android/youtube/player/YouTubeInitializationResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_isYouTubeApiServiceAvailable_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
