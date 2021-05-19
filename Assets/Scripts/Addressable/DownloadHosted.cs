using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class DownloadHosted : MonoBehaviour
{
    [SerializeField] private string _label;

    public void Start()
    {
        
    }

    public  void Press()
    {
        Get(_label);
    }
    private async Task Get(string label)
    {
        var locations = await Addressables.LoadResourceLocationsAsync(label).Task;
        Debug.Log(locations.ToString());
        
        foreach (var location in locations)
        {
            await Addressables.InstantiateAsync(location).Task;
        }
    }
}
