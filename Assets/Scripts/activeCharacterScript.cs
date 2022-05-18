using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class activeCharacterScript : MonoBehaviour
{
    public string variableName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Lua.Run("return Variable['CharState."+variableName+"']").asBool)
        {
            transform.position = new Vector3(transform.position.x, -0.12f, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, -40f, transform.position.z);
        }
    }
}
