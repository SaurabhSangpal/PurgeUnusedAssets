using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Sangpal.PurgeUnusedAssets;

public class PurgeUnusedAssets : MonoBehaviour
{
    [MenuItem("Tools/PUA/Purge Assets")]
    public static void PurgeAssets() {
        var _root = SceneManager.GetActiveScene().GetRootGameObjects();

        for (int i = 0; i < _root.Length; i++) {
            var _unusedAsset = _root[i].GetComponent<UnusedAsset>();
            if (_unusedAsset != null) {
                DestroyImmediate(_root[i]);
                continue;
            }

            var _children = _root[i].GetComponentsInChildren<UnusedAsset>(true);
            if (_children.Length == 0) continue;

            for (int j = 0; j < _children.Length; j++) {
                DestroyImmediate(_children[j].gameObject);
            }
        }
    }
}