using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search_btn : MonoBehaviour
{
    public string searchbar;
    public GameObject searchInput;
    public GameObject result;

    public void GetResult()
    {
        searchbar = searchInput.GetComponent<Text>().text;
        string[] textlist = { "Hamburger", "Sandwish", "Noodle", "Steak", "Pizza" };

        bool found = false;

        for (int i = 0; i < textlist.Length; i++)
        {
            if (textlist[i] == searchbar)
            {
                found = true;
                result.GetComponent<Text>().text = "[ " + searchbar + " ] is found";
            }
        }
        if (!found)
        {
            result.GetComponent<Text>().text = "[ " + searchbar + " ] is not found";
        }
    }
}
