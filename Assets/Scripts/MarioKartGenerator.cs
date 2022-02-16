using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MarioKartGenerator : MonoBehaviour
{
    [SerializeField]
    public PanelHandler characterPH, bodyPH, tirePH, gliderPH;

    [SerializeField]
    private List<Texture> characters, bodies, tires, gliders;

    void Start()
    {
        RandomizeIt();
    }

    public void RandomizeIt()
    {
        var random = new System.Random();

        characterPH.SetupPanelHandler(characters[random.Next(characters.Count)]);
        bodyPH.SetupPanelHandler(bodies[random.Next(bodies.Count)]);
        tirePH.SetupPanelHandler(tires[random.Next(tires.Count)]);
        gliderPH.SetupPanelHandler(gliders[random.Next(gliders.Count)]);
    }
}
