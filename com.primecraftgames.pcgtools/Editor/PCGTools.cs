using System.IO;
using UnityEditor;
using UnityEngine;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace primecraftgames.Editor
{
    public static class PcgTools
    {
        [MenuItem("PCG Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Folder("_Project", "Data", "Audio", "Art", "Code", "Level");
            Folder("_Project/Code", "Scripts");
            Folder("_Project/Code/Scripts", "Model", "View", "Controller");
            Folder("_Project/Art", "Materials", "Models", "Shaders", "Textures", "Animations", "Animators", "Effects", "Sprites");
            Folder("_Project/Audio", "Music", "SFX");
            Folder("_Project/Level", "Prefabs", "Scenes", "UI");
            Folder("_Sandbox", "");
            Folder("Documentation", "");
            Folder("Plugins", "");
            Folder("Resources", "");
            Folder("Settings", "");
            Folder("StreamingAssets", "");
            Folder("ThirdParty", "");
            Refresh();
        }

        private static void Folder(string rootFolder, params string[] folders)
        {
            var path = dataPath + "/" + rootFolder;
            foreach (var folder in folders)
            {
                CreateDirectory(Combine(path, folder));
            }
        }
    }
}
