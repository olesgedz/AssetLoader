using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
public class AddressableLoader : MonoBehaviour
{
    // Start is called before the first frame update
    // IEnumerator Start()
    // {
    //     AsyncOperationHandle<GameObject> a = Addressables.LoadAsset<GameObject>("Cube");
    //
    //     yield return a;
    //
    //     if (a.Status == AsyncOperationStatus.Succeeded)
    //     {
    //         Instantiate(a.Result);
    //         Addressables.Release(a);
    //     }
    //     // Addressables.Instantiate<GameObject>("AssetAddress");
    //
    // }


    public void Start()
    {
        AsyncOperationHandle<GameObject> goHandle =  Addressables.LoadAssetAsync<GameObject>("Cube");
        if (goHandle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log("Ok");
        }

        if (goHandle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log("Fail");
        }
    }

    // private IEnumerator Start()
    // {
        // AsyncOperationHandle<GameObject> goHandle = Addressables.LoadAssetAsync<GameObject>("Cube");
        // Addressables.
        // yield return goHandle;
        // if(goHandle.Status == AsyncOperationStatus.Succeeded)
        // {
        //     GameObject obj = goHandle.Result;
        //     Addressables.InstantiateAsync(obj);
        // }

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

        //Use this only when the objects are no longer needed
        // Addressables.Release(goHandle);
        // Addressables.Release(matHandle);
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}
