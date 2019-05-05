using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertManagement : MonoBehaviour
{
    public static List<FieldManager> antrian = new List<FieldManager>();
    
    void Update()
    {
        if (!(antrian.Count == 0))
        {
            GameInput.invert = antrian[0].invertable;
        }
    }
}
