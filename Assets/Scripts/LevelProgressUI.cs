using UnityEngine;
using UnityEngine.UI;

public class LevelProgressUI : MonoBehaviour
{
    [Header("UI References")]

    [SerializeField] private Image UiFillImage;


    [Header("Player References")]

    [SerializeField] private Transform PlayerTransform;
    [SerializeField] private Transform EndLineTransform;

    private Vector3 endLinePosition;

    private float fullDistance;


    private void Start()
    {
        endLinePosition = EndLineTransform.position;
        fullDistance = GetDistance();
    }


    private float GetDistance()
    {
        return Vector3.Distance(PlayerTransform.position, endLinePosition);
    }


    private void UpdateProgressFill(float value)
    {
        UiFillImage.fillAmount = value;
    }

    private void Update()
    {
        float newDistance = GetDistance();
        float ProgressValue = Mathf.InverseLerp(fullDistance, 0, newDistance);

        UpdateProgressFill(ProgressValue);
    }
}
