using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using  UnityEngine.ResourceManagement;
// public class AddressablesUtil : MonoBehaviour
// {
//     public static async Task<GameObject> WaitForAssetToLoad(string key, Action<double, long, string> percentageCompleteCallback = null)
//     {
//         AsyncOperationHandle<long> sizeHandle = Addressables.GetDownloadSizeAsync(key);
//  
//         await new WaitUntil(() => sizeHandle.IsDone);
//  
//         long b = sizeHandle.Result;
//         AsyncOperationHandle<GameObject> loadAssetHandle = Addressables.LoadAssetAsync<GameObject>(key);
//         while (loadAssetHandle.IsDone != true)
//         {
//             percentageCompleteCallback?.Invoke(loadAssetHandle.PercentComplete * sizeHandle.Result, sizeHandle.Result, key);
//             await new WaitForEndOfFrame();
//         }
//  
//         return loadAssetHandle.Result;
//     }
//     public async Task<LoadedAssetList> LoadAssets(List<string> assetsToLoad)
//     {
//         LoadedAssetList _loadedAssetList = new LoadedAssetList();
//         _maximumPercentageAmount = assetsToLoad.Count;
//         foreach (string item in assetsToLoad)
//         {
//             _loadedAssetList.AddAsset(item, await AddressablesUtil.WaitForAssetToLoad(item, _UpdateLoadedPercentageTotal));
//         }
//      
//         return _loadedAssetList;
//     }
// }
