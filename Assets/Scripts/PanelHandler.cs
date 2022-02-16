using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelHandler : MonoBehaviour
{
    [SerializeField]
    private RawImage image;

    [SerializeField]
    private TMPro.TMP_Text text;

    public void SetupPanelHandler(Texture texture)
    {
        image.texture = texture;
        text.SetText(texture.name);
    }
}
