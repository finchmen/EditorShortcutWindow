using UnityEditor;
using UnityEngine;

namespace EditorWindowTools
{
    /// <summary>
    /// ★ よく使うツールのショートカットウィンドウを生成するクラス
    /// </summary>
    public class EditorShortcutWindow : EditorWindow
    {
        
        private Vector2 scrollPos = Vector2.zero;

        // ◆ ウィンドウの登録 =============================================================================================================
        [MenuItem("Window/ShortcutWindow")]
        public static void Open()
        {
            EditorWindow window = GetWindow(typeof(EditorShortcutWindow), false, "Shortcut");
            window.minSize = new Vector2(window.minSize.x, 24);
            window.titleContent.image = EditorGUIUtility.IconContent("d_winbtn_win_rest").image;           // ★ のマーク
        }

        // ◆ OnGUI() ==============================================================================================================================
        private void OnGUI()
        {
            scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUI.skin.scrollView);
            EditorGUILayout.BeginHorizontal();


            // Build / Debug 系 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [Build Settings...] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("BuildSettings.Editor.Small"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "File/Build Settings..." );
            }
            GUILayout.Space(-5);

            // [Build And Run] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("preAudioPlayOn"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "File/Build And Run" );
            }
            GUILayout.Space(-5);

            // [Profiler] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("d_UnityEditor.ProfilerWindow"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/Analysis/Profiler" );
            }
            GUILayout.Space(-5);

            // [Frame Debugger] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("d_UnityEditor.Timeline.TimelineWindow"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/Analysis/Frame Debugger" );
            }

            
            // Animation / Audio 系 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [Animator] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("UnityEditor.Graphs.AnimatorControllerTool"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/Animation/Animator" );
            }
            GUILayout.Space(-5);

            // [Animaton] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("UnityEditor.AnimationWindow"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/Animation/Animation" );
            }
            GUILayout.Space(-5);

            // [Audio Mixer] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("d_SceneViewAudio"), GUILayout.Width(28)))
            {
                EditorApplication.ExecuteMenuItem( "Window/Audio/Audio Mixer" );
            }
            

            // 3D 系 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [Navigation] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("Navigation"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/AI/Navigation" );
            }
            GUILayout.Space(-5);
            // [Lighting] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("Lightmapping"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/Rendering/Lighting Settings" );
            }


            // Setting 系 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [Project Settings] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("Settings"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Edit/Project Settings..." );
            }
            GUILayout.Space(-5);

            // [Service] -----
            if(GUILayout.Button(EditorGUIUtility.IconContent("UnityEditor.FindDependencies"), GUILayout.Width(28), GUILayout.Height(20)))
            {
                EditorApplication.ExecuteMenuItem( "Window/General/Services" );
            }


            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndScrollView();
        }

    }
}
