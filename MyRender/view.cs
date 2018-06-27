using UnityEngine;
using System.Collections;
/// <summary>
/// Refraction.
/// 使用材质球渲染频幕
/// </summary>
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class view : MonoBehaviour
{
    public Material curMaterial;
    // Use this for initialization
    void Start()
    {
        if (curMaterial == null || curMaterial.shader.isSupported == false)
        {
            enabled = false; //材质球不支持则false
        }
    }
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, curMaterial);
    }
    // Update is called once per frame
    void Update()
    {
        if (curMaterial == null)
            enabled = false;
    }
}