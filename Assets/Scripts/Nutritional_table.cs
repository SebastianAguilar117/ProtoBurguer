using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nutritional_table : MonoBehaviour
{
    public int _qtty;
    public TMP_Text statText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStat(int qtty)
    {
        _qtty += qtty;
        statText.text = _qtty.ToString();
    }
}
