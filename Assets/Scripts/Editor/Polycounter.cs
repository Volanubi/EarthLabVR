using UnityEngine;
using UnityEditor;

public class Polycounter : Editor
{
    [MenuItem("GameObject/Count Polygons")]
    public static void CountPolygons()
    {
        GameObject go;

        Object prefabRoot = PrefabUtility
            .GetCorrespondingObjectFromSource(Selection.activeGameObject);

        if (prefabRoot != null)
            go = (GameObject)prefabRoot;
        else
            go = Selection.activeGameObject;

        MeshFilter[] meshFilters = go.GetComponentsInChildren<MeshFilter>();
        int polyCount = 0;
        foreach (MeshFilter meshFilter in meshFilters)
        {
            Mesh mesh = meshFilter.sharedMesh;
            polyCount += mesh.triangles.Length / 3;
        }

        if (meshFilters.Length > 0)
            Debug.Log("Object " + go.name + " contains <b><color=yellow>" + meshFilters.Length
                + " meshes </color></b> with total <b><color=red>"
                + polyCount + " triangles</color></b>");
        else
            Debug.Log("<b><color=green>Object " + go.name + " does not contain any mesh - keep looking</color></b>");
    }
}