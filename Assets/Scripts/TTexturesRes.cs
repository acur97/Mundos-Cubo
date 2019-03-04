using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTexturesRes : MonoBehaviour {
    
    public RenderTexture RPared1;
    public RenderTexture RPared2;
    public RenderTexture RPared3;
    public RenderTexture RPared4;
    [Space]
    public Material MPared1;
    public Material MPared2;
    public Material MPared3;
    public Material MPared4;
    [Space]
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;

    private int w;
    private int h;

    private RenderTexture LiveRTexture1;
    private RenderTexture LiveRTexture2;
    private RenderTexture LiveRTexture3;
    private RenderTexture LiveRTexture4;

    private void Start()
    {
        w = Screen.width;
        h = Screen.height;

        cam1.targetTexture.Release();
        LiveRTexture1 = new RenderTexture(w, h, 24, RenderTextureFormat.DefaultHDR, RenderTextureReadWrite.Linear);
        cam1.targetTexture = LiveRTexture1;
        MPared1.mainTexture = LiveRTexture1;

        cam2.targetTexture.Release();
        LiveRTexture2 = new RenderTexture(w, h, 24, RenderTextureFormat.DefaultHDR, RenderTextureReadWrite.Linear);
        cam2.targetTexture = LiveRTexture2;
        MPared2.mainTexture = LiveRTexture2;

        cam3.targetTexture.Release();
        LiveRTexture3 = new RenderTexture(w, h, 24, RenderTextureFormat.DefaultHDR, RenderTextureReadWrite.Linear);
        cam3.targetTexture = LiveRTexture3;
        MPared3.mainTexture = LiveRTexture3;

        cam4.targetTexture.Release();
        LiveRTexture4 = new RenderTexture(w, h, 24, RenderTextureFormat.DefaultHDR, RenderTextureReadWrite.Linear);
        cam4.targetTexture = LiveRTexture4;
        MPared4.mainTexture = LiveRTexture4;
    }

    private void OnApplicationQuit()
    {
        cam1.targetTexture = RPared1;
        cam2.targetTexture = RPared2;
        cam3.targetTexture = RPared3;
        cam4.targetTexture = RPared4;

        MPared1.mainTexture = RPared1;
        MPared2.mainTexture = RPared2;
        MPared3.mainTexture = RPared3;
        MPared4.mainTexture = RPared4;
    }
}
