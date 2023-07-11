using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetInformation : MonoBehaviour
{
    public TMP_Text TextObject;

    // Start is called before the first frame update
    public void SetName(string name)
    {
        TextObject.text = name;
    }
}
