using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class MercenaryScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Lua.Run("return Variable['CharState'].AdvisorActive").asBool)
        {
            gameObjectAdvisor.setActive(true);
        }
        else
        {
            gameObjectAdvisor.setActive(false);
        }
    }
}
