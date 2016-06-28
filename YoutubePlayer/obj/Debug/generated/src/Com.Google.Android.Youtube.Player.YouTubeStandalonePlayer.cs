using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Youtube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeStandalonePlayer", DoNotGenerateAcw=true)]
	public sealed partial class YouTubeStandalonePlayer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeStandalonePlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubeStandalonePlayer); }
		}

		internal YouTubeStandalonePlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='createPlaylistIntent' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createPlaylistIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreatePlaylistIntent (global::Android.App.Activity p0, string p1, string p2)
		{
			if (id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createPlaylistIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='createPlaylistIntent' and count(parameter)=7 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("createPlaylistIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;IIZZ)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreatePlaylistIntent (global::Android.App.Activity p0, string p1, string p2, int p3, int p4, bool p5, bool p6)
		{
			if (id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IIZZ == IntPtr.Zero)
				id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IIZZ = JNIEnv.GetStaticMethodID (class_ref, "createPlaylistIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;IIZZ)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createPlaylistIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IIZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='createVideoIntent' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createVideoIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateVideoIntent (global::Android.App.Activity p0, string p1, string p2)
		{
			if (id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createVideoIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='createVideoIntent' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register ("createVideoIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;IZZ)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateVideoIntent (global::Android.App.Activity p0, string p1, string p2, int p3, bool p4, bool p5)
		{
			if (id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IZZ == IntPtr.Zero)
				id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IZZ = JNIEnv.GetStaticMethodID (class_ref, "createVideoIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;IZZ)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createVideoIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_IZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='createVideosIntent' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("createVideosIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/util/List;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateVideosIntent (global::Android.App.Activity p0, string p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "createVideosIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/util/List;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_IIZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='createVideosIntent' and count(parameter)=7 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("createVideosIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/util/List;IIZZ)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateVideosIntent (global::Android.App.Activity p0, string p1, global::System.Collections.Generic.IList<string> p2, int p3, int p4, bool p5, bool p6)
		{
			if (id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_IIZZ == IntPtr.Zero)
				id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_IIZZ = JNIEnv.GetStaticMethodID (class_ref, "createVideosIntent", "(Landroid/app/Activity;Ljava/lang/String;Ljava/util/List;IIZZ)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createVideosIntent_Landroid_app_Activity_Ljava_lang_String_Ljava_util_List_IIZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getReturnedInitializationResult_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeStandalonePlayer']/method[@name='getReturnedInitializationResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getReturnedInitializationResult", "(Landroid/content/Intent;)Lcom/google/android/youtube/player/YouTubeInitializationResult;", "")]
		public static unsafe global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult GetReturnedInitializationResult (global::Android.Content.Intent p0)
		{
			if (id_getReturnedInitializationResult_Landroid_content_Intent_ == IntPtr.Zero)
				id_getReturnedInitializationResult_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getReturnedInitializationResult", "(Landroid/content/Intent;)Lcom/google/android/youtube/player/YouTubeInitializationResult;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeInitializationResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getReturnedInitializationResult_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
