using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using  UnityEngine.ResourceManagement;
public class Att : MonoBehaviour
{
    public AssetReference objectToLoad;
    public AssetReference accessoryObjectToLoad;
    private GameObject instatiatedObject;
    private GameObject instantiatedAccessoryObject;
    void Start()
    {
        Addressables.LoadAssetAsync<GameObject>(objectToLoad).Completed += ObjectLoadDone;
    }

    private void ObjectLoadDone(AsyncOperationHandle<GameObject> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            var loadedObject = obj.Result;
            Debug.Log("Loaded");
            instatiatedObject = Instantiate(loadedObject);
            Debug.Log("Inst");
            if (accessoryObjectToLoad != null)
            {
                accessoryObjectToLoad.InstantiateAsync(instatiatedObject.transform).Completed += op =>
                {
                    if (op.Status == AsyncOperationStatus.Succeeded)
                    {
                        instantiatedAccessoryObject = op.Result;
                        Debug.Log("Successfully loaded");
                    }    
                };
            }

        }
    }
    void Update()
    {
        
    }
}
