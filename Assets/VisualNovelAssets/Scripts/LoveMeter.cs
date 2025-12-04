using UnityEngine;

public class LoveMeter : MonoBehaviour
{
    public int currentlevel;
    public float maxLove = 100; // The maximum speed of the target ** IN KM/H **
    public float minArrowAngle = 0;
    public float maxArrowAngle = -180;

    [Header("UI")]
    public RectTransform arrow; // The arrow in the speedometer
    private void Update()
    {
        currentlevel = VariablesGlobales.loveLevel;
        if (arrow != null)
        {
            arrow.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minArrowAngle, maxArrowAngle, currentlevel / maxLove));
        }
            
    }
}
