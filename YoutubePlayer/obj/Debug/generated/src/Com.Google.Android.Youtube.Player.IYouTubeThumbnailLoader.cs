using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Youtube.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailLoader.ErrorReason']"
	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason", DoNotGenerateAcw=true)]
	public sealed partial class YouTubeThumbnailLoaderErrorReason : global::Java.Lang.Enum {


		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailLoader.ErrorReason']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailLoader.ErrorReason']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public static global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason NetworkError {
			get {
				if (NETWORK_ERROR_jfieldId == IntPtr.Zero)
					NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_ERROR", "Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailLoader.ErrorReason']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YouTubeThumbnailLoaderErrorReason); }
		}

		internal YouTubeThumbnailLoaderErrorReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailLoader.ErrorReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;", "")]
		public static unsafe global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/class[@name='YouTubeThumbnailLoader.ErrorReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;", "")]
		public static unsafe global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;");
			try {
				return (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader.OnThumbnailLoadedListener']"
	[Register ("com/google/android/youtube/player/YouTubeThumbnailLoader$OnThumbnailLoadedListener", "", "Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker")]
	public partial interface IYouTubeThumbnailLoaderOnThumbnailLoadedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader.OnThumbnailLoadedListener']/method[@name='onThumbnailError' and count(parameter)=2 and parameter[1][@type='com.google.android.youtube.player.YouTubeThumbnailView'] and parameter[2][@type='com.google.android.youtube.player.YouTubeThumbnailLoader.ErrorReason']]"
		[Register ("onThumbnailError", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;)V", "GetOnThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_Handler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker, YoutubePlayer")]
		void OnThumbnailError (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader.OnThumbnailLoadedListener']/method[@name='onThumbnailLoaded' and count(parameter)=2 and parameter[1][@type='com.google.android.youtube.player.YouTubeThumbnailView'] and parameter[2][@type='java.lang.String']]"
		[Register ("onThumbnailLoaded", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Ljava/lang/String;)V", "GetOnThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_Handler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker, YoutubePlayer")]
		void OnThumbnailLoaded (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, string p1);

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeThumbnailLoader$OnThumbnailLoadedListener", DoNotGenerateAcw=true)]
	internal class IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker : global::Java.Lang.Object, IYouTubeThumbnailLoaderOnThumbnailLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeThumbnailLoader$OnThumbnailLoadedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IYouTubeThumbnailLoaderOnThumbnailLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubeThumbnailLoaderOnThumbnailLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubeThumbnailLoader.OnThumbnailLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubeThumbnailLoaderOnThumbnailLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_;
#pragma warning disable 0169
		static Delegate GetOnThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_Handler ()
		{
			if (cb_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_ == null)
				cb_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_);
			return cb_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_;
		}

		static void n_OnThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnThumbnailError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_;
		public unsafe void OnThumbnailError (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason p1)
		{
			if (id_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_ == IntPtr.Zero)
				id_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_ = JNIEnv.GetMethodID (class_ref, "onThumbnailError", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Lcom/google/android/youtube/player/YouTubeThumbnailLoader$ErrorReason;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onThumbnailError_Lcom_google_android_youtube_player_YouTubeThumbnailView_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_ErrorReason_, __args);
		}

		static Delegate cb_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_Handler ()
		{
			if (cb_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_ == null)
				cb_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_);
			return cb_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_;
		}

		static void n_OnThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnThumbnailLoaded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_;
		public unsafe void OnThumbnailLoaded (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, string p1)
		{
			if (id_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_ == IntPtr.Zero)
				id_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onThumbnailLoaded", "(Lcom/google/android/youtube/player/YouTubeThumbnailView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_onThumbnailLoaded_Lcom_google_android_youtube_player_YouTubeThumbnailView_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class ThumbnailErrorEventArgs : global::System.EventArgs {

		public ThumbnailErrorEventArgs (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0;
		public global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason p1;
		public global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason P1 {
			get { return p1; }
		}
	}

	public partial class ThumbnailLoadedEventArgs : global::System.EventArgs {

		public ThumbnailLoadedEventArgs (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0;
		public global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/youtube/player/YouTubeThumbnailLoader_OnThumbnailLoadedListenerImplementor")]
	internal sealed partial class IYouTubeThumbnailLoaderOnThumbnailLoadedListenerImplementor : global::Java.Lang.Object, IYouTubeThumbnailLoaderOnThumbnailLoadedListener {

		object sender;

		public IYouTubeThumbnailLoaderOnThumbnailLoadedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/youtube/player/YouTubeThumbnailLoader_OnThumbnailLoadedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ThumbnailErrorEventArgs> OnThumbnailErrorHandler;
#pragma warning restore 0649

		public void OnThumbnailError (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, global::Com.Google.Android.Youtube.Player.YouTubeThumbnailLoaderErrorReason p1)
		{
			var __h = OnThumbnailErrorHandler;
			if (__h != null)
				__h (sender, new ThumbnailErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ThumbnailLoadedEventArgs> OnThumbnailLoadedHandler;
#pragma warning restore 0649

		public void OnThumbnailLoaded (global::Com.Google.Android.Youtube.Player.YouTubeThumbnailView p0, string p1)
		{
			var __h = OnThumbnailLoadedHandler;
			if (__h != null)
				__h (sender, new ThumbnailLoadedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IYouTubeThumbnailLoaderOnThumbnailLoadedListenerImplementor value)
		{
			return value.OnThumbnailErrorHandler == null && value.OnThumbnailLoadedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']"
	[Register ("com/google/android/youtube/player/YouTubeThumbnailLoader", "", "Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker")]
	public partial interface IYouTubeThumbnailLoader : IJavaObject {

		bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")] get;
		}

		bool HasPrevious {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='hasPrevious' and count(parameter)=0]"
			[Register ("hasPrevious", "()Z", "GetHasPreviousHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='first' and count(parameter)=0]"
		[Register ("first", "()V", "GetFirstHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void First ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()V", "GetNextHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void Next ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='previous' and count(parameter)=0]"
		[Register ("previous", "()V", "GetPreviousHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void Previous ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='setOnThumbnailLoadedListener' and count(parameter)=1 and parameter[1][@type='com.google.android.youtube.player.YouTubeThumbnailLoader.OnThumbnailLoadedListener']]"
		[Register ("setOnThumbnailLoadedListener", "(Lcom/google/android/youtube/player/YouTubeThumbnailLoader$OnThumbnailLoadedListener;)V", "GetSetOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_Handler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void SetOnThumbnailLoadedListener (global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='setPlaylist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPlaylist", "(Ljava/lang/String;)V", "GetSetPlaylist_Ljava_lang_String_Handler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void SetPlaylist (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='setPlaylist' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setPlaylist", "(Ljava/lang/String;I)V", "GetSetPlaylist_Ljava_lang_String_IHandler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void SetPlaylist (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.youtube.player']/interface[@name='YouTubeThumbnailLoader']/method[@name='setVideo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVideo", "(Ljava/lang/String;)V", "GetSetVideo_Ljava_lang_String_Handler:Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderInvoker, YoutubePlayer")]
		void SetVideo (string p0);

	}

	[global::Android.Runtime.Register ("com/google/android/youtube/player/YouTubeThumbnailLoader", DoNotGenerateAcw=true)]
	internal class IYouTubeThumbnailLoaderInvoker : global::Java.Lang.Object, IYouTubeThumbnailLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/youtube/player/YouTubeThumbnailLoader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IYouTubeThumbnailLoaderInvoker); }
		}

		IntPtr class_ref;

		public static IYouTubeThumbnailLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IYouTubeThumbnailLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.youtube.player.YouTubeThumbnailLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IYouTubeThumbnailLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		IntPtr id_hasNext;
		public unsafe bool HasNext {
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasNext);
			}
		}

		static Delegate cb_hasPrevious;
#pragma warning disable 0169
		static Delegate GetHasPreviousHandler ()
		{
			if (cb_hasPrevious == null)
				cb_hasPrevious = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPrevious);
			return cb_hasPrevious;
		}

		static bool n_HasPrevious (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPrevious;
		}
#pragma warning restore 0169

		IntPtr id_hasPrevious;
		public unsafe bool HasPrevious {
			get {
				if (id_hasPrevious == IntPtr.Zero)
					id_hasPrevious = JNIEnv.GetMethodID (class_ref, "hasPrevious", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasPrevious);
			}
		}

		static Delegate cb_first;
#pragma warning disable 0169
		static Delegate GetFirstHandler ()
		{
			if (cb_first == null)
				cb_first = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_First);
			return cb_first;
		}

		static void n_First (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.First ();
		}
#pragma warning restore 0169

		IntPtr id_first;
		public unsafe void First ()
		{
			if (id_first == IntPtr.Zero)
				id_first = JNIEnv.GetMethodID (class_ref, "first", "()V");
			JNIEnv.CallVoidMethod (Handle, id_first);
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static void n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Next ();
		}
#pragma warning restore 0169

		IntPtr id_next;
		public unsafe void Next ()
		{
			if (id_next == IntPtr.Zero)
				id_next = JNIEnv.GetMethodID (class_ref, "next", "()V");
			JNIEnv.CallVoidMethod (Handle, id_next);
		}

		static Delegate cb_previous;
#pragma warning disable 0169
		static Delegate GetPreviousHandler ()
		{
			if (cb_previous == null)
				cb_previous = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Previous);
			return cb_previous;
		}

		static void n_Previous (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Previous ();
		}
#pragma warning restore 0169

		IntPtr id_previous;
		public unsafe void Previous ()
		{
			if (id_previous == IntPtr.Zero)
				id_previous = JNIEnv.GetMethodID (class_ref, "previous", "()V");
			JNIEnv.CallVoidMethod (Handle, id_previous);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (Handle, id_release);
		}

		static Delegate cb_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_Handler ()
		{
			if (cb_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_ == null)
				cb_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_);
			return cb_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_;
		}

		static void n_SetOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener p0 = (global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnThumbnailLoadedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_;
		public unsafe void SetOnThumbnailLoadedListener (global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoaderOnThumbnailLoadedListener p0)
		{
			if (id_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_ == IntPtr.Zero)
				id_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_ = JNIEnv.GetMethodID (class_ref, "setOnThumbnailLoadedListener", "(Lcom/google/android/youtube/player/YouTubeThumbnailLoader$OnThumbnailLoadedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setOnThumbnailLoadedListener_Lcom_google_android_youtube_player_YouTubeThumbnailLoader_OnThumbnailLoadedListener_, __args);
		}

		static Delegate cb_setPlaylist_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlaylist_Ljava_lang_String_Handler ()
		{
			if (cb_setPlaylist_Ljava_lang_String_ == null)
				cb_setPlaylist_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaylist_Ljava_lang_String_);
			return cb_setPlaylist_Ljava_lang_String_;
		}

		static void n_SetPlaylist_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaylist (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlaylist_Ljava_lang_String_;
		public unsafe void SetPlaylist (string p0)
		{
			if (id_setPlaylist_Ljava_lang_String_ == IntPtr.Zero)
				id_setPlaylist_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlaylist", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setPlaylist_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPlaylist_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetPlaylist_Ljava_lang_String_IHandler ()
		{
			if (cb_setPlaylist_Ljava_lang_String_I == null)
				cb_setPlaylist_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetPlaylist_Ljava_lang_String_I);
			return cb_setPlaylist_Ljava_lang_String_I;
		}

		static void n_SetPlaylist_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaylist (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPlaylist_Ljava_lang_String_I;
		public unsafe void SetPlaylist (string p0, int p1)
		{
			if (id_setPlaylist_Ljava_lang_String_I == IntPtr.Zero)
				id_setPlaylist_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setPlaylist", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_setPlaylist_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setVideo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideo_Ljava_lang_String_Handler ()
		{
			if (cb_setVideo_Ljava_lang_String_ == null)
				cb_setVideo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideo_Ljava_lang_String_);
			return cb_setVideo_Ljava_lang_String_;
		}

		static void n_SetVideo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Youtube.Player.IYouTubeThumbnailLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideo (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVideo_Ljava_lang_String_;
		public unsafe void SetVideo (string p0)
		{
			if (id_setVideo_Ljava_lang_String_ == IntPtr.Zero)
				id_setVideo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVideo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setVideo_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
