using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class MercenaryScript : MonoBehaviour
{
    public string variableName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Lua.Run("return Variable['CharState."+variableName+"']").asBool);
    }

    // Update is called once per frame
    void Update()
    {
        if (Lua.Run("return Variable['CharState."+variableName+"']").asBool)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
