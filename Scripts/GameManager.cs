using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text pointText;
    [SerializeField] private float points = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        CountPoints();
        

    }

    private void CountPoints()
    {
        points += Time.deltaTime;
        pointText.text = $"POINTS: {Mathf.Round(points)}";
    }
}
