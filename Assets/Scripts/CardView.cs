using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] private Text title;
    [SerializeField] private Text description;
    [SerializeField] private Text exhibit;
    [SerializeField] private Image photo;

    [SerializeField] private CardModel[] cards;

    public void OpenCard(int index)
    {
        var card = cards[index];

        title.text = card.Title;
        description.text = card.Description;
        exhibit.text = card.Exhibit;
        photo.sprite = card.Photo;

        this.gameObject.SetActive(true);
    }
}
