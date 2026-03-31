using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] private Transform mainCam;
    [SerializeField] private Transform midBg;
    [SerializeField] private Transform sideBg;
    [SerializeField] private float lenght;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCam.position.x > midBg.position.x)
        {
            UpdateBackgroundPosition(Vector3.right);
        }
        else
        {
            UpdateBackgroundPosition(Vector3.left);
        }
    }
    void UpdateBackgroundPosition(Vector3 direction)
    {
        sideBg.position = midBg.position + direction * lenght;
        (midBg,sideBg)=(sideBg,midBg);
        /*Transform temp = sideBg.transform;
        midBg = sideBg;
        sideBg=temp;*/
    }
}
