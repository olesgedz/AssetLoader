using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ExitGames.Client.Photon.StructWrapping;
using UnityEngine.Networking;

public class CacheBundleWebLoader : MonoBehaviour
{
  public string bundleUrl = "http://localhost/assetbundles/testbundle";
  public string assetName = "BundledSpriteObject";
  [SerializeField] private CachedAssetBundle _assetBundle;
  private IEnumerator Start()
  {
    using (UnityWebRequest  web =  UnityWebRequestAssetBundle.GetAssetBundle(bundleUrl, _assetBundle))
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
