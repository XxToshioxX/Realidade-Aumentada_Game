using UnityEngine;
using Vuforia;

public class ModelSwapper : MonoBehaviour
{
    public ObserverBehaviour mTarget;
    private bool mSwapModel = false;

    public GameObject objeto;
    // Use this for initialization
    void Start()
    {
        if (mTarget == null)
        {
            Debug.Log("Warning: Target not set !!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (mSwapModel && mTarget != null)
        {
            SwapModel();
            mSwapModel = false;
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 120, 40), "Swap Model"))
        {
            mSwapModel = true;
        }
    }
    private void SwapModel()
    {
        // Disable any pre-existing augmentation
        GameObject mExistingModel = mTarget.gameObject;

        for (int i = 0; i < mExistingModel.transform.childCount; i++)
        {
            Transform child = mExistingModel.transform.GetChild(i);
            child.gameObject.SetActive(false);
        }

        // Create a simple cube object
        //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Re-parent the cube as child of the trackable gameObject
        objeto.transform.parent = mTarget.transform;

        // Adjust the position and scale
        // so that it fits nicely on the target
        objeto.transform.localPosition = new Vector3(0, 0.2f, 0);
        objeto.transform.localRotation = Quaternion.identity;
        objeto.transform.localScale = new Vector3(50f, 50f, 50f);
        // Make sure it is active
        objeto.SetActive(true);
    }
}
