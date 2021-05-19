using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using  UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.UI;

public class Att : MonoBehaviour
{
    public AssetReference objectToLoad;
    public AssetReference accessoryObjectToLoad;
    private GameObject instatiatedObject;
    private GameObject instantiatedAccessoryObject;
    [SerializeField] private Text text;

    private void Start()
    {
    }
    void Update()
    {
      if ( Input.GetKeyDown(KeyCode.A))
      {
          Debug.Log("Start loading");
          StartCoroutine(LoadGameObjectAndMaterial());
      }
    }
    IEnumerator LoadGameObjectAndMaterial()
    {
        //Load a GameObject
        AsyncOperationHandle<GameObject> goHandle = Addressables.LoadAssetAsync<GameObject>(objectToLoad);
        Debug.Log(goHandle.PercentComplete  * 100 + "%  ");
        text.text = goHandle.PercentComplete * 100 + "%  ";
        yield return goHandle;
        if(goHandle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log(goHandle.PercentComplete  * 100 + "%  ");
            text.text = goHandle.PercentComplete * 100 + "%  ";
            GameObject obj = goHandle.Result;
            //etc...
            Instantiate(obj);
        }

        // //Load a Material
        // AsyncOperationHandle<IList<IResourceLocation>> locationHandle = Addressables.LoadResourceLocationsAsync("materialKey");
        // yield return locationHandle;
        // AsyncOperationHandle<Material> matHandle = Addressables.LoadAssetAsync<Material>(locationHandle.Result[0]);
        // yield return matHandle;
        // if (matHandle.Status == AsyncOperationStatus.Succeeded)
        // {
        //     Material mat = matHandle.Result;
        //     //etc...
        // }

        // //Use this only when the objects are no longer needed
        // Addressables.Release(goHandle);
        // Addressables.Release(matHandle);
    }
    
    // void Start()
    // {
    //     Addressables.LoadAssetAsync<GameObject>(objectToLoad).Completed += ObjectLoadDone;
    //     // LoadAsset();
    //     // Addressables.LoadAssetAsync<GameObject>(objectToLoad);
    // }
    //
    // private void ObjectLoadDone(AsyncOperationHandle<GameObject> obj)
    // {
    //     
    //     if (obj.Status == AsyncOperationStatus.Succeeded)
    //     {
    //         Debug.Log(obj.PercentComplete.ToString());
    //         var loadedObject = obj.Result;
    //         Debug.Log("Loaded");
    //         instatiatedObject = Instantiate(loadedObject);
    //         Debug.Log("Inst");
    //         if (accessoryObjectToLoad != null)
    //         {
    //             accessoryObjectToLoad.InstantiateAsync(instatiatedObject.transform).Completed += op =>
    //             {
    //                 if (op.Status == AsyncOperationStatus.Succeeded)
    //                 {
    //                     instantiatedAccessoryObject = op.Result;
    //                     Debug.Log("Successfully loaded");
    //                 }    
    //             };
    //         }
    //
    //     }
    //     else
    //     {
    //         Debug.Log(obj.PercentComplete.ToString());
    //     }
    // }
    //
    // // private void Start()
    // // {
    // //     StartCoroutine(LoadAsset());
    // // }
    // //
    // IEnumerator LoadAsset()
    // {
    //     var isDone = false;
    //
    //     var download = Addressables.DownloadDependenciesAsync("Cube");
    //     download.Completed += (operation) =>
    //     {
    //         isDone = true;
    //         Debug.Log(download.PercentComplete);
    //       
    //         // _slider.value = _slider.maxValue;
    //     };
    //
    //     while (!isDone)
    //     {
    //         // _slider.value = download.PercentComplete;
    //         Debug.Log(download.PercentComplete);
    //         yield return 0f;
    //     }
    //
    //     yield return new WaitUntil(() => isDone);
    // }
   
}
