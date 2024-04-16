using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
    [SerializeField] private GameObject hasProgressBarGameObject;
    [SerializeField] private Image barImage;

    private IHasProgressBar hasProgressBar;

    private void Start()
    {
        hasProgressBar = hasProgressBarGameObject.GetComponent<IHasProgressBar>();
        hasProgressBar.OnProgressChanged += HasProgressBar_OnProgressChanged;
        barImage.fillAmount = 0f;
        Hide();
    }

    private void HasProgressBar_OnProgressChanged(object sender, IHasProgressBar.OnProgressChangedEventArgs e)
    {
        barImage.fillAmount = e.progressNormalized;

        if (e.progressNormalized == 0f || e.progressNormalized == 1f) {
            Hide();
        } else {
            Show();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
