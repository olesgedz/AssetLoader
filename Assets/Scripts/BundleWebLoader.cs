using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ExitGames.Client.Photon.StructWrapping;
using UnityEngine.Networking;

public class BundleWebLoader : MonoBehaviour
{
  public string bundleUrl = "http://localhost/assetbundles/testbundle";
  public string assetName = "BundledSpriteObject";

  private IEnumerator Start()
  {
    using (UnityWebRequest  web =  UnityWebRequestAssetBundle.GetAssetBundle(bundleUrl))
    {
      yield return web.SendWebRequest();
      AssetBundle remoteAssetBundle = DownloadHandlerAssetBundle.GetContent(web);
      if (remoteAssetBundle == null)
      {
        Debug.LogError("Failed to download AssetBundle");
        yield break;
      }

      Instantiate(remoteAssetBundle.LoadAsset(assetName));
      remoteAssetBundle.Unload(false);
    }
  }
}
