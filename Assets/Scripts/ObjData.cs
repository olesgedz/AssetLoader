using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Address", menuName = "Obj Data", order = 51)]
public class ObjData : ScriptableObject
{
    [SerializeField]
    private string addressableData;

    public string AddressableData
    {
        get
        {
            return addressableData;
        }
    }
}
