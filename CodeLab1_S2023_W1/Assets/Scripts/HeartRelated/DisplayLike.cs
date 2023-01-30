using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayLike : MonoBehaviour
{
    ////connect with script LikeValue's animal like value variables
    //public LikeValue eleLikePoints;
    //public LikeValue girLikePoints;

    //set up text in inspector
    public TextMeshProUGUI eleLikeText;
    public TextMeshProUGUI girLikeText;

    void Update()
    {
        eleLikeText.text = "Ellie likes you this much: " + (int)StoreValue.totalEleLike;
        girLikeText.text = "Giovanni likes you this much: " + (int)StoreValue.totalGirLike;
    }

}
