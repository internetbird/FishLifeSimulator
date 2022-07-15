using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FishSimulationManager : MonoBehaviour
{
    private int _numOfFish;

    public Slider numOfFishSlider;
    public TextMeshProUGUI numOfFishSliderText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numOfFishSliderText.text = numOfFishSlider.value.ToString();
        _numOfFish = (int)numOfFishSlider.value;
    }

    public void SpawnFish()
    {

    }
}
